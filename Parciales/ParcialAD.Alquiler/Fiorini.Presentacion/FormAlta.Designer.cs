namespace Fiorini.Presentacion
{
    partial class FormAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblInquilino = new Label();
            txtInquilino = new TextBox();
            lblMontoAlquiler = new Label();
            nudMontoAlquiler = new NumericUpDown();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            lblAyuda = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMontoAlquiler).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(37, 64, 97);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Alquiler";
            //
            // lblInquilino
            //
            lblInquilino.AutoSize = true;
            lblInquilino.Location = new Point(22, 65);
            lblInquilino.Name = "lblInquilino";
            lblInquilino.Size = new Size(58, 15);
            lblInquilino.TabIndex = 1;
            lblInquilino.Text = "Inquilino:";
            //
            // txtInquilino
            //
            txtInquilino.Location = new Point(130, 62);
            txtInquilino.MaxLength = 100;
            txtInquilino.Name = "txtInquilino";
            txtInquilino.Size = new Size(260, 23);
            txtInquilino.TabIndex = 2;
            //
            // lblMontoAlquiler
            //
            lblMontoAlquiler.AutoSize = true;
            lblMontoAlquiler.Location = new Point(22, 103);
            lblMontoAlquiler.Name = "lblMontoAlquiler";
            lblMontoAlquiler.Size = new Size(93, 15);
            lblMontoAlquiler.TabIndex = 3;
            lblMontoAlquiler.Text = "Monto alquiler:";
            //
            // nudMontoAlquiler
            //
            nudMontoAlquiler.DecimalPlaces = 2;
            nudMontoAlquiler.Location = new Point(130, 100);
            nudMontoAlquiler.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMontoAlquiler.Name = "nudMontoAlquiler";
            nudMontoAlquiler.Size = new Size(160, 23);
            nudMontoAlquiler.TabIndex = 4;
            nudMontoAlquiler.TextAlign = HorizontalAlignment.Right;
            nudMontoAlquiler.ThousandsSeparator = true;
            //
            // lblFechaInicio
            //
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(22, 141);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(73, 15);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "Fecha inicio:";
            //
            // dtpFechaInicio
            //
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(130, 138);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(160, 23);
            dtpFechaInicio.TabIndex = 6;
            //
            // lblFechaFin
            //
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(22, 179);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(60, 15);
            lblFechaFin.TabIndex = 7;
            lblFechaFin.Text = "Fecha fin:";
            //
            // dtpFechaFin
            //
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(130, 176);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(160, 23);
            dtpFechaFin.TabIndex = 8;
            //
            // lblAyuda
            //
            lblAyuda.AutoSize = true;
            lblAyuda.ForeColor = SystemColors.GrayText;
            lblAyuda.Location = new Point(22, 217);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(302, 15);
            lblAyuda.TabIndex = 9;
            lblAyuda.Text = "El alquiler se creará automáticamente con estado \"Activo\".";
            //
            // btnAceptar
            //
            btnAceptar.Location = new Point(180, 255);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 30);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            //
            // btnCancelar
            //
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(290, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // FormAlta
            //
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(414, 306);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblAyuda);
            Controls.Add(dtpFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(nudMontoAlquiler);
            Controls.Add(lblMontoAlquiler);
            Controls.Add(txtInquilino);
            Controls.Add(lblInquilino);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAlta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alquileres - Alta";
            Load += FormAlta_Load;
            ((System.ComponentModel.ISupportInitialize)nudMontoAlquiler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblInquilino;
        private TextBox txtInquilino;
        private Label lblMontoAlquiler;
        private NumericUpDown nudMontoAlquiler;
        private Label lblFechaInicio;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaFin;
        private Label lblAyuda;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
