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
    public partial class FrmEliminarMetPago : Form
    {
        SqlConnection con = new SqlConnection("Data Source=prodinstance.cb8w8gdwlklp.us-east-1.rds.amazonaws.com,1433; Initial Catalog='DeliveryCR';User Id=Admin;Password=W3lc0m32020");
        public FrmEliminarMetPago()
        {
            InitializeComponent();
            cargar_tarjetas(SQLTransact.Usuario_Activo);
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

        private void FrmEliminarMetPago_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                SQLTransact.EliminarMetPago(SQLTransact.Usuario_Activo, comboBox1.Text);
                MessageBox.Show("Metodo de pago eliminado", "Aviso");
                ActiveForm.Close();
            }
            else
            {

                MessageBox.Show("El metodo de pago no existe", "Aviso");
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
    }
}
