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
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            cmbResidentes = new ComboBox();
            txtPlacas = new TextBox();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(462, 389);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(112, 35);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(119, 389);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 35);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(243, 247);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(317, 27);
            txtModelo.TabIndex = 19;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(242, 171);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(317, 27);
            txtMarca.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(126, 325);
            label4.Name = "label4";
            label4.Size = new Size(96, 26);
            label4.TabIndex = 17;
            label4.Text = "Placas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(126, 251);
            label3.Name = "label3";
            label3.Size = new Size(110, 26);
            label3.TabIndex = 16;
            label3.Text = "Modelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(125, 175);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 15;
            label2.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(243, 45);
            label1.Name = "label1";
            label1.Size = new Size(241, 26);
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
            label5.Location = new Point(128, 97);
            label5.Name = "label5";
            label5.Size = new Size(134, 26);
            label5.TabIndex = 23;
            label5.Text = "Residente:";
            // 
            // cmbResidentes
            // 
            cmbResidentes.FormattingEnabled = true;
            cmbResidentes.Location = new Point(279, 100);
            cmbResidentes.Margin = new Padding(3, 4, 3, 4);
            cmbResidentes.Name = "cmbResidentes";
            cmbResidentes.Size = new Size(282, 28);
            cmbResidentes.TabIndex = 24;
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(243, 328);
            txtPlacas.Margin = new Padding(3, 4, 3, 4);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(317, 27);
            txtPlacas.TabIndex = 25;
            // 
            // AgregarVehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f1a42fa5011bce2e3b8de8c8b0a50971;
            ClientSize = new Size(666, 459);
            Controls.Add(txtPlacas);
            Controls.Add(cmbResidentes);
            Controls.Add(label5);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarVehiculos";
            Text = "AgregarVehiculos";
            FormClosing += AgregarVehiculos_FormClosing;
            Load += AgregarVehiculos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnAgregar;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox cmbResidentes;
        private TextBox txtPlacas;
    }
}