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
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            mtxtTelefono = new MaskedTextBox();
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(69, 292);
            label6.Name = "label6";
            label6.Size = new Size(155, 26);
            label6.TabIndex = 10;
            label6.Text = "Contraseña:";
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
            // textBox1
            // 
            textBox1.Location = new Point(178, 117);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 292);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(571, 117);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(202, 208);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 27);
            textBox4.TabIndex = 15;
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.Location = new Point(565, 196);
            mtxtTelefono.Margin = new Padding(3, 4, 3, 4);
            mtxtTelefono.Mask = "000-000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(188, 27);
            mtxtTelefono.TabIndex = 16;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(533, 273);
            pbFoto.Margin = new Padding(3, 4, 3, 4);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(147, 99);
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
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.Location = new Point(73, 414);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(181, 35);
            btnGuardarCambios.TabIndex = 24;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
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
            Controls.Add(mtxtTelefono);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private MaskedTextBox mtxtTelefono;
        private PictureBox pbFoto;
        private Button btnCargarFoto;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnRegresar;
        private Button btnGuardarCambios;
    }
}