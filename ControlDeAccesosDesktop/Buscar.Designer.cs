namespace ControlDeAccesosDesktop
{
    partial class Buscar
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
            btnresidentes = new Button();
            btnInvitados = new Button();
            btnRegresa = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnresidentes
            // 
            btnresidentes.Location = new Point(138, 150);
            btnresidentes.Name = "btnresidentes";
            btnresidentes.Size = new Size(94, 29);
            btnresidentes.TabIndex = 0;
            btnresidentes.Text = "Residentes";
            btnresidentes.UseVisualStyleBackColor = true;
            // 
            // btnInvitados
            // 
            btnInvitados.Location = new Point(371, 150);
            btnInvitados.Name = "btnInvitados";
            btnInvitados.Size = new Size(94, 29);
            btnInvitados.TabIndex = 1;
            btnInvitados.Text = "Invitados";
            btnInvitados.UseVisualStyleBackColor = true;
            // 
            // btnRegresa
            // 
            btnRegresa.Location = new Point(479, 229);
            btnRegresa.Name = "btnRegresa";
            btnRegresa.Size = new Size(94, 29);
            btnRegresa.TabIndex = 2;
            btnRegresa.Text = "Cancelar";
            btnRegresa.UseVisualStyleBackColor = true;
            btnRegresa.Click += btnRegresa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 42);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 3;
            label1.Text = "Buscar";
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 281);
            Controls.Add(label1);
            Controls.Add(btnRegresa);
            Controls.Add(btnInvitados);
            Controls.Add(btnresidentes);
            Name = "Buscar";
            Text = "Buscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnresidentes;
        private Button btnInvitados;
        private Button btnRegresa;
        private Label label1;
    }
}