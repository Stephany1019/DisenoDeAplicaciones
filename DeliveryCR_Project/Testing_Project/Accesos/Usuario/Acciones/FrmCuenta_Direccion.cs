using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testing_Project.Accesos.Usuario.Acciones
{
    public partial class FrmCuenta_Direccion : Form
    {
        SqlConnection con = new SqlConnection("Data Source=prodinstance.cb8w8gdwlklp.us-east-1.rds.amazonaws.com,1433; Initial Catalog='DeliveryCR';User Id=Admin;Password=W3lc0m32020");
        public FrmCuenta_Direccion()
        {
            InitializeComponent();
            cargar_datos(SQLTransact.Usuario_Activo);
        }

        public void cargar_datos(String Usr) {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT nombreDir FROM tbDireccion WHERE Username ='" + Usr + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            DataRow fila = dt.NewRow();
            fila["nombreDir"] = "";
            dt.Rows.InsertAt(fila, 0);
            comboBox1.DisplayMember = "nombreDir";
            comboBox1.DataSource = dt;

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void FrmCuenta_Direccion_Load(object sender, EventArgs e)
        {


        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SQLTransact.nombreDirValido(SQLTransact.Usuario_Activo, comboBox1.Text))
            {
                SQLTransact.ActualizarDireccion(SQLTransact.Usuario_Activo, comboBox1.Text, txtPais.Text, txtProvincia.Text, txtCanton.Text, txtCalle.Text, txtApartamento.Text, txtZipcode.Text);
                MessageBox.Show("Datos Guardados", "Aviso");
                txtPais.Text = "";
                txtApartamento.Text = "";
                txtCanton.Text = "";
                txtZipcode.Text = "";
                txtProvincia.Text = "";
                txtCalle.Text = "";
            }
            else
            {
                MessageBox.Show("Seleccione un nombre de Direccion Valido", "Aviso");

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (SQLTransact.nombreDirValido(SQLTransact.Usuario_Activo, comboBox1.Text))
            {

                txtPais.Text = SQLTransact.RetornaPais(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtApartamento.Text = SQLTransact.RetornaApartamento(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtCanton.Text = SQLTransact.RetornaCanton(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtZipcode.Text = SQLTransact.RetornaZipcode(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtProvincia.Text = SQLTransact.RetornaProvincia(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtCalle.Text = SQLTransact.RetornaDistrito(SQLTransact.Usuario_Activo, comboBox1.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un nombre de Direccion Valido", "Aviso");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SQLTransact.nombreDirValido(SQLTransact.Usuario_Activo, comboBox1.Text))
            {

                txtPais.Text = SQLTransact.RetornaPais(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtApartamento.Text = SQLTransact.RetornaApartamento(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtCanton.Text = SQLTransact.RetornaCanton(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtZipcode.Text = SQLTransact.RetornaZipcode(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtProvincia.Text = SQLTransact.RetornaProvincia(SQLTransact.Usuario_Activo, comboBox1.Text);
                txtCalle.Text = SQLTransact.RetornaDistrito(SQLTransact.Usuario_Activo, comboBox1.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un nombre de Direccion Valido", "Aviso");

            }
        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text != "Personal") && (comboBox1.Text != ""))
            {
                SQLTransact.EliminarDireccion(SQLTransact.Usuario_Activo, comboBox1.Text);
                MessageBox.Show("Direccion Eliminada", "Aviso");
                txtPais.Text = "";
                txtApartamento.Text = "";
                txtCanton.Text = "";
                txtZipcode.Text = "";
                txtProvincia.Text = "";
                txtCalle.Text = "";
            }
            else
            {

                MessageBox.Show("La Direccion Personal y las no registradas no se pueden eliminar", "Aviso");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtApartamento_TextChanged(object sender, EventArgs e)
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbDireccionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtZipcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
