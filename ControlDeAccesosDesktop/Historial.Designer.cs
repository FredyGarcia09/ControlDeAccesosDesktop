namespace ControlDeAccesosDesktop
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            label1 = new Label();
            btnRegistro = new Button();
            button2 = new Button();
            btnHistorial = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(54, 45);
            label1.Name = "label1";
            label1.Size = new Size(521, 26);
            label1.TabIndex = 0;
            label1.Text = "Selecciona la operación que quieres hacer .";
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(205, 126);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(222, 35);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(205, 195);
            button2.Name = "button2";
            button2.Size = new Size(222, 34);
            button2.TabIndex = 2;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorial.Location = new Point(205, 259);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(222, 34);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(506, 298);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(630, 344);
            Controls.Add(btnSalir);
            Controls.Add(btnHistorial);
            Controls.Add(button2);
            Controls.Add(btnRegistro);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Historial";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistro;
        private Button button2;
        private Button button1;
        private Button btnHistorial;
        private Button btnSalir;
    }
}