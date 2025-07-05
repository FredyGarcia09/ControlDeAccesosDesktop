namespace ControlDeAccesosDesktop
{
    partial class BuscadorRI
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
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            txtDomicilio = new TextBox();
            txtNombre = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(269, 214);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(45, 128);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(242, 27);
            txtDomicilio.TabIndex = 1;
            txtDomicilio.Text = "Escribe el domicilio.";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 27);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Escribe el nombre.";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(133, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 381);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // BuscadorRI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "BuscadorRI";
            Text = "BuscadorRI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDomicilio;
        private TextBox txtNombre;
        private Button btnBuscar;
        private GroupBox groupBox2;
    }
}