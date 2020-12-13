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
    public partial class FrmMetPago : Form
    {
        public FrmMetPago()
        {
            InitializeComponent();
        }

        private void FrmMetPago_Load(object sender, EventArgs e)
        {
            Emisor.SelectedIndex = Emisor.Items.IndexOf("VISA");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if ((nombreMet.Text != "") && (CodSeg.Text != "") && (NumTar.Text != "") && (NombreTar.Text != ""))
            {
                SQLTransact.AgregarMetPago(SQLTransact.Usuario_Activo, nombreMet.Text, NombreTar.Text, Emisor.Text, CodSeg.Text, NumTar.Text);
                MessageBox.Show("Metodo de pago registrado", "Aviso");
                nombreMet.Text = "";
                CodSeg.Text = "";
                NumTar.Text = "";
                NombreTar.Text = "";
            }
            else
            {

                MessageBox.Show("No se pueden dejar espacios Vacios", "Aviso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SQLTransact.MetPagoValido(SQLTransact.Usuario_Activo))
            {
                FrmEliminarMetPago DelMetPago = new FrmEliminarMetPago();
                DelMetPago.ShowDialog();
            }
            else {

                MessageBox.Show("No hay metodos de pago registrados", "Aviso");
            }
        }
    }
}
