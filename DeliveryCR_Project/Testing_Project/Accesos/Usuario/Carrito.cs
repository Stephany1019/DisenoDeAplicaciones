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

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ContinuarBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < articulos.Count(); i++) {
                SQLTransact.agregaPedido(SQLTransact.IDUsuario_Activo, locales.ElementAt(i), idProductos.ElementAt(i), preciosLista.ElementAt(i), preciosLista.ElementAt(i));
            }
            Facturacion factura = new Facturacion();
            factura.crearPDFFactura(SQLTransact.Usuario_Activo, locales, articulos, preciosLista, totaltxt.Text, SQLTransact.retornaCorreoUsuario(SQLTransact.IDUsuario_Activo));
            MessageBox.Show("Tu orden ha sido completada, pronto te llegara una factura al correo");
        }

        private void ProductoTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
