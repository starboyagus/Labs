using Fiorini.Dominio;
using Fiorini.Negocio;

namespace Fiorini.Presentacion
{
    public partial class FormAlta : Form
    {
        private readonly AlquilerNegocio _negocio = new();

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today.AddYears(1);
            txtInquilino.Focus();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            // El usuario no indica el Estado: lo pre-setea el servicio como "Activo".
            var alquiler = new Alquiler
            {
                Inquilino = txtInquilino.Text.Trim(),
                MontoAlquiler = nudMontoAlquiler.Value,
                FechaInicio = dtpFechaInicio.Value.Date,
                FechaFin = dtpFechaFin.Value.Date
            };

            // Validación previa en el cliente (la API vuelve a validar del lado del servicio)
            var errores = alquiler.Validar();
            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errores),
                    "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnAceptar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var creado = await _negocio.AgregarAsync(alquiler);

                MessageBox.Show($"Alquiler N° {creado.Id} creado correctamente con estado \"{creado.Estado}\".",
                    "Alta de alquiler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnAceptar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
