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

        public static List<string> articulos = new List<string>();
        public static List<string> locales = new List<string>();
        public List<string> elementos = new List<string>();
        private SqlConnection con = SQLTransact.RetornaAcceso();
        List<string> preciosLista = new List<string>();
        List<string> idProductos = new List<string>();
        float total = 0;
        public Carrito()
        {
            InitializeComponent();
            cargar_tarjetas(SQLTransact.Usuario_Activo);
            cargar_datos(SQLTransact.Usuario_Activo);
            articulos.AddRange(Acciones.Restaurantes.Menu1.articulos);
            articulos.AddRange(Acciones.Restaurantes.Menu2.articulos);
            articulos.AddRange(Acciones.Restaurantes.Menu3.articulos);
            articulos.AddRange(Acciones.Restaurantes.menu4.articulos);

            string productos = "";
            string descripciones = "";
            string precios = "";
            string precio = "";

            foreach (string producto in articulos) {
                productos = productos + producto + Environment.NewLine;
                idProductos.Add(SQLTransact.retornaIDProducto(producto));
                descripciones = descripciones + SQLTransact.retornaDescProducto(producto) + Environment.NewLine;
                precio = SQLTransact.retornaPrecioProducto(producto);
                preciosLista.Add(precio);
                precios = precios + precio + Environment.NewLine;
                total = total + float.Parse(precio);
            }

            productoTXT.Text = productos;
            desctxt.Text = descripciones;
            preciotxt.Text = precios;

            totaltxt.Text = total.ToString();
           
        }

        public void cargar_tarjetas(String Usr)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT nombreMet FROM tbMetPagos WHERE Username ='" + Usr + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            DataRow fila = dt.NewRow();
            fila["nombreMet"] = "";
            dt.Rows.InsertAt(fila, 0);
            comboBox1.DisplayMember = "nombreMet";
            comboBox1.DataSource = dt;

        }

        public void cargar_datos(String Usr)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT nombreDir FROM tbDireccion WHERE Username ='" + Usr + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            DataRow fila = dt.NewRow();
            fila["nombreDir"] = "";
            dt.Rows.InsertAt(fila, 0);
            comboBox2.DisplayMember = "nombreDir";
            comboBox2.DataSource = dt;

        }


        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ContinuarBTN_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text != "") && (comboBox2.Text != ""))
            {
                for (int i = 0; i < articulos.Count(); i++)
                {
                    SQLTransact.agregaPedido(SQLTransact.IDUsuario_Activo, locales.ElementAt(i), idProductos.ElementAt(i), preciosLista.ElementAt(i), preciosLista.ElementAt(i));
                }
                SQLTransact.MetPago_Completo = SQLTransact.ObtMepagCompleto(SQLTransact.Usuario_Activo, comboBox1.Text);
                SQLTransact.Dir_Completa = SQLTransact.ObtDireccionCompleta(SQLTransact.Usuario_Activo, comboBox2.Text);
                Facturacion factura = new Facturacion();
                factura.crearPDFFactura(SQLTransact.Usuario_Activo, locales, articulos, preciosLista, totaltxt.Text, SQLTransact.retornaCorreoUsuario(SQLTransact.IDUsuario_Activo));
                MessageBox.Show("Tu orden ha sido completada, pronto te llegara una factura al correo");
                ActiveForm.Close();
            }
            else {

                MessageBox.Show("Seleccione un metodo de pago y una direccion");
            }
            
        }

        private void ProductoTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("Efectivo");
        }
    }
}
