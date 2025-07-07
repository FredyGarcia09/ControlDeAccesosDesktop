namespace ControlDeAccesosDesktop
{
    partial class RegistroGuardias
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
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvGuardias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGuardias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(163, 52);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 1;
            label1.Text = "Registra a un guardia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(60, 101);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(60, 168);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 3;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(60, 224);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 4;
            label4.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(163, 165);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(205, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(194, 221);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(205, 23);
            txtContrasena.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(42, 276);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 26);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(394, 276);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 26);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(284, 276);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 26);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(163, 276);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(98, 26);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvGuardias
            // 
            dgvGuardias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuardias.Location = new Point(31, 322);
            dgvGuardias.Name = "dgvGuardias";
            dgvGuardias.Size = new Size(419, 150);
            dgvGuardias.TabIndex = 16;
            dgvGuardias.CellClick += dgvGuardias_CellClick;
            // 
            // RegistroGuardias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f1a42fa5011bce2e3b8de8c8b0a50971;
            ClientSize = new Size(800, 520);
            Controls.Add(dgvGuardias);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroGuardias";
            Text = "RegistroGuardias";
            ((System.ComponentModel.ISupportInitialize)dgvGuardias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvGuardias;
    }
}