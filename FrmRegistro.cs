using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing_Project.Properties;

namespace Testing_Project
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }


            private void button5_Click(object sender, EventArgs e)
            {
              
            }

            private void button4_Click(object sender, EventArgs e)
            {

            }

        private void panelDropDown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (SQLTransact.UsuarioValido(txtUsername.Text) && SQLTransact.CorreoValido(txtEmail.Text))
            {
                SQLTransact.AgregarLogin(txtUsername.Text, txtPass.Text, comboBox1.Text);
                SQLTransact.AgregarPersona(txtNombre.Text, txtApellido.Text, txtEmail.Text, txtTelefono.Text, txtPais.Text, txtProvincia.Text, txtCanton.Text, txtCalle.Text, txtApartamento.Text, txtZipcode.Text, comboBox1.Text);
                MessageBox.Show("Registro Completado", "Aviso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Correo Electronico invalido", "Aviso");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FrmLogin abrir = new FrmLogin();
            abrir.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

    

