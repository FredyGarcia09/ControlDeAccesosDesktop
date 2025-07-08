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
            SuspendLayout();
            // 
            // btnEntrada
            // 
            btnEntrada.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrada.Location = new Point(90, 112);
            btnEntrada.Margin = new Padding(3, 2, 3, 2);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(124, 22);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSalidas
            // 
            btnSalidas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalidas.Location = new Point(336, 112);
            btnSalidas.Margin = new Padding(3, 2, 3, 2);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(126, 22);
            btnSalidas.TabIndex = 1;
            btnSalidas.Text = "Salida";
            btnSalidas.UseVisualStyleBackColor = true;
            btnSalidas.Click += btnSalidas_Click;
            // 
            // btnGuardia
            // 
            btnGuardia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardia.Location = new Point(90, 190);
            btnGuardia.Margin = new Padding(3, 2, 3, 2);
            btnGuardia.Name = "btnGuardia";
            btnGuardia.Size = new Size(124, 22);
            btnGuardia.TabIndex = 2;
            btnGuardia.Text = "Guardia";
            btnGuardia.UseVisualStyleBackColor = true;
            btnGuardia.Click += btnGuardia_Click;
            // 
            // btnResidente
            // 
            btnResidente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResidente.Location = new Point(336, 190);
            btnResidente.Margin = new Padding(3, 2, 3, 2);
            btnResidente.Name = "btnResidente";
            btnResidente.Size = new Size(126, 22);
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
            label1.Location = new Point(200, 52);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 4;
            label1.Text = "Registro.";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(487, 242);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(82, 22);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Cancelar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(597, 280);
            Controls.Add(btnRegresar);
            Controls.Add(label1);
            Controls.Add(btnResidente);
            Controls.Add(btnGuardia);
            Controls.Add(btnSalidas);
            Controls.Add(btnEntrada);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Registro";
            Text = "Registro";
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
    }
}