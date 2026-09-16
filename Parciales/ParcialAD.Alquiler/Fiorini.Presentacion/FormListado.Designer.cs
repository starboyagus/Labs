namespace Fiorini.Presentacion
{
    partial class FormListado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnBuscar = new Button();
            dgvAlquileres = new DataGridView();
            btnAgregar = new Button();
            btnFinalizar = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(37, 64, 97);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(238, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Alquileres";
            //
            // lblEstado
            //
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(22, 68);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Estado:";
            //
            // cboEstado
            //
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(73, 65);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(160, 23);
            cboEstado.TabIndex = 2;
            //
            // btnBuscar
            //
            btnBuscar.Location = new Point(245, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 25);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            //
            // dgvAlquileres
            //
            dgvAlquileres.AllowUserToAddRows = false;
            dgvAlquileres.AllowUserToDeleteRows = false;
            dgvAlquileres.AllowUserToResizeRows = false;
            dgvAlquileres.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlquileres.BackgroundColor = SystemColors.Window;
            dgvAlquileres.BorderStyle = BorderStyle.Fixed3D;
            dgvAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileres.Location = new Point(22, 103);
            dgvAlquileres.MultiSelect = false;
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.ReadOnly = true;
            dgvAlquileres.RowHeadersVisible = false;
            dgvAlquileres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlquileres.Size = new Size(740, 320);
            dgvAlquileres.TabIndex = 4;
            //
            // btnAgregar
            //
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(552, 438);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            //
            // btnFinalizar
            //
            btnFinalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFinalizar.Location = new Point(662, 438);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(100, 30);
            btnFinalizar.TabIndex = 6;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            //
            // lblTotal
            //
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = SystemColors.GrayText;
            lblTotal.Location = new Point(22, 446);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 7;
            //
            // FormListado
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 481);
            Controls.Add(lblTotal);
            Controls.Add(btnFinalizar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvAlquileres);
            Controls.Add(btnBuscar);
            Controls.Add(cboEstado);
            Controls.Add(lblEstado);
            Controls.Add(lblTitulo);
            MinimumSize = new Size(700, 400);
            Name = "FormListado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alquileres - Listado";
            Load += FormListado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblEstado;
        private ComboBox cboEstado;
        private Button btnBuscar;
        private DataGridView dgvAlquileres;
        private Button btnAgregar;
        private Button btnFinalizar;
        private Label lblTotal;
    }
}
