namespace Testing_Project
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            this.cantidadlbl = new System.Windows.Forms.Label();
            this.itemlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cantidadtxt = new System.Windows.Forms.TextBox();
            this.itemtxt = new System.Windows.Forms.TextBox();
            this.volverbtn = new System.Windows.Forms.Button();
            this.continuarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadlbl
            // 
            this.cantidadlbl.AutoSize = true;
            this.cantidadlbl.Location = new System.Drawing.Point(185, 157);
            this.cantidadlbl.Name = "cantidadlbl";
            this.cantidadlbl.Size = new System.Drawing.Size(49, 13);
            this.cantidadlbl.TabIndex = 0;
            this.cantidadlbl.Text = "Cantidad";
            // 
            // itemlbl
            // 
            this.itemlbl.AutoSize = true;
            this.itemlbl.Location = new System.Drawing.Point(392, 157);
            this.itemlbl.Name = "itemlbl";
            this.itemlbl.Size = new System.Drawing.Size(27, 13);
            this.itemlbl.TabIndex = 1;
            this.itemlbl.Text = "Item";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cantidadtxt.Location = new System.Drawing.Point(158, 185);
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(100, 20);
            this.cantidadtxt.TabIndex = 3;
            // 
            // itemtxt
            // 
            this.itemtxt.Location = new System.Drawing.Point(359, 185);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(100, 20);
            this.itemtxt.TabIndex = 4;
            // 
            // volverbtn
            // 
            this.volverbtn.Location = new System.Drawing.Point(47, 373);
            this.volverbtn.Name = "volverbtn";
            this.volverbtn.Size = new System.Drawing.Size(92, 23);
            this.volverbtn.TabIndex = 5;
            this.volverbtn.Text = "Volver a menú";
            this.volverbtn.UseVisualStyleBackColor = true;
            // 
            // continuarbtn
            // 
            this.continuarbtn.Location = new System.Drawing.Point(503, 373);
            this.continuarbtn.Name = "continuarbtn";
            this.continuarbtn.Size = new System.Drawing.Size(75, 23);
            this.continuarbtn.TabIndex = 6;
            this.continuarbtn.Text = "Continuar";
            this.continuarbtn.UseVisualStyleBackColor = true;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.continuarbtn);
            this.Controls.Add(this.volverbtn);
            this.Controls.Add(this.itemtxt);
            this.Controls.Add(this.cantidadtxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.itemlbl);
            this.Controls.Add(this.cantidadlbl);
            this.Name = "Carrito";
            this.Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cantidadlbl;
        private System.Windows.Forms.Label itemlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cantidadtxt;
        private System.Windows.Forms.TextBox itemtxt;
        private System.Windows.Forms.Button volverbtn;
        private System.Windows.Forms.Button continuarbtn;
    }
}