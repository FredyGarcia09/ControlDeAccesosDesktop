namespace ControlDeAccesosDesktop
{
    partial class PanelAcceso
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
            label1 = new Label();
            lblNombre = new Label();
            lblResidente = new Label();
            lblEstado = new Label();
            pbFoto = new PictureBox();
            btnEntrada = new Button();
            btnSalida = new Button();
            txtCodigoQR = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(152, 52);
            label1.Name = "label1";
            label1.Size = new Size(606, 37);
            label1.TabIndex = 6;
            label1.Text = "PANEL DE ACCESO A FRACCIONAMIENTO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Transparent;
            lblNombre.Location = new Point(86, 340);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(109, 26);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // lblResidente
            // 
            lblResidente.AutoSize = true;
            lblResidente.BackColor = Color.Transparent;
            lblResidente.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResidente.ForeColor = Color.Transparent;
            lblResidente.Location = new Point(86, 385);
            lblResidente.Name = "lblResidente";
            lblResidente.Size = new Size(72, 26);
            lblResidente.TabIndex = 8;
            lblResidente.Text = "Tipo:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Transparent;
            lblEstado.Location = new Point(96, 471);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 26);
            lblEstado.TabIndex = 9;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(607, 126);
            pbFoto.Margin = new Padding(3, 4, 3, 4);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(151, 151);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 10;
            pbFoto.TabStop = false;
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new Point(637, 400);
            btnEntrada.Margin = new Padding(3, 4, 3, 4);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(151, 31);
            btnEntrada.TabIndex = 11;
            btnEntrada.Text = "Registrar Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(637, 439);
            btnSalida.Margin = new Padding(3, 4, 3, 4);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(151, 31);
            btnSalida.TabIndex = 12;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(125, 172);
            txtCodigoQR.Margin = new Padding(3, 4, 3, 4);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(378, 27);
            txtCodigoQR.TabIndex = 14;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(219, 215);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(183, 35);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(86, 294);
            label2.Name = "label2";
            label2.Size = new Size(44, 26);
            label2.TabIndex = 16;
            label2.Text = "ID:";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(86, 439);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(183, 36);
            btnRegresar.TabIndex = 17;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // PanelAcceso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f1a42fa5011bce2e3b8de8c8b0a50971;
            ClientSize = new Size(914, 487);
            Controls.Add(btnRegresar);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigoQR);
            Controls.Add(btnSalida);
            Controls.Add(btnEntrada);
            Controls.Add(pbFoto);
            Controls.Add(lblEstado);
            Controls.Add(lblResidente);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelAcceso";
            Text = "PanelAcceso";
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label lblResidente;
        private Label lblEstado;
        private PictureBox pbFoto;
        private Button btnEntrada;
        private Button btnSalida;
        private TextBox txtCodigoQR;
        private Button btnBuscar;
        private Label label2;
        private Button btnRegresar;
    }
}