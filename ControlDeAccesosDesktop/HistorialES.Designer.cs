namespace ControlDeAccesosDesktop
{
    partial class HistorialES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialES));
            dgvHistorial = new DataGridView();
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            btnRegresar = new Button();
            cmbTipoPersona = new ComboBox();
            cmbTipoAcceso = new ComboBox();
            lblGuardiaActual = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(41, 82);
            dgvHistorial.Margin = new Padding(3, 2, 3, 2);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(602, 205);
            dgvHistorial.TabIndex = 0;
            dgvHistorial.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(41, 34);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(219, 23);
            dtpFecha.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(443, 300);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(561, 300);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(82, 27);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // cmbTipoPersona
            // 
            cmbTipoPersona.FormattingEnabled = true;
            cmbTipoPersona.Items.AddRange(new object[] { "Todos", "Invitados", "Residentes" });
            cmbTipoPersona.Location = new Point(293, 34);
            cmbTipoPersona.Margin = new Padding(3, 2, 3, 2);
            cmbTipoPersona.Name = "cmbTipoPersona";
            cmbTipoPersona.Size = new Size(133, 23);
            cmbTipoPersona.TabIndex = 4;
            cmbTipoPersona.Text = "Tipo de persona";
            // 
            // cmbTipoAcceso
            // 
            cmbTipoAcceso.FormattingEnabled = true;
            cmbTipoAcceso.Items.AddRange(new object[] { "Todos", "Entrada", "Salida" });
            cmbTipoAcceso.Location = new Point(461, 34);
            cmbTipoAcceso.Margin = new Padding(3, 2, 3, 2);
            cmbTipoAcceso.Name = "cmbTipoAcceso";
            cmbTipoAcceso.Size = new Size(133, 23);
            cmbTipoAcceso.TabIndex = 5;
            cmbTipoAcceso.Text = "Tipo de acceso";
            // 
            // lblGuardiaActual
            // 
            lblGuardiaActual.AutoSize = true;
            lblGuardiaActual.BackColor = Color.Transparent;
            lblGuardiaActual.ForeColor = SystemColors.ButtonHighlight;
            lblGuardiaActual.Location = new Point(41, 65);
            lblGuardiaActual.Name = "lblGuardiaActual";
            lblGuardiaActual.Size = new Size(0, 15);
            lblGuardiaActual.TabIndex = 6;
            // 
            // HistorialES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(711, 338);
            Controls.Add(lblGuardiaActual);
            Controls.Add(cmbTipoAcceso);
            Controls.Add(cmbTipoPersona);
            Controls.Add(btnRegresar);
            Controls.Add(btnBuscar);
            Controls.Add(dtpFecha);
            Controls.Add(dgvHistorial);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HistorialES";
            Text = "HistorialES";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorial;
        private DateTimePicker dtpFecha;
        private Button btnBuscar;
        private Button btnRegresar;
        private ComboBox cmbTipoPersona;
        private ComboBox cmbTipoAcceso;
        private Label lblGuardiaActual;
    }
}