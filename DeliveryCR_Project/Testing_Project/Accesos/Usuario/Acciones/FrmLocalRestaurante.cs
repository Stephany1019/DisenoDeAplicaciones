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
    public partial class FrmLocalRestaurante : Form
    {
        public FrmLocalRestaurante()
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

            switch (local) {
                case "KFC":
                default:
                    localSeleccionado = 1;
                    break;
                case "Mcdonalds":
                    localSeleccionado = 2;
                    break;
                case "Burger King":
                    localSeleccionado = 3;
                    break;
                case "As":
                    localSeleccionado = 4;
                    break;
                case "Distrito 87":
                    localSeleccionado = 5;
                    break;
            }

            FrmRestaurante r = new FrmRestaurante();
            r.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string local = comboBox2.Text;

            switch (local)
            {
                case "Antojitos":
                    localSeleccionado = 6;
                    break;
                case "Soda Castro":
                    localSeleccionado = 7;
                    break;
                case "Princesa Marina":
                    localSeleccionado = 8;
                    break;
            }
        FrmRestaurante r = new FrmRestaurante();
            r.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string local = comboBox3.Text;

            switch (local)
            {
                case "Pane & Vino":
                    localSeleccionado = 9;
                    break;
                case "Fojoncito":
                    localSeleccionado = 10;
                    break;
            }
            FrmRestaurante r = new FrmRestaurante();
            r.ShowDialog();
        }
    }
}
