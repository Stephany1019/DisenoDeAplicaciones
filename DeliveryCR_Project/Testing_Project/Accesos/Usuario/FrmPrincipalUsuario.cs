﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing_Project.Accesos.Usuario.Acciones;

namespace Testing_Project.Usuarios.Cliente
{
    public partial class FrmPrincipalUsuario : Form
    {
        public FrmPrincipalUsuario()
        {
            InitializeComponent();
        }


        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            FrmLocalRestaurante r = new FrmLocalRestaurante();
            r.ShowDialog();        }
    }
}
