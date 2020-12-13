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
    public partial class FrmNuevaDirec : Form
    {
        public FrmNuevaDirec()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((nombreDir.Text != "Personal") && (nombreDir.Text != ""))
            {
                SQLTransact.AgregarDireccion(SQLTransact.Usuario_Activo, nombreDir.Text, txtPais.Text, txtProvincia.Text, txtCanton.Text, txtCalle.Text, txtApartamento.Text, txtZipcode.Text);
                MessageBox.Show("Nueva direccion Creada", "Aviso");
                nombreDir.Text = "";
                txtPais.Text = "";
                txtApartamento.Text = "";
                txtCanton.Text = "";
                txtZipcode.Text = "";
                txtProvincia.Text = "";
                txtCalle.Text = "";
            }
            else {

                MessageBox.Show("EL nombre clave elegido no es valido", "Aviso");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreDir.Text = "";
            txtPais.Text = "";
            txtApartamento.Text = "";
            txtCanton.Text = "";
            txtZipcode.Text = "";
            txtProvincia.Text = "";
            txtCalle.Text = "";
        }

        private void tbDireccionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtZipcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCanton_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Clave_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
