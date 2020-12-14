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
using System.Windows.Forms.VisualStyles;
using Testing_Project.Accesos.Mensajero;

namespace Testing_Project.Usuarios
{
    public partial class FrmPrincipalMensajero : Form
    {
        private SqlConnection con = SQLTransact.RetornaAcceso();
        public FrmPrincipalMensajero()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("select "
                                            + "pedidos.ID,"
                                            + " prd.Nombre as Nombre_Producto, "
                                            + " prd.Descripcion, "
                                            + " persona.nombre + ' ' + persona.apellido as Cliente, "
                                            + " local.Nombre as Local "
                                            + " from pedidos pedidos "
                                            + " inner join producto prd on prd.ID = pedidos.Producto "
                                            + " inner join tbPersona persona on persona.id = pedidos.Usuario"
                                            + " inner join Local local on local.ID = pedidos.Local"
                                            + " where pedidos.Estado = 'Pendiente' ;", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dtgPedidos.AllowUserToAddRows = false;
            dtgPedidos.DataSource = dt;
        }
    
        private void btnHistoricos_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select "
                                            + "pedidos.ID,"
                                            + " prd.Nombre as Nombre_Producto, "
                                            + " prd.Descripcion, "
                                            + " persona.nombre + ' ' + persona.apellido as Cliente, "
                                            + " local.Nombre as Local "
                                            + " from pedidos pedidos "
                                            + " inner join producto prd on prd.ID = pedidos.Producto "
                                            + " inner join tbPersona persona on persona.id = pedidos.Usuario"
                                            + " inner join Local local on local.ID = pedidos.Local"
                                            + " where pedidos.Estado = 'Terminado' ;", con);
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dtgPedidos.AllowUserToAddRows = false;
            dtgPedidos.DataSource = dt;
        }

        private void dtgPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (dtgPedidos.Columns[e.ColumnIndex].HeaderText.Equals("ID"))
                {
                    var id = dtgPedidos.SelectedCells[0].Value;
                    frmPedidos pedidos = new frmPedidos(id.ToString());
                    pedidos.ShowDialog();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
