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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblNombre = new Label();
            lblResidente = new Label();
            lblEstado = new Label();
            pbFoto = new PictureBox();
            btnEntrada = new Button();
            btnSalida = new Button();
            pbCamara = new PictureBox();
            txtCodigoQR = new TextBox();
            btnIniciarCamara = new Button();
            timerQR = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCamara).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(133, 39);
            label1.Name = "label1";
            label1.Size = new Size(485, 30);
            label1.TabIndex = 6;
            label1.Text = "PANEL DE ACCESO A FRACCIONAMIENTO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Transparent;
            lblNombre.Location = new Point(75, 239);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(90, 20);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // lblResidente
            // 
            lblResidente.AutoSize = true;
            lblResidente.BackColor = Color.Transparent;
            lblResidente.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResidente.ForeColor = Color.Transparent;
            lblResidente.Location = new Point(75, 299);
            lblResidente.Name = "lblResidente";
            lblResidente.Size = new Size(110, 20);
            lblResidente.TabIndex = 8;
            lblResidente.Text = "Residente:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Transparent;
            lblEstado.Location = new Point(84, 353);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 20);
            lblEstado.TabIndex = 9;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(346, 230);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(132, 64);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 10;
            pbFoto.TabStop = false;
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new Point(346, 332);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(132, 23);
            btnEntrada.TabIndex = 11;
            btnEntrada.Text = "Registrar Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(346, 381);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(132, 23);
            btnSalida.TabIndex = 12;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            // 
            // pbCamara
            // 
            pbCamara.Location = new Point(428, 85);
            pbCamara.Name = "pbCamara";
            pbCamara.Size = new Size(190, 125);
            pbCamara.TabIndex = 13;
            pbCamara.TabStop = false;
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(192, 119);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(160, 23);
            txtCodigoQR.TabIndex = 14;
            // 
            // btnIniciarCamara
            // 
            btnIniciarCamara.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarCamara.Location = new Point(192, 161);
            btnIniciarCamara.Margin = new Padding(3, 2, 3, 2);
            btnIniciarCamara.Name = "btnIniciarCamara";
            btnIniciarCamara.Size = new Size(160, 26);
            btnIniciarCamara.TabIndex = 15;
            btnIniciarCamara.Text = "Iniciar Camara";
            btnIniciarCamara.UseVisualStyleBackColor = true;
            // 
            // PanelAcceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f1a42fa5011bce2e3b8de8c8b0a50971;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciarCamara);
            Controls.Add(txtCodigoQR);
            Controls.Add(pbCamara);
            Controls.Add(btnSalida);
            Controls.Add(btnEntrada);
            Controls.Add(pbFoto);
            Controls.Add(lblEstado);
            Controls.Add(lblResidente);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "PanelAcceso";
            Text = "PanelAcceso";
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCamara).EndInit();
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
        private PictureBox pbCamara;
        private TextBox txtCodigoQR;
        private Button btnIniciarCamara;
        private System.Windows.Forms.Timer timerQR;
    }
}