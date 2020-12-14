using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Project.Accesos.Empresarial.Acciones
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            label1.Text = "Hola, " + SQLTransact.Usuario_Activo;
            SqlDataReader sqlReader = SQLTransact.RetornaTipoProducto();
            while (sqlReader.Read())
            {
                tipoCombo.Items.Add(sqlReader["DATA"].ToString());
            }

        }

        private void AgregarProd_Click(object sender, EventArgs e)
        {
            if (nombretxt.Text.Equals("") || desctxt.Text.Equals("") || preciotxt.Text.Equals("") || tipoCombo.Text.Equals(""))
            {
                MessageBox.Show("Llene todos los espacios", "Aviso");
            }
            else {
                String nombre = nombretxt.Text;
                String desc = desctxt.Text;
                float precio = float.Parse(preciotxt.Text);
                String tipo = tipoCombo.Text;
                int tipoX = 0;
                switch (tipo)
                {
                    case "Carnes":
                        tipoX = 1;
                        break;
                    case "Lacteos":
                        tipoX = 2;
                        break;
                    case "Cervezas":
                        tipoX = 3;
                        break;
                    case "Vino":
                        tipoX = 4;
                        break;
                    case "Otros":
                        tipoX = 5;
                        break;
                    case "Hamburguesas":
                        tipoX = 6;
                        break;
                    case "Limpieza":
                        tipoX = 7;
                        break;
                    case "Pollo":
                        tipoX = 8;
                        break;
                    case "café":
                        tipoX = 9;
                        break;
                    case "Snacks":
                        tipoX = 10;
                        break;

                }
                try
                {
                    SQLTransact.agregaProducto(nombre, desc, precio, tipoX);
                    MessageBox.Show("Producto agregado correctamente", "Aviso");
                    nombretxt.Text = "";
                    desctxt.Text = "";
                    preciotxt.Text = "";
                    tipoCombo.Text = "";
                }
                catch (Exception) {
                    MessageBox.Show("Datos incorrectos, por favor intente de nuevo", "Aviso");
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            FrmPrincipalEmpresarial form = new FrmPrincipalEmpresarial();
            form.ShowDialog();
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Nombretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescLb_Click(object sender, EventArgs e)
        {

        }

        private void Desctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Preciolbl_Click(object sender, EventArgs e)
        {

        }

        private void Preciotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tipolbl_Click(object sender, EventArgs e)
        {

        }

        private void TipoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
