﻿namespace ControlDeAccesosDesktop
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
            btnBuscar = new Button();
            txtDomicilio = new TextBox();
            txtNombre = new TextBox();
            gbReIn = new GroupBox();
            btnregresar = new Button();
            lbllaca = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            lblTipo = new Label();
            pbFoto = new PictureBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label4 = new Label();
            lblApellidos = new Label();
            label3 = new Label();
            label2 = new Label();
            lblNombbre = new Label();
            groupBox1.SuspendLayout();
            gbReIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            txtDomicilio.Size = new Size(318, 27);
            txtDomicilio.TabIndex = 1;
            txtDomicilio.Text = "Escribe el domicilio.";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(322, 27);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Escribe el nombre.";
            // 
            // gbReIn
            // 
            gbReIn.BackColor = Color.Transparent;
            gbReIn.Controls.Add(btnregresar);
            gbReIn.Controls.Add(lbllaca);
            gbReIn.Controls.Add(lblModelo);
            gbReIn.Controls.Add(lblMarca);
            gbReIn.Controls.Add(label7);
            gbReIn.Controls.Add(label6);
            gbReIn.Controls.Add(label5);
            gbReIn.Controls.Add(label1);
            gbReIn.Controls.Add(lblTipo);
            gbReIn.Controls.Add(pbFoto);
            gbReIn.Controls.Add(btnActualizar);
            gbReIn.Controls.Add(btnEliminar);
            gbReIn.Controls.Add(label4);
            gbReIn.Controls.Add(lblApellidos);
            gbReIn.Controls.Add(label3);
            gbReIn.Controls.Add(label2);
            gbReIn.Controls.Add(lblNombbre);
            gbReIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbReIn.ForeColor = SystemColors.ButtonFace;
            gbReIn.Location = new Point(123, 12);
            gbReIn.Name = "gbReIn";
            gbReIn.Size = new Size(550, 426);
            gbReIn.TabIndex = 1;
            gbReIn.TabStop = false;
            gbReIn.Text = "Datos";
            // 
            // btnregresar
            // 
            btnregresar.ForeColor = SystemColors.ActiveCaptionText;
            btnregresar.Location = new Point(317, 381);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(94, 29);
            btnregresar.TabIndex = 15;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = true;
            btnregresar.Click += btnregresar_Click;
            // 
            // lbllaca
            // 
            lbllaca.AutoSize = true;
            lbllaca.Location = new Point(145, 283);
            lbllaca.Name = "lbllaca";
            lbllaca.Size = new Size(56, 23);
            lbllaca.TabIndex = 12;
            lbllaca.Text = "Placa:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(145, 263);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(76, 23);
            lblModelo.TabIndex = 11;
            lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(145, 243);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(64, 23);
            lblMarca.TabIndex = 10;
            lblMarca.Text = "Marca:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 283);
            label7.Name = "label7";
            label7.Size = new Size(56, 23);
            label7.TabIndex = 9;
            label7.Text = "Placa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 263);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 8;
            label6.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 243);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 7;
            label5.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 223);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 6;
            label1.Text = "Vehiculo(s):";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(118, 156);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(59, 23);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "label1";
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(168, 26);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(204, 112);
            pbFoto.TabIndex = 3;
            pbFoto.TabStop = false;
            // 
            // btnActualizar
            // 
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.Location = new Point(441, 381);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(35, 381);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 156);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(339, 187);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(59, 23);
            lblApellidos.TabIndex = 4;
            lblApellidos.Text = "label5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 187);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 2;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 187);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // lblNombbre
            // 
            lblNombbre.AutoSize = true;
            lblNombbre.Location = new Point(118, 187);
            lblNombbre.Name = "lblNombbre";
            lblNombbre.Size = new Size(59, 23);
            lblNombbre.TabIndex = 0;
            lblNombbre.Text = "label1";
            // 
            // BuscadorRI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(gbReIn);
            Controls.Add(groupBox1);
            Name = "BuscadorRI";
            Text = "BuscadorRI";
            Load += BuscadorRI_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbReIn.ResumeLayout(false);
            gbReIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDomicilio;
        private TextBox txtNombre;
        private Button btnBuscar;
        private GroupBox gbReIn;
        private Label label3;
        private Label label2;
        private Label lblNombbre;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label4;
        private Label lblApellidos;
        private PictureBox pbFoto;
        private Label lblTipo;
        private Label label5;
        private Label label1;
        private Label lbllaca;
        private Label lblModelo;
        private Label lblMarca;
        private Label label7;
        private Label label6;
        private Button button1;
        private Button btnregresar;
    }
}