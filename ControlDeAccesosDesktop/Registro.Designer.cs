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
            btnEntrada.Location = new Point(103, 149);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(142, 29);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            // 
            // btnSalidas
            // 
            btnSalidas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalidas.Location = new Point(384, 149);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(144, 29);
            btnSalidas.TabIndex = 1;
            btnSalidas.Text = "Salida";
            btnSalidas.UseVisualStyleBackColor = true;
            // 
            // btnGuardia
            // 
            btnGuardia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardia.Location = new Point(103, 254);
            btnGuardia.Name = "btnGuardia";
            btnGuardia.Size = new Size(142, 29);
            btnGuardia.TabIndex = 2;
            btnGuardia.Text = "Guardia";
            btnGuardia.UseVisualStyleBackColor = true;
            // 
            // btnResidente
            // 
            btnResidente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResidente.Location = new Point(384, 254);
            btnResidente.Name = "btnResidente";
            btnResidente.Size = new Size(144, 29);
            btnResidente.TabIndex = 3;
            btnResidente.Text = "Residente";
            btnResidente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Cancelar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 374);
            Controls.Add(btnRegresar);
            Controls.Add(label1);
            Controls.Add(btnResidente);
            Controls.Add(btnGuardia);
            Controls.Add(btnSalidas);
            Controls.Add(btnEntrada);
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