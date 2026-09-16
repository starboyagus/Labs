using Fiorini.Dominio;
using Fiorini.Negocio;

namespace Fiorini.Presentacion
{
    public partial class FormListado : Form
    {
        private readonly AlquilerNegocio _negocio = new();

        public FormListado()
        {
            InitializeComponent();
        }

        private async void FormListado_Load(object sender, EventArgs e)
        {
            // Control tipo lista con los valores pre-seteados "Activo" y "Finalizado"
            cboEstado.DataSource = EstadoAlquiler.Todos.ToList();
            cboEstado.SelectedItem = EstadoAlquiler.Activo;

            ConfigurarGrilla();
            await CargarGrillaAsync();
        }

        private void ConfigurarGrilla()
        {
            dgvAlquileres.AutoGenerateColumns = false;
            dgvAlquileres.Columns.Clear();

            dgvAlquileres.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Alquiler.Id),
                HeaderText = "Id",
                Width = 50
            });
            dgvAlquileres.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Alquiler.Inquilino),
                HeaderText = "Inquilino",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvAlquileres.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Alquiler.MontoAlquiler),
                HeaderText = "Monto",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
            dgvAlquileres.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Alquiler.FechaInicio),
                HeaderText = "Fecha Inicio",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvAlquileres.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Alquiler.FechaFin),
                HeaderText = "Fecha Fin",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvAlquileres.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Alquiler.Estado),
                HeaderText = "Estado",
                Width = 90
            });
        }

        /// <summary>
        /// Consume el servicio de búsqueda por estado y actualiza el listado en pantalla.
        /// </summary>
        private async Task CargarGrillaAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var estado = cboEstado.SelectedItem?.ToString() ?? EstadoAlquiler.Activo;
                var alquileres = await _negocio.ObtenerPorEstadoAsync(estado);

                dgvAlquileres.DataSource = alquileres;
                dgvAlquileres.ClearSelection();
                lblTotal.Text = $"{alquileres.Count} alquiler(es) en estado {estado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo obtener el listado de alquileres. Verifique que la API esté en ejecución." +
                    Environment.NewLine + Environment.NewLine + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await CargarGrillaAsync();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            using var formAlta = new FormAlta();
            if (formAlta.ShowDialog(this) == DialogResult.OK)
            {
                // Los alquileres nuevos siempre nacen como "Activo": muestro ese estado.
                cboEstado.SelectedItem = EstadoAlquiler.Activo;
                await CargarGrillaAsync();
            }
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvAlquileres.CurrentRow?.DataBoundItem is not Alquiler seleccionado)
            {
                MessageBox.Show("Seleccione un alquiler del listado para finalizarlo.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (seleccionado.Estado == EstadoAlquiler.Finalizado)
            {
                MessageBox.Show("El alquiler seleccionado ya se encuentra finalizado.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Desea finalizar el alquiler N° {seleccionado.Id} de {seleccionado.Inquilino}?",
                "Finalizar alquiler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                await _negocio.FinalizarAsync(seleccionado.Id);
                await CargarGrillaAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
