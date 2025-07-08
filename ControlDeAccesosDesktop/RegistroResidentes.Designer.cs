namespace ControlDeAccesosDesktop
{
    partial class RegistroResidentes
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblContrasena = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtContrasena = new TextBox();
            txtApellidos = new TextBox();
            txtDomicilio = new TextBox();
            txtTelefono = new MaskedTextBox();
            pbFoto = new PictureBox();
            btnCargarFoto = new Button();
            btnAgregar = new Button();
            btnRegresar = new Button();
            btnGuardarCambios = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(188, 20);
            label1.Name = "label1";
            label1.Size = new Size(333, 30);
            label1.TabIndex = 5;
            label1.Text = "Registra a un residente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(60, 91);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(385, 91);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 7;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(60, 156);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 8;
            label4.Text = "Domicilio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(385, 147);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefono:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.Transparent;
            lblContrasena.Location = new Point(60, 219);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(128, 20);
            lblContrasena.TabIndex = 10;
            lblContrasena.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(385, 205);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 11;
            label7.Text = "Foto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(201, 219);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(174, 23);
            txtContrasena.TabIndex = 13;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(500, 88);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(174, 23);
            txtApellidos.TabIndex = 14;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(177, 156);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(198, 23);
            txtDomicilio.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(494, 147);
            txtTelefono.Mask = "000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 23);
            txtTelefono.TabIndex = 16;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(466, 205);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(129, 105);
            pbFoto.TabIndex = 17;
            pbFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarFoto.Location = new Point(601, 219);
            btnCargarFoto.Margin = new Padding(3, 2, 3, 2);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(129, 26);
            btnCargarFoto.TabIndex = 18;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(64, 341);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 26);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(618, 341);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(92, 26);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.Location = new Point(64, 310);
            btnGuardarCambios.Margin = new Padding(3, 2, 3, 2);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(158, 26);
            btnGuardarCambios.TabIndex = 24;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // RegistroResidentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f1a42fa5011bce2e3b8de8c8b0a50971;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCargarFoto);
            Controls.Add(pbFoto);
            Controls.Add(txtTelefono);
            Controls.Add(txtDomicilio);
            Controls.Add(txtApellidos);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(lblContrasena);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroResidentes";
            Text = "RegistroResidentes";
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblContrasena;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtContrasena;
        private TextBox txtApellidos;
        private TextBox txtDomicilio;
        private MaskedTextBox txtTelefono;
        private PictureBox pbFoto;
        private Button btnCargarFoto;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnRegresar;
        private Button btnGuardarCambios;
    }
}