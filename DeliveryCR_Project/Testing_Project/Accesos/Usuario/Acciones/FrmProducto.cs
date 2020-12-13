using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Project.Accesos.Usuario.Acciones
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Utils.producto.Equals("Hamburguesa")) {
                cbxProducto.Items.Add("Hamburguesa con queso");
                cbxProducto.Items.Add("Triple con beacon");
                cbxProducto.Items.Add("Cuarto de libra");
                cbxProducto.Items.Add("Doble torta");
            }
        }

        private void cbxProducto_MouseClick(object sender, MouseEventArgs e)
        {
            if (Utils.producto.Equals("Hamburguesa"))
            {
                cbxProducto.Items.Add("Hamburguesa con queso");
                cbxProducto.Items.Add("Triple con bacon");
                cbxProducto.Items.Add("Cuarto de libra");
                cbxProducto.Items.Add("Doble torta");
            }
            if (Utils.producto.Equals("Cafe"))
            {
                cbxProducto.Items.Add("Capuccino");
            }
            if (Utils.producto.Equals("Bebidas"))
            {
                cbxProducto.Items.Add("Coca Cola");
                cbxProducto.Items.Add("Electrolit");
                cbxProducto.Items.Add("Red Bull");
                cbxProducto.Items.Add("Canada Dry");
            }
            if (Utils.producto.Equals("Asiatica"))
            {
                cbxProducto.Items.Add("Cantones");
                cbxProducto.Items.Add("Sushi");
                cbxProducto.Items.Add("Gyosas");
            }
            if (Utils.producto.Equals("Mexicana"))
            {
                cbxProducto.Items.Add("Tacos");
                cbxProducto.Items.Add("Empanadas");
                cbxProducto.Items.Add("Tortillas");
                cbxProducto.Items.Add("Chalupas");
            }
            if (Utils.producto.Equals("Alitas"))
            {
                cbxProducto.Items.Add("15 alitas");
                cbxProducto.Items.Add("20 alitas buffalo");
                cbxProducto.Items.Add("20 alitas mostazamiel");
                cbxProducto.Items.Add("20 alitas BBQ");
            }
            if (Utils.producto.Equals("Postres"))
            {
                cbxProducto.Items.Add("Queque de chocolate");
                cbxProducto.Items.Add("Tres leches ");
                cbxProducto.Items.Add("Queque seco");
            }
            if (Utils.producto.Equals("Reposteria"))
            {
                cbxProducto.Items.Add("Empanada de pollo");
                cbxProducto.Items.Add("Pastel de carne");
                cbxProducto.Items.Add("Croissant");
            }
            if (Utils.producto.Equals("Pizza"))
            {
                cbxProducto.Items.Add("Hawaiana");
                cbxProducto.Items.Add("Pepperoni");
                cbxProducto.Items.Add("Jamon y hongos");
                cbxProducto.Items.Add("Suprema");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
