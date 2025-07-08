namespace ControlDeAccesosDesktop
{
    partial class RegistroGuardias
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
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnAgregar = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(186, 69);
            label1.Name = "label1";
            label1.Size = new Size(267, 26);
            label1.TabIndex = 1;
            label1.Text = "Registra a un guardia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(69, 135);
            label2.Name = "label2";
            label2.Size = new Size(109, 26);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(69, 224);
            label3.Name = "label3";
            label3.Size = new Size(113, 26);
            label3.TabIndex = 3;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(69, 299);
            label4.Name = "label4";
            label4.Size = new Size(155, 26);
            label4.TabIndex = 4;
            label4.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 131);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(186, 220);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(317, 27);
            txtUsuario.TabIndex = 6;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(222, 295);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(281, 27);
            txtContrasena.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(48, 368);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 35);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(391, 368);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(112, 35);
            btnRegresar.TabIndex = 13;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // RegistroGuardias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f1a42fa5011bce2e3b8de8c8b0a50971;
            ClientSize = new Size(575, 439);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistroGuardias";
            Text = "RegistroGuardias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnAgregar;
        private Button btnRegresar;
    }
}