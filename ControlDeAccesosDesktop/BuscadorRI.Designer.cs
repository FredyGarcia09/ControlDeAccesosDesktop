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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscadorRI));
            groupBox1 = new GroupBox();
            btnRegresa = new Button();
            btnBuscar = new Button();
            txtDomicilio = new TextBox();
            txtNombre = new TextBox();
            gbReIn = new GroupBox();
            dgvVehiculos = new DataGridView();
            btnregresar = new Button();
            lblTipo = new Label();
            pbFoto = new PictureBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label4 = new Label();
            label2 = new Label();
            lblNombre = new Label();
            groupBox1.SuspendLayout();
            gbReIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnRegresa);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(361, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btnRegresa
            // 
            btnRegresa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresa.Location = new Point(39, 160);
            btnRegresa.Margin = new Padding(3, 2, 3, 2);
            btnRegresa.Name = "btnRegresa";
            btnRegresa.Size = new Size(82, 22);
            btnRegresa.TabIndex = 3;
            btnRegresa.Text = "Regresar";
            btnRegresa.UseVisualStyleBackColor = true;
            btnRegresa.Click += btnRegresa_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(235, 160);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(39, 96);
            txtDomicilio.Margin = new Padding(3, 2, 3, 2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(279, 23);
            txtDomicilio.TabIndex = 1;
            txtDomicilio.Text = "Escribe el domicilio.";
            txtDomicilio.TextChanged += txtDomicilio_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 46);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 23);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Escribe el nombre.";
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // gbReIn
            // 
            gbReIn.BackColor = Color.Transparent;
            gbReIn.Controls.Add(dgvVehiculos);
            gbReIn.Controls.Add(btnregresar);
            gbReIn.Controls.Add(lblTipo);
            gbReIn.Controls.Add(pbFoto);
            gbReIn.Controls.Add(btnActualizar);
            gbReIn.Controls.Add(btnEliminar);
            gbReIn.Controls.Add(label4);
            gbReIn.Controls.Add(label2);
            gbReIn.Controls.Add(lblNombre);
            gbReIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbReIn.ForeColor = SystemColors.ButtonFace;
            gbReIn.Location = new Point(128, 2);
            gbReIn.Margin = new Padding(3, 2, 3, 2);
            gbReIn.Name = "gbReIn";
            gbReIn.Padding = new Padding(3, 2, 3, 2);
            gbReIn.Size = new Size(481, 325);
            gbReIn.TabIndex = 1;
            gbReIn.TabStop = false;
            gbReIn.Text = "Datos";
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(31, 184);
            dgvVehiculos.Margin = new Padding(3, 2, 3, 2);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.Size = new Size(438, 85);
            dgvVehiculos.TabIndex = 16;
            // 
            // btnregresar
            // 
            btnregresar.ForeColor = SystemColors.ActiveCaptionText;
            btnregresar.Location = new Point(277, 286);
            btnregresar.Margin = new Padding(3, 2, 3, 2);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(82, 27);
            btnregresar.TabIndex = 15;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = true;
            btnregresar.Click += btnregresar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(99, 29);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(50, 19);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "label1";
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(343, 22);
            pbFoto.Margin = new Padding(3, 2, 3, 2);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(125, 112);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 3;
            pbFoto.TabStop = false;
            // 
            // btnActualizar
            // 
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.Location = new Point(386, 286);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 27);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(31, 286);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 27);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 29);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 75);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(118, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "label1";
            // 
            // BuscadorRI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(gbReIn);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BuscadorRI";
            Text = "BuscadorRI";
            Load += BuscadorRI_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbReIn.ResumeLayout(false);
            gbReIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDomicilio;
        private TextBox txtNombre;
        private Button btnBuscar;
        private GroupBox gbReIn;
        private Label label2;
        private Label lblNombre;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label4;
        private PictureBox pbFoto;
        private Label lblTipo;
        private Button button1;
        private Button btnregresar;
        private Button btnRegresa;
        private DataGridView dgvVehiculos;
    }
}