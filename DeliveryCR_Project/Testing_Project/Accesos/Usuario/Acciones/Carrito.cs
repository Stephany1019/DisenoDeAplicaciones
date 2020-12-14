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

namespace Testing_Project.Accesos.Usuario
{
    public partial class Carrito : Form
    {

        public List<string> articulos = new List<string>();
        public List<string> elementos = new List<string>();
        private SqlConnection con = SQLTransact.RetornaAcceso();
        public Carrito()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Carrito_Load(object sender, EventArgs e)
        {

            Acciones.Restaurantes.Menu1 menu1 = new Acciones.Restaurantes.Menu1();
            articulos.AddRange(menu1.articulos);
            Acciones.Restaurantes.Menu2 menu2 = new Acciones.Restaurantes.Menu2();
            articulos.AddRange(menu2.articulos);
            Acciones.Restaurantes.Menu3 menu3 = new Acciones.Restaurantes.Menu3();
            articulos.AddRange(menu3.articulos);
            Acciones.Restaurantes.menu4 menu4 = new Acciones.Restaurantes.menu4();
            articulos.AddRange(menu4.articulos);

            articulos.ForEach(delegate (String name)
            {
                SqlCommand cmd = new SqlCommand(" select prd.Nombre from Producto prd "
                            + " inner join tipo_producto tp on tp.id = prd.tipo"
                            + " where tp.Nombre =" + name, con);
                con.Open();
                SqlDataReader producto = cmd.ExecuteReader();
                while (producto.Read())
                {
                    listBox1.Items.Add(producto["Nombre"].ToString());
                }
                con.Close();
                Console.WriteLine(name);
            });

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
