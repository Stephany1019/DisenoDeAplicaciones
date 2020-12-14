namespace Testing_Project.Accesos.Empresarial.Acciones
{
    partial class EliminarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarProducto));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Atras = new System.Windows.Forms.Button();
            this.eliminarProd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nombrelbl = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
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
            this.panel2.Controls.Add(this.eliminarProd);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 450);
            this.panel2.TabIndex = 15;
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
            // eliminarProd
            // 
            this.eliminarProd.Location = new System.Drawing.Point(36, 194);
            this.eliminarProd.Name = "eliminarProd";
            this.eliminarProd.Size = new System.Drawing.Size(99, 47);
            this.eliminarProd.TabIndex = 5;
            this.eliminarProd.Text = "Eliminar Producto";
            this.eliminarProd.UseVisualStyleBackColor = true;
            this.eliminarProd.Click += new System.EventHandler(this.EliminarProd_Click);
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
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idlbl.Location = new System.Drawing.Point(242, 168);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(18, 13);
            this.idlbl.TabIndex = 20;
            this.idlbl.Text = "ID";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(314, 161);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(166, 20);
            this.idtxt.TabIndex = 19;
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.BackColor = System.Drawing.Color.Black;
            this.nombrelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombrelbl.Location = new System.Drawing.Point(242, 211);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(44, 13);
            this.nombrelbl.TabIndex = 18;
            this.nombrelbl.Text = "Nombre";
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(314, 208);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(166, 20);
            this.nombretxt.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, -98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.nombrelbl);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
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
        private System.Windows.Forms.Button eliminarProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.TextBox nombretxt;
    }
}