﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Project.Accesos.Usuario.Acciones.Acciones_supermercado
{
    public partial class Limpieza : Form

    {
        List<string> articulos = new List<string>();
        private SqlConnection con = SQLTransact.RetornaAcceso();
        public Limpieza()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar lista de pedidos 
            articulos.Add(comboBox1.SelectedItem.ToString());

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar lista de pedidos 
            articulos.Add(comboBox1.SelectedItem.ToString());

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar lista de pedidos 
            articulos.Add(comboBox1.SelectedItem.ToString());

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar lista de pedidos 
            articulos.Add(comboBox1.SelectedItem.ToString());

        }




        private void Limpieza_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" select prd.Nombre from Producto prd "
                                                   + " inner join tipo_producto tp on tp.id = prd.tipo"
                                                   + " where tp.id = 7", con);
            con.Open();
            SqlDataReader producto = cmd.ExecuteReader();
            while (producto.Read())
            {
                comboBox1.Items.Add(producto["Nombre"].ToString());
            }
            con.Close();
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}