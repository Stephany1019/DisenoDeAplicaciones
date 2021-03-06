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
    public partial class FrmCuenta : Form
    {
        public FrmCuenta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmCuenta_Direccion cuenta_Dir = new FrmCuenta_Direccion();
            cuenta_Dir.ShowDialog();
        }

        private void FrmCuenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNuevaDirec Direc = new FrmNuevaDirec();
            Direc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IniSesion Sesion = new IniSesion();
            Sesion.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMetPago MetPago = new FrmMetPago();
            MetPago.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
