using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing_Project.Accesos.Usuario;
using Testing_Project.Accesos.Usuario.Acciones;

namespace Testing_Project.Usuarios.Cliente
{
    public partial class FrmPrincipalUsuario : Form
    {
        public FrmPrincipalUsuario()
        {
            InitializeComponent();
        }


        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            FrmLocalRestaurante r = new FrmLocalRestaurante();
            r.ShowDialog();        }

        private void btnSupermercado_Click(object sender, EventArgs e)
        {
            FrmLocalSupermercado r = new FrmLocalSupermercado();
            r.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmLocalSupermercado r = new FrmLocalSupermercado();
            r.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            carrito.ShowDialog();
        }
    }
}
