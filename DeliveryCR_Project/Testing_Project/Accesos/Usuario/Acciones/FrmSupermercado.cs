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
    public partial class FrmSupermercado : Form
    {
        public FrmSupermercado()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCarnes_Click(object sender, EventArgs e)
        {

        }

        private void btnLacteos_Click(object sender, EventArgs e)
        {

        }

        private void btnVegetales_Click(object sender, EventArgs e)
        {

        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {

        }

        private void btnPanaderia_Click(object sender, EventArgs e)
        {

        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {

        }

        private void btnHigiene_Click(object sender, EventArgs e)
        {

        }

        private void btnLicores_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acciones_supermercado.Carnes carnes = new Acciones_supermercado.Carnes();
            carnes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acciones_supermercado.Snacks snacks = new Acciones_supermercado.Snacks();
            snacks.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Acciones_supermercado.Lacteos lacteos = new Acciones_supermercado.Lacteos();
            lacteos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Acciones_supermercado.Bebidas bebidas = new Acciones_supermercado.Bebidas();
            bebidas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Acciones_supermercado.Limpieza limpieza = new Acciones_supermercado.Limpieza();
            limpieza.ShowDialog();
        }
    }
}
