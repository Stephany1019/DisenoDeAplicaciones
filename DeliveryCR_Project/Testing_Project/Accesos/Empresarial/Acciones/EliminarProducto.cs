using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Project.Accesos.Empresarial.Acciones
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
            label1.Text = "Hola, " + SQLTransact.Usuario_Activo;
        }

        private void EliminarProd_Click(object sender, EventArgs e)
        {
            if (idtxt.Text.Equals("") || nombretxt.Text.Equals(""))
            {
                MessageBox.Show("Llene todos los espacios", "Aviso");
            }
            else
            {
                String ID = idtxt.Text;
                String nombre = nombretxt.Text;
                try
                {
                    SQLTransact.eliminaProducto(nombre, ID);
                    MessageBox.Show("Producto eliminado correctamente", "Aviso");
                    idtxt.Text = "";
                    nombretxt.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Datos incorrectos, por favor intente de nuevo", "Aviso");
                }
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
