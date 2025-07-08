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
            label1.Location = new Point(215, 27);
            label1.Name = "label1";
            label1.Size = new Size(422, 37);
            label1.TabIndex = 5;
            label1.Text = "Registra a un residente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(69, 121);
            label2.Name = "label2";
            label2.Size = new Size(109, 26);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(440, 121);
            label3.Name = "label3";
            label3.Size = new Size(134, 26);
            label3.TabIndex = 7;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(69, 208);
            label4.Name = "label4";
            label4.Size = new Size(135, 26);
            label4.TabIndex = 8;
            label4.Text = "Domicilio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(440, 196);
            label5.Name = "label5";
            label5.Size = new Size(128, 26);
            label5.TabIndex = 9;
            label5.Text = "Telefono:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.Transparent;
            lblContrasena.Location = new Point(69, 292);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(155, 26);
            lblContrasena.TabIndex = 10;
            lblContrasena.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(440, 273);
            label7.Name = "label7";
            label7.Size = new Size(78, 26);
            label7.TabIndex = 11;
            label7.Text = "Foto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 117);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 12;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(230, 292);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(198, 27);
            txtContrasena.TabIndex = 13;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(571, 117);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(198, 27);
            txtApellidos.TabIndex = 14;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(202, 208);
            txtDomicilio.Margin = new Padding(3, 4, 3, 4);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(226, 27);
            txtDomicilio.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(565, 196);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Mask = "000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(205, 27);
            txtTelefono.TabIndex = 16;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(533, 273);
            pbFoto.Margin = new Padding(3, 4, 3, 4);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(147, 140);
            pbFoto.TabIndex = 17;
            pbFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarFoto.Location = new Point(687, 292);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(147, 35);
            btnCargarFoto.TabIndex = 18;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(73, 455);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 35);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(706, 455);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(105, 35);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.Location = new Point(73, 413);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(181, 35);
            btnGuardarCambios.TabIndex = 24;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // RegistroResidentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f1a42fa5011bce2e3b8de8c8b0a50971;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistroResidentes";
            Text = "RegistroResidentes";
            FormClosing += RegistroResidentes_FormClosing;
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