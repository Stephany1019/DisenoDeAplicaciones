using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Testing_Project.Accesos.Usuario.Acciones
{
    public partial class FrmHistorialPedidos : Form
    {
        private SqlConnection con = SQLTransact.RetornaAcceso();
        public FrmHistorialPedidos()
        {
            InitializeComponent();
        }

        private void btnHistoricos_Click(object sender, EventArgs e)
        {

        }

        private void dtgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHistorialPedidos_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select "
                                + "pedidos.ID,"
                                + " prd.Nombre as Nombre_Producto, "
                                + " prd.Descripcion, "
                                + " persona.nombre + ' ' + persona.apellido as Cliente, "
                                + " local.Nombre as Local, "
                                + " Precio "
                                + " from pedidos pedidos "
                                + " inner join producto prd on prd.ID = pedidos.Producto "
                                + " inner join tbPersona persona on persona.id = pedidos.Usuario"
                                + " Inner join tbLogin on tbLogin.idLog = persona.id"
                                + " inner join Local local on local.ID = pedidos.Local"
                                + " where pedidos.Estado = 'Terminado' and Username = '" + SQLTransact.Usuario_Activo + "' ;", con);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dtgPedidos.AllowUserToAddRows = false;
            dtgPedidos.DataSource = dt;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
