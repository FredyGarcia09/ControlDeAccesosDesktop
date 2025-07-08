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
            lblID = new Label();
            btnRegresar = new Button();
            pictureBoxVideo = new PictureBox();
            btnIniciarCamara = new Button();
            lblMensaje = new Label();
            label2 = new Label();
            txtNotas = new TextBox();
            label3 = new Label();
            txtPlacas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).BeginInit();
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
            lblNombre.Location = new Point(270, 267);
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
            lblResidente.Location = new Point(270, 304);
            lblResidente.Name = "lblResidente";
            lblResidente.Size = new Size(58, 20);
            lblResidente.TabIndex = 8;
            lblResidente.Text = "Tipo:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Transparent;
            lblEstado.Location = new Point(83, 447);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 20);
            lblEstado.TabIndex = 9;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(57, 220);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(132, 113);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 10;
            pbFoto.TabStop = false;
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new Point(33, 467);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(132, 23);
            btnEntrada.TabIndex = 11;
            btnEntrada.Text = "Registrar Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(34, 467);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(132, 23);
            btnSalida.TabIndex = 12;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(34, 97);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(196, 23);
            txtCodigoQR.TabIndex = 14;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.Transparent;
            lblID.Location = new Point(270, 233);
            lblID.Name = "lblID";
            lblID.Size = new Size(35, 20);
            lblID.TabIndex = 16;
            lblID.Text = "ID:";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(689, 467);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(160, 27);
            btnRegresar.TabIndex = 17;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBoxVideo
            // 
            pictureBoxVideo.Location = new Point(286, 83);
            pictureBoxVideo.Name = "pictureBoxVideo";
            pictureBoxVideo.Size = new Size(220, 124);
            pictureBoxVideo.TabIndex = 18;
            pictureBoxVideo.TabStop = false;
            // 
            // btnIniciarCamara
            // 
            btnIniciarCamara.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarCamara.Location = new Point(556, 93);
            btnIniciarCamara.Margin = new Padding(3, 2, 3, 2);
            btnIniciarCamara.Name = "btnIniciarCamara";
            btnIniciarCamara.Size = new Size(120, 26);
            btnIniciarCamara.TabIndex = 19;
            btnIniciarCamara.Text = "Iniciar Camara";
            btnIniciarCamara.UseVisualStyleBackColor = true;
            btnIniciarCamara.Click += btnIniciarCamara_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.Transparent;
            lblMensaje.Location = new Point(556, 163);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(34, 361);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 21;
            label2.Text = "Notas:";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(133, 363);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(373, 23);
            txtNotas.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(34, 413);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 23;
            label3.Text = "Placas:";
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(133, 413);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(276, 23);
            txtPlacas.TabIndex = 24;
            // 
            // PanelAcceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f1a42fa5011bce2e3b8de8c8b0a50971;
            ClientSize = new Size(904, 505);
            Controls.Add(txtPlacas);
            Controls.Add(label3);
            Controls.Add(txtNotas);
            Controls.Add(label2);
            Controls.Add(lblMensaje);
            Controls.Add(btnIniciarCamara);
            Controls.Add(pictureBoxVideo);
            Controls.Add(btnRegresar);
            Controls.Add(lblID);
            Controls.Add(txtCodigoQR);
            Controls.Add(btnSalida);
            Controls.Add(btnEntrada);
            Controls.Add(pbFoto);
            Controls.Add(lblEstado);
            Controls.Add(lblResidente);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "PanelAcceso";
            Text = "PanelAcceso";
            FormClosing += PanelAcceso_FormClosing_1;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).EndInit();
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
        private Label lblID;
        private Button btnRegresar;
        private PictureBox pictureBoxVideo;
        private Button btnIniciarCamara;
        private Label lblMensaje;
        private Label label2;
        private TextBox txtNotas;
        private Label label3;
        private TextBox txtPlacas;
    }
}