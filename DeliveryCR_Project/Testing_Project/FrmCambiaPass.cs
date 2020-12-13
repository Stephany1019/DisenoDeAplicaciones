using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Project
{
    public partial class FrmCambiaPass : Form
    {
        public FrmCambiaPass()
        {
            InitializeComponent();
        }

        private void FrmCambiaPass_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (SQLTransact.claveValida(Usuario.Text, txtPass.Text))
            {
                if ((NuevaPass.Text == ConfirmPass.Text) && (NuevaPass.Text != ""))
                {
                    SQLTransact.ActualizarPass(Usuario.Text, NuevaPass.Text);
                    MessageBox.Show("Contrasena Modificada", "Aviso");
                    ActiveForm.Close();
                }
                else
                {
                    MessageBox.Show("Las contrasenas ingresadas no coinciden o son invalidas", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Credenciales actuales invalidas", "Aviso");
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

