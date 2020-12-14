namespace Testing_Project.Accesos.Usuario
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
            this.carritolbl = new System.Windows.Forms.Label();
            this.productolbl = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.preciolbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productoTXT = new System.Windows.Forms.TextBox();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.atrasBtn = new System.Windows.Forms.Button();
            this.continuarBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.totallbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // carritolbl
            // 
            this.carritolbl.AutoSize = true;
            this.carritolbl.BackColor = System.Drawing.Color.Transparent;
            this.carritolbl.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carritolbl.Location = new System.Drawing.Point(337, 38);
            this.carritolbl.Name = "carritolbl";
            this.carritolbl.Size = new System.Drawing.Size(115, 45);
            this.carritolbl.TabIndex = 0;
            this.carritolbl.Text = "Pedido";
            // 
            // productolbl
            // 
            this.productolbl.AutoSize = true;
            this.productolbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.productolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productolbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.productolbl.Location = new System.Drawing.Point(147, 142);
            this.productolbl.Name = "productolbl";
            this.productolbl.Size = new System.Drawing.Size(58, 13);
            this.productolbl.TabIndex = 1;
            this.productolbl.Text = "Producto";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.desclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.desclbl.Location = new System.Drawing.Point(351, 142);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(74, 13);
            this.desclbl.TabIndex = 2;
            this.desclbl.Text = "Descripción";
            // 
            // preciolbl
            // 
            this.preciolbl.AutoSize = true;
            this.preciolbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.preciolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciolbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.preciolbl.Location = new System.Drawing.Point(600, 142);
            this.preciolbl.Name = "preciolbl";
            this.preciolbl.Size = new System.Drawing.Size(43, 13);
            this.preciolbl.TabIndex = 3;
            this.preciolbl.Text = "Precio";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(659, 487);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 4;
            // 
            // productoTXT
            // 
            this.productoTXT.Location = new System.Drawing.Point(112, 169);
            this.productoTXT.Multiline = true;
            this.productoTXT.Name = "productoTXT";
            this.productoTXT.Size = new System.Drawing.Size(125, 114);
            this.productoTXT.TabIndex = 5;
            this.productoTXT.TextChanged += new System.EventHandler(this.ProductoTXT_TextChanged);
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(327, 169);
            this.desctxt.Multiline = true;
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(125, 114);
            this.desctxt.TabIndex = 6;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(557, 169);
            this.preciotxt.Multiline = true;
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(125, 114);
            this.preciotxt.TabIndex = 7;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(557, 303);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(125, 20);
            this.totaltxt.TabIndex = 8;
            // 
            // atrasBtn
            // 
            this.atrasBtn.Location = new System.Drawing.Point(52, 394);
            this.atrasBtn.Name = "atrasBtn";
            this.atrasBtn.Size = new System.Drawing.Size(109, 23);
            this.atrasBtn.TabIndex = 9;
            this.atrasBtn.Text = "Volver a tienda";
            this.atrasBtn.UseVisualStyleBackColor = true;
            this.atrasBtn.Click += new System.EventHandler(this.AtrasBtn_Click);
            // 
            // continuarBTN
            // 
            this.continuarBTN.Location = new System.Drawing.Point(557, 394);
            this.continuarBTN.Name = "continuarBTN";
            this.continuarBTN.Size = new System.Drawing.Size(125, 23);
            this.continuarBTN.TabIndex = 10;
            this.continuarBTN.Text = "Continuar con compra";
            this.continuarBTN.UseVisualStyleBackColor = true;
            this.continuarBTN.Click += new System.EventHandler(this.ContinuarBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totallbl.Location = new System.Drawing.Point(501, 306);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(36, 13);
            this.totallbl.TabIndex = 12;
            this.totallbl.Text = "Total";
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 434);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.continuarBTN);
            this.Controls.Add(this.atrasBtn);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.productoTXT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.preciolbl);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.productolbl);
            this.Controls.Add(this.carritolbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Carrito";
            this.Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carritolbl;
        private System.Windows.Forms.Label productolbl;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Label preciolbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox productoTXT;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Button atrasBtn;
        private System.Windows.Forms.Button continuarBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label totallbl;
    }
}