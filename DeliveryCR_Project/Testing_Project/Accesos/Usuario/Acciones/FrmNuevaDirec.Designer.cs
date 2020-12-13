namespace Testing_Project.Accesos.Usuario.Acciones
{
    partial class FrmNuevaDirec
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaDirec));
            this.tbDireccionTableAdapter = new Testing_Project.DeliveryCRDataSetTableAdapters.tbDireccionTableAdapter();
            this.tbDireccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryCRDataSet = new Testing_Project.DeliveryCRDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreDir = new System.Windows.Forms.TextBox();
            this.Nombre_Clave = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbDireccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCRDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDireccionTableAdapter
            // 
            this.tbDireccionTableAdapter.ClearBeforeFill = true;
            // 
            // tbDireccionBindingSource
            // 
            this.tbDireccionBindingSource.DataMember = "tbDireccion";
            this.tbDireccionBindingSource.DataSource = this.deliveryCRDataSet;
            this.tbDireccionBindingSource.CurrentChanged += new System.EventHandler(this.tbDireccionBindingSource_CurrentChanged);
            // 
            // deliveryCRDataSet
            // 
            this.deliveryCRDataSet.DataSetName = "DeliveryCRDataSet";
            this.deliveryCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 76);
            this.label2.TabIndex = 32;
            this.label2.Text = "NUEVA DIRECCION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(381, 529);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(216, 26);
            this.txtZipcode.TabIndex = 112;
            this.txtZipcode.TextChanged += new System.EventHandler(this.txtZipcode_TextChanged);
            // 
            // txtApartamento
            // 
            this.txtApartamento.Location = new System.Drawing.Point(381, 435);
            this.txtApartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(218, 26);
            this.txtApartamento.TabIndex = 111;
            this.txtApartamento.TextChanged += new System.EventHandler(this.txtApartamento_TextChanged);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(381, 346);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(218, 26);
            this.txtCalle.TabIndex = 110;
            this.txtCalle.TextChanged += new System.EventHandler(this.txtCalle_TextChanged);
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(21, 511);
            this.txtCanton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(223, 26);
            this.txtCanton.TabIndex = 109;
            this.txtCanton.TextChanged += new System.EventHandler(this.txtCanton_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(380, 498);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 25);
            this.label18.TabIndex = 108;
            this.label18.Text = "Código Postal:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(376, 406);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 25);
            this.label17.TabIndex = 107;
            this.label17.Text = "Apartamento:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(376, 315);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 25);
            this.label16.TabIndex = 106;
            this.label16.Text = "Distrito:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 477);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 25);
            this.label15.TabIndex = 105;
            this.label15.Text = "Cantón:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(21, 425);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(223, 26);
            this.txtProvincia.TabIndex = 104;
            this.txtProvincia.TextChanged += new System.EventHandler(this.txtProvincia_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 394);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 25);
            this.label14.TabIndex = 103;
            this.label14.Text = "Provincia:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(21, 345);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(223, 26);
            this.txtPais.TabIndex = 102;
            this.txtPais.TextChanged += new System.EventHandler(this.txtPais_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 315);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 25);
            this.label13.TabIndex = 101;
            this.label13.Text = "País:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 100;
            this.label12.Text = "Dirección";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 125);
            this.panel1.TabIndex = 99;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(633, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(692, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Crea nuevas direcciones para tus pedidos.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombreDir
            // 
            this.nombreDir.Location = new System.Drawing.Point(20, 280);
            this.nombreDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreDir.Name = "nombreDir";
            this.nombreDir.Size = new System.Drawing.Size(223, 26);
            this.nombreDir.TabIndex = 119;
            this.nombreDir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nombre_Clave
            // 
            this.Nombre_Clave.AutoSize = true;
            this.Nombre_Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Clave.Location = new System.Drawing.Point(16, 249);
            this.Nombre_Clave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre_Clave.Name = "Nombre_Clave";
            this.Nombre_Clave.Size = new System.Drawing.Size(143, 25);
            this.Nombre_Clave.TabIndex = 118;
            this.Nombre_Clave.Text = "Nombre Clave:";
            this.Nombre_Clave.Click += new System.EventHandler(this.Nombre_Clave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(384, 637);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(238, 82);
            this.button1.TabIndex = 114;
            this.button1.Text = "Limpiar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SeaGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(21, 637);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(238, 82);
            this.button5.TabIndex = 113;
            this.button5.Text = "Guardar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmNuevaDirec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(779, 784);
            this.ControlBox = false;
            this.Controls.Add(this.nombreDir);
            this.Controls.Add(this.Nombre_Clave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.txtApartamento);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtCanton);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNuevaDirec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Dirección";
            ((System.ComponentModel.ISupportInitialize)(this.tbDireccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCRDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DeliveryCRDataSetTableAdapters.tbDireccionTableAdapter tbDireccionTableAdapter;
        private System.Windows.Forms.BindingSource tbDireccionBindingSource;
        private DeliveryCRDataSet deliveryCRDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreDir;
        private System.Windows.Forms.Label Nombre_Clave;
    }
}