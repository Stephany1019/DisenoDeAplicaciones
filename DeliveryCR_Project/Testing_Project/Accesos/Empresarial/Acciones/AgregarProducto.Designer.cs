namespace Testing_Project.Accesos.Empresarial.Acciones
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Atras = new System.Windows.Forms.Button();
            this.guardarProd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.nombrelbl = new System.Windows.Forms.Label();
            this.descLb = new System.Windows.Forms.Label();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.preciolbl = new System.Windows.Forms.Label();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.tipolbl = new System.Windows.Forms.Label();
            this.tipoCombo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.Atras);
            this.panel2.Controls.Add(this.guardarProd);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 450);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(12, 398);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(99, 24);
            this.Atras.TabIndex = 8;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // guardarProd
            // 
            this.guardarProd.Location = new System.Drawing.Point(36, 194);
            this.guardarProd.Name = "guardarProd";
            this.guardarProd.Size = new System.Drawing.Size(99, 47);
            this.guardarProd.TabIndex = 5;
            this.guardarProd.Text = "Guardar Producto";
            this.guardarProd.UseVisualStyleBackColor = true;
            this.guardarProd.Click += new System.EventHandler(this.AgregarProd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.LimeGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 62);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sesion empresarial";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(312, 116);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(166, 20);
            this.nombretxt.TabIndex = 6;
            this.nombretxt.TextChanged += new System.EventHandler(this.Nombretxt_TextChanged);
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.BackColor = System.Drawing.Color.Black;
            this.nombrelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombrelbl.Location = new System.Drawing.Point(240, 119);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(44, 13);
            this.nombrelbl.TabIndex = 7;
            this.nombrelbl.Text = "Nombre";
            this.nombrelbl.Click += new System.EventHandler(this.Label2_Click);
            // 
            // descLb
            // 
            this.descLb.AutoSize = true;
            this.descLb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descLb.Location = new System.Drawing.Point(240, 168);
            this.descLb.Name = "descLb";
            this.descLb.Size = new System.Drawing.Size(63, 13);
            this.descLb.TabIndex = 9;
            this.descLb.Text = "Descripción";
            this.descLb.Click += new System.EventHandler(this.DescLb_Click);
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(312, 161);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(166, 20);
            this.desctxt.TabIndex = 8;
            this.desctxt.TextChanged += new System.EventHandler(this.Desctxt_TextChanged);
            // 
            // preciolbl
            // 
            this.preciolbl.AutoSize = true;
            this.preciolbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.preciolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.preciolbl.Location = new System.Drawing.Point(240, 211);
            this.preciolbl.Name = "preciolbl";
            this.preciolbl.Size = new System.Drawing.Size(37, 13);
            this.preciolbl.TabIndex = 11;
            this.preciolbl.Text = "Precio";
            this.preciolbl.Click += new System.EventHandler(this.Preciolbl_Click);
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(312, 208);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(166, 20);
            this.preciotxt.TabIndex = 10;
            this.preciotxt.TextChanged += new System.EventHandler(this.Preciotxt_TextChanged);
            // 
            // tipolbl
            // 
            this.tipolbl.AutoSize = true;
            this.tipolbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tipolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tipolbl.Location = new System.Drawing.Point(240, 263);
            this.tipolbl.Name = "tipolbl";
            this.tipolbl.Size = new System.Drawing.Size(28, 13);
            this.tipolbl.TabIndex = 13;
            this.tipolbl.Text = "Tipo";
            this.tipolbl.Click += new System.EventHandler(this.Tipolbl_Click);
            // 
            // tipoCombo
            // 
            this.tipoCombo.FormattingEnabled = true;
            this.tipoCombo.Location = new System.Drawing.Point(312, 260);
            this.tipoCombo.Name = "tipoCombo";
            this.tipoCombo.Size = new System.Drawing.Size(166, 21);
            this.tipoCombo.TabIndex = 14;
            this.tipoCombo.SelectedIndexChanged += new System.EventHandler(this.TipoCombo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, -98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tipoCombo);
            this.Controls.Add(this.tipolbl);
            this.Controls.Add(this.preciolbl);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.descLb);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.nombrelbl);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProducto";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button guardarProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Label descLb;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Label preciolbl;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.Label tipolbl;
        private System.Windows.Forms.ComboBox tipoCombo;
    }
}