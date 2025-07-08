namespace ControlDeAccesosDesktop
{
    partial class AgregarVehiculos
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
            btnRegresar = new Button();
            btnAgregar = new Button();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            cboResidentes = new ComboBox();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(404, 292);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(98, 26);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(104, 292);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 26);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(244, 241);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(246, 23);
            txtContrasena.TabIndex = 20;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(213, 185);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(278, 23);
            txtUsuario.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(212, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 23);
            txtNombre.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(110, 244);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 17;
            label4.Text = "Placas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(110, 188);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 16;
            label3.Text = "Modelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(109, 131);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 15;
            label2.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(213, 34);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 14;
            label1.Text = "Agrega un vehiculo";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(112, 73);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 23;
            label5.Text = "Residente:";
            // 
            // cboResidentes
            // 
            cboResidentes.FormattingEnabled = true;
            cboResidentes.Location = new Point(244, 75);
            cboResidentes.Name = "cboResidentes";
            cboResidentes.Size = new Size(247, 23);
            cboResidentes.TabIndex = 24;
            // 
            // AgregarVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f1a42fa5011bce2e3b8de8c8b0a50971;
            ClientSize = new Size(583, 344);
            Controls.Add(cboResidentes);
            Controls.Add(label5);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarVehiculos";
            Text = "AgregarVehiculos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnAgregar;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox cboResidentes;
    }
}