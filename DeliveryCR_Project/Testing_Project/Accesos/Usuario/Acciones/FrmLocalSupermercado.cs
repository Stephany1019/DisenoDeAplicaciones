using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Project.Accesos.Usuario.Acciones
{
    public partial class FrmLocalSupermercado : Form
    {
        public FrmLocalSupermercado()
        {
            InitializeComponent();
        }

        public static int localSeleccionado;
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string local = comboBox1.Text;

            switch (local)
            {
                case "Walmart":
                    localSeleccionado = 11;
                    break;
                case "Maxipali":
                    localSeleccionado = 12;
                    break;
            }
            FrmSupermercado r = new FrmSupermercado();
            r.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmSupermercado r = new FrmSupermercado();
            r.ShowDialog();
        }
    }
}
