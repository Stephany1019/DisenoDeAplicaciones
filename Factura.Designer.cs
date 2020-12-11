namespace Testing_Project
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.Facturalbl = new System.Windows.Forms.Label();
            this.Cantidadlbl = new System.Windows.Forms.Label();
            this.Itemlbl = new System.Windows.Forms.Label();
            this.Preciolbl = new System.Windows.Forms.Label();
            this.Totallbl = new System.Windows.Forms.Label();
            this.cantidadtxt = new System.Windows.Forms.TextBox();
            this.itemtxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.Volverbtn = new System.Windows.Forms.Button();
            this.finalizarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Facturalbl
            // 
            this.Facturalbl.AutoSize = true;
            this.Facturalbl.Location = new System.Drawing.Point(256, 61);
            this.Facturalbl.Name = "Facturalbl";
            this.Facturalbl.Size = new System.Drawing.Size(43, 13);
            this.Facturalbl.TabIndex = 0;
            this.Facturalbl.Text = "Factura";
            this.Facturalbl.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Cantidadlbl
            // 
            this.Cantidadlbl.AutoSize = true;
            this.Cantidadlbl.Location = new System.Drawing.Point(120, 140);
            this.Cantidadlbl.Name = "Cantidadlbl";
            this.Cantidadlbl.Size = new System.Drawing.Size(49, 13);
            this.Cantidadlbl.TabIndex = 1;
            this.Cantidadlbl.Text = "Cantidad";
            // 
            // Itemlbl
            // 
            this.Itemlbl.AutoSize = true;
            this.Itemlbl.Location = new System.Drawing.Point(256, 140);
            this.Itemlbl.Name = "Itemlbl";
            this.Itemlbl.Size = new System.Drawing.Size(27, 13);
            this.Itemlbl.TabIndex = 2;
            this.Itemlbl.Text = "Item";
            // 
            // Preciolbl
            // 
            this.Preciolbl.AutoSize = true;
            this.Preciolbl.Location = new System.Drawing.Point(402, 138);
            this.Preciolbl.Name = "Preciolbl";
            this.Preciolbl.Size = new System.Drawing.Size(37, 13);
            this.Preciolbl.TabIndex = 3;
            this.Preciolbl.Text = "Precio";
            // 
            // Totallbl
            // 
            this.Totallbl.AutoSize = true;
            this.Totallbl.Location = new System.Drawing.Point(169, 303);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(31, 13);
            this.Totallbl.TabIndex = 4;
            this.Totallbl.Text = "Total";
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.Location = new System.Drawing.Point(89, 169);
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(100, 20);
            this.cantidadtxt.TabIndex = 5;
            // 
            // itemtxt
            // 
            this.itemtxt.Location = new System.Drawing.Point(224, 169);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(100, 20);
            this.itemtxt.TabIndex = 6;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(368, 169);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(100, 20);
            this.preciotxt.TabIndex = 7;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(224, 300);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(100, 20);
            this.totaltxt.TabIndex = 8;
            // 
            // Volverbtn
            // 
            this.Volverbtn.Location = new System.Drawing.Point(38, 373);
            this.Volverbtn.Name = "Volverbtn";
            this.Volverbtn.Size = new System.Drawing.Size(111, 23);
            this.Volverbtn.TabIndex = 9;
            this.Volverbtn.Text = "Volver al carrito";
            this.Volverbtn.UseVisualStyleBackColor = true;
            // 
            // finalizarbtn
            // 
            this.finalizarbtn.Location = new System.Drawing.Point(470, 373);
            this.finalizarbtn.Name = "finalizarbtn";
            this.finalizarbtn.Size = new System.Drawing.Size(107, 23);
            this.finalizarbtn.TabIndex = 10;
            this.finalizarbtn.Text = "Finalizar Pedido";
            this.finalizarbtn.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalizarbtn);
            this.Controls.Add(this.Volverbtn);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.itemtxt);
            this.Controls.Add(this.cantidadtxt);
            this.Controls.Add(this.Totallbl);
            this.Controls.Add(this.Preciolbl);
            this.Controls.Add(this.Itemlbl);
            this.Controls.Add(this.Cantidadlbl);
            this.Controls.Add(this.Facturalbl);
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Facturalbl;
        private System.Windows.Forms.Label Cantidadlbl;
        private System.Windows.Forms.Label Itemlbl;
        private System.Windows.Forms.Label Preciolbl;
        private System.Windows.Forms.Label Totallbl;
        private System.Windows.Forms.TextBox cantidadtxt;
        private System.Windows.Forms.TextBox itemtxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Button Volverbtn;
        private System.Windows.Forms.Button finalizarbtn;
    }
}