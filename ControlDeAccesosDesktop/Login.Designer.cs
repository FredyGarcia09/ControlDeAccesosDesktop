namespace ControlDeAccesosDesktop
{
    partial class LoginGuardia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGuardia));
            groupBox1 = new GroupBox();
            btnEntrar = new Button();
            label1 = new Label();
            txtContraseña = new TextBox();
            txtUser = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Location = new Point(102, 26);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(470, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.LightCyan;
            btnEntrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(330, 256);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(105, 26);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(127, 62);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 0;
            label1.Text = "User Login";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.InactiveCaption;
            txtContraseña.Location = new Point(105, 167);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(267, 23);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.InactiveCaption;
            txtUser.ForeColor = SystemColors.InactiveCaptionText;
            txtUser.Location = new Point(105, 109);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(267, 23);
            txtUser.TabIndex = 1;
            txtUser.Text = "User Name";
            // 
            // LoginGuardia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginGuardia";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtContraseña;
        private TextBox txtUser;
        private Label label1;
        private Button btnEntrar;
    }
}
