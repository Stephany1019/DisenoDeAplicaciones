using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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

namespace Testing_Project.Accesos.Mensajero
{
    public partial class frmPedidos : Form
    {
        public DataTable Dt { get; set; } = new DataTable();
        private int id;
        private SqlConnection con;
        public frmPedidos(string id)
        {
            this.id = int.Parse(id);
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            con = SQLTransact.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("UPDATE Pedidos SET Estado = 'Terminado' WHERE ID = @id;",con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            this.Close();
        }
    }
}
