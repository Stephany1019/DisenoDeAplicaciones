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
    public partial class IniSesion : Form
    {
        public IniSesion()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void IniSesion_Load(object sender, EventArgs e)
        {
            Usuario.Text = SQLTransact.Usuario_Activo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SQLTransact.claveValida(Usuario.Text, txtPass.Text))
            {
                if ((NuevaPass.Text == ConfirmPass.Text) && (NuevaPass.Text != ""))
                {
                    SQLTransact.ActualizarPass(SQLTransact.Usuario_Activo, NuevaPass.Text);
                    MessageBox.Show("Contrasena Modificada", "Aviso");
                    txtPass.Text = "";
                    NuevaPass.Text = "";
                    ConfirmPass.Text = "";
                }
                else {
                    MessageBox.Show("Las contrasenas ingresadas no coinciden o son invalidas", "Aviso");
                }
            }
            else {
                MessageBox.Show("Credenciales actuales invalidas", "Aviso");
            }
        }
    }
}
