namespace AcademiaABM
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            List<Usuario> listaUsuarios = new List<Usuario>() {

            new Usuario() { Id = 1, Nombre = "Juan Perez", Email = "juanperez@ex.com" },
            new Usuario() { Id = 2, Nombre = "Jota Pe", Email = "JP@ex.com" },
            new Usuario() { Id = 3, Nombre = "Agus Gil", Email = "agusgil@ex.com" }
            };

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Email { get; set; }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
