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
            groupBox1.Location = new Point(117, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(537, 403);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.LightCyan;
            btnEntrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(377, 341);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(120, 35);
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
            label1.Location = new Point(145, 83);
            label1.Name = "label1";
            label1.Size = new Size(236, 46);
            label1.TabIndex = 0;
            label1.Text = "User Login";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.InactiveCaption;
            txtContraseña.Location = new Point(120, 223);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(305, 27);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "Password";
            txtContraseña.Click += txtContraseña_Click;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.InactiveCaption;
            txtUser.ForeColor = SystemColors.InactiveCaptionText;
            txtUser.Location = new Point(120, 145);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(305, 27);
            txtUser.TabIndex = 1;
            txtUser.Text = "User Name";
            txtUser.Click += txtUser_Click;
            txtUser.Leave += txtUser_Leave;
            // 
            // LoginGuardia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 451);
            Controls.Add(groupBox1);
            Name = "LoginGuardia";
            Text = "Form1";
            FormClosing += LoginGuardia_FormClosing;
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
