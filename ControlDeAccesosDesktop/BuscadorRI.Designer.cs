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
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btnRegresa
            // 
            btnRegresa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresa.Location = new Point(45, 213);
            btnRegresa.Name = "btnRegresa";
            btnRegresa.Size = new Size(94, 29);
            btnRegresa.TabIndex = 3;
            btnRegresa.Text = "Regresar";
            btnRegresa.UseVisualStyleBackColor = true;
            btnRegresa.Click += btnRegresa_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(269, 213);
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
            txtDomicilio.Size = new Size(318, 27);
            txtDomicilio.TabIndex = 1;
            txtDomicilio.Text = "Escribe el domicilio.";
            txtDomicilio.Click += txtDomicilio_Click;
            txtDomicilio.TextChanged += txtDomicilio_TextChanged;
            txtDomicilio.Leave += txtDomicilio_Leave;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(322, 27);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Escribe el nombre.";
            txtNombre.Click += txtNombre_Click;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Leave += txtNombre_Leave;
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
            gbReIn.Location = new Point(146, 3);
            gbReIn.Name = "gbReIn";
            gbReIn.Size = new Size(550, 433);
            gbReIn.TabIndex = 1;
            gbReIn.TabStop = false;
            gbReIn.Text = "Datos";
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(35, 245);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.Size = new Size(501, 113);
            dgvVehiculos.TabIndex = 16;
            // 
            // btnregresar
            // 
            btnregresar.ForeColor = SystemColors.ActiveCaptionText;
            btnregresar.Location = new Point(317, 381);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(94, 36);
            btnregresar.TabIndex = 15;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = true;
            btnregresar.Click += btnregresar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(113, 39);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(59, 23);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "label1";
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(392, 29);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(143, 149);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 3;
            pbFoto.TabStop = false;
            // 
            // btnActualizar
            // 
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.Location = new Point(441, 381);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 36);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(35, 381);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 36);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 39);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 100);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(135, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "label1";
            // 
            // BuscadorRI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 451);
            Controls.Add(gbReIn);
            Controls.Add(groupBox1);
            Name = "BuscadorRI";
            Text = "BuscadorRI";
            FormClosing += BuscadorRI_FormClosing;
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