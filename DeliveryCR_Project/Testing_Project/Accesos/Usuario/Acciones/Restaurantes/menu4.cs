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

namespace Testing_Project.Accesos.Usuario.Acciones.Restaurantes
{
    public partial class menu4 : Form
    {
        public menu4()
        {
            InitializeComponent();
        }

        readonly List<string> articulos = new List<string>();
        private SqlConnection con = SQLTransact.RetornaAcceso();
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar lista de pedidos 
            articulos.Add(comboBox2.SelectedItem.ToString());

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar lista de pedidos 
            articulos.Add(comboBox2.SelectedItem.ToString());

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar lista de pedidos 
            articulos.Add(comboBox2.SelectedItem.ToString());

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar lista de pedidos 
            articulos.Add(comboBox2.SelectedItem.ToString());

        }
        private void menu4_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" select prd.Nombre from Producto prd "
                                       + " inner join tipo_producto tp on tp.id = prd.tipo"
                                       + " where tp.id = 9", con);
            con.Open();
            SqlDataReader producto = cmd.ExecuteReader();
            while (producto.Read())
            {
                comboBox1.Items.Add(producto["Nombre"].ToString());
            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
