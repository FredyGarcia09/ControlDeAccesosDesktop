namespace ControlDeAccesosDesktop
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            btnEntrada = new Button();
            btnSalidas = new Button();
            btnGuardia = new Button();
            btnResidente = new Button();
            label1 = new Label();
            btnRegresar = new Button();
            btnVehiculos = new Button();
            SuspendLayout();
            // 
            // btnEntrada
            // 
            btnEntrada.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrada.Location = new Point(103, 149);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(142, 37);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSalidas
            // 
            btnSalidas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalidas.Location = new Point(384, 149);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(144, 37);
            btnSalidas.TabIndex = 1;
            btnSalidas.Text = "Salida";
            btnSalidas.UseVisualStyleBackColor = true;
            btnSalidas.Click += btnSalidas_Click;
            // 
            // btnGuardia
            // 
            btnGuardia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardia.Location = new Point(103, 224);
            btnGuardia.Name = "btnGuardia";
            btnGuardia.Size = new Size(142, 37);
            btnGuardia.TabIndex = 2;
            btnGuardia.Text = "Guardia";
            btnGuardia.UseVisualStyleBackColor = true;
            btnGuardia.Click += btnGuardia_Click;
            // 
            // btnResidente
            // 
            btnResidente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResidente.Location = new Point(384, 224);
            btnResidente.Name = "btnResidente";
            btnResidente.Size = new Size(144, 37);
            btnResidente.TabIndex = 3;
            btnResidente.Text = "Residente";
            btnResidente.UseVisualStyleBackColor = true;
            btnResidente.Click += btnResidente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(229, 69);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 4;
            label1.Text = "Registro.";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(557, 323);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 40);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Cancelar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehiculos.Location = new Point(248, 296);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(144, 37);
            btnVehiculos.TabIndex = 6;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(682, 393);
            Controls.Add(btnVehiculos);
            Controls.Add(btnRegresar);
            Controls.Add(label1);
            Controls.Add(btnResidente);
            Controls.Add(btnGuardia);
            Controls.Add(btnSalidas);
            Controls.Add(btnEntrada);
            Name = "Registro";
            Text = "Registro";
            FormClosing += Registro_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrada;
        private Button btnSalidas;
        private Button btnGuardia;
        private Button btnResidente;
        private Label label1;
        private Button btnRegresar;
        private Button btnVehiculos;
    }
}