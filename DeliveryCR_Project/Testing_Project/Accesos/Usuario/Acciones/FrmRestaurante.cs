﻿using System;
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
    public partial class FrmRestaurante : Form
    {
        public FrmRestaurante()
        {
            InitializeComponent();
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            FrmProducto p = new FrmProducto();
            Utils.producto = "Hamburguesa";
            p.ShowDialog();
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            FrmProducto p = new FrmProducto();
            Utils.producto = "Cafe";
            p.ShowDialog();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            FrmProducto p = new FrmProducto();
            Utils.producto = "Bebidas";
            p.ShowDialog();
        }

        private void btnAsiatica_Click(object sender, EventArgs e)
        {
            FrmProducto p = new FrmProducto();
            Utils.producto = "Asiatica";
            p.ShowDialog();
        }

        private void btnMexicana_Click(object sender, EventArgs e)
        {
            FrmProducto p = new FrmProducto();
            Utils.producto = "Mexicana";
            p.ShowDialog();
        }

        private void btnAlitas_Click(object sender, EventArgs e)
        {
            FrmProducto p = new FrmProducto();
            Utils.producto = "Alitas";
            p.ShowDialog();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            FrmProducto p = new FrmProducto();
            Utils.producto = "Postres";
            p.ShowDialog();
        }

        private void btnReposteria_Click(object sender, EventArgs e)
        {
            FrmProducto p = new FrmProducto();
            Utils.producto = "Reposteria";
            p.ShowDialog();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            FrmProducto p = new FrmProducto();
            Utils.producto = "Pizza";
            p.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurantes.Menu1 menu1 = new Restaurantes.Menu1();
            menu1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Restaurantes.Menu2 menu2 = new Restaurantes.Menu2();
            menu2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Restaurantes.Menu3 menu3 = new Restaurantes.Menu3();
            menu3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Restaurantes.menu4 menu4 = new Restaurantes.menu4();
            menu4.ShowDialog();
        }
    }
}
