using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FrmCuenta cuenta = new FrmCuenta();
            cuenta.ShowDialog();
        }

        private void FrmPrincipalUsuario_Load(object sender, EventArgs e)
        {
            Usuario.Text = SQLTransact.Usuario_Activo;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
