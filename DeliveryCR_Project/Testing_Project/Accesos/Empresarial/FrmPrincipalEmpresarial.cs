using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing_Project.Usuarios.Empresarial;

namespace Testing_Project
{
    public partial class FrmPrincipalEmpresarial : Form
    {
        public FrmPrincipalEmpresarial()
        {
            InitializeComponent();
            SlidePanel1.Height = button1.Height;
            SlidePanel1.Top = button1.Top;
            SlidePanel1.Height = button1.Height;
            button1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SlidePanel1.Height = button1.Height;
            SlidePanel1.Top = button1.Top;
            button1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlidePanel1.Height = button2.Height;
            SlidePanel1.Top = button2.Top;
            button2.BringToFront();
            
        }
    }
}
