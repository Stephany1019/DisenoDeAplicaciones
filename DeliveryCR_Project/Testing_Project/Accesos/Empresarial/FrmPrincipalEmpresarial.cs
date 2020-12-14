using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing_Project.Accesos.Empresarial.Acciones;
using Testing_Project.Usuarios.Empresarial;

namespace Testing_Project
{
    public partial class FrmPrincipalEmpresarial : Form
    {
        public FrmPrincipalEmpresarial()
        {
            InitializeComponent();
            label1.Text = "Hola, "+SQLTransact.Usuario_Activo;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarProd_Click(object sender, EventArgs e)
        {
            AgregarProducto form = new AgregarProducto();
            form.ShowDialog();
            this.Close();
        }

        private void ModificarProd_Click(object sender, EventArgs e)
        {
            ModificarProducto form = new ModificarProducto();
            form.ShowDialog();
            this.Close();
        }

        private void EliminarProd_Click(object sender, EventArgs e)
        {
            EliminarProducto form = new EliminarProducto();
            form.ShowDialog();
            this.Close();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmLogin form = new FrmLogin();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
