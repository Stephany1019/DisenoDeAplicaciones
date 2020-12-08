using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testing_Project
{
    class SQLTransact
    {
        public static bool Login_autorizado;
        public static String Tipo_Acceso;
        public static String Usuarios;

        public static SqlConnection RetornaAcceso()
        {
            SqlConnection conecta = new SqlConnection();
            conecta.ConnectionString = "Data Source=prodinstance.cb8w8gdwlklp.us-east-1.rds.amazonaws.com,1433; Initial Catalog='DeliveryCR';User Id=Admin;Password=W3lc0m32020";
            return conecta;
        }

        public static Boolean claveValida(String Usr, String Pwd)
        {
            String Resultado = "";
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(Username) as DATA FROM tbLogin WHERE Username ='" + Usr + "' AND Pass='" + Pwd + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            ds.Dispose();
            if (Resultado == "1") return true;
            else return false;
        }

        public static Boolean UsuarioValido(String Usr)
        {
            if (Usr != null)
            {
                String Resultado = "";
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(Username) as DATA FROM tbLogin WHERE Username ='" + Usr + "'", conx);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
                ds.Dispose();
                if (Resultado == "1") return false;
                else return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean CorreoValido(String eml)
        {


            if (eml.Contains("@"))
            {
                String Resultado = "";
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(email) as DATA FROM tbPersona WHERE email ='" + eml + "'", conx);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
                ds.Dispose();
                if (Resultado == "1") return false;
                else return true;
            }
            else
            {
                return false;
            }

        }

        public static void AgregarLogin(String Username, String Pass, String tipoAcceso)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("Insert INTO tbLogin ( Username, " + " Pass, tipoAcceso) values ( @Username," + " @Pass, @TipoAcceso) "))
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Pass", Pass);
                cmd.Parameters.AddWithValue("@tipoAcceso", tipoAcceso);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static void AgregarPersona(String nombre, String apellido, String email, String telefono, String Pais, String Provincia, String Canton, String Distrito, String Apartamento, String Zipcode)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("Insert INTO tbPersona ( nombre, " + " apellido, email, telefono, Pais, Provincia, Canton, Distrito, Apartamento, Zipcode) values ( @nombre," + " @apellido, @email, @telefono, @Pais, @Provincia, @Canton, @Distrito, @Apartamento, @Zipcode) "))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@Pais", Pais);
                cmd.Parameters.AddWithValue("@Provincia", Provincia);
                cmd.Parameters.AddWithValue("@Canton", Canton);
                cmd.Parameters.AddWithValue("@Distrito", Distrito);
                cmd.Parameters.AddWithValue("@Apartamento", Apartamento);
                cmd.Parameters.AddWithValue("@Zipcode", Zipcode);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static void AgregarDireccion(String Username, String nombreDir, String Pais, String Provincia, String Canton, String Distrito, String Apartamento, String Zipcode)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("Insert INTO tbDireccion ( Username, " + " nombreDir, Pais, Provincia, Canton, Distrito, Apartamento, Zipcode) values ( @Username," + " @nombreDir, @Pais, @Provincia, @Canton, @Distrito, @Apartamento, @Zipcode) "))
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@nombreDir", nombreDir);
                cmd.Parameters.AddWithValue("@Pais", Pais);
                cmd.Parameters.AddWithValue("@Provincia", Provincia);
                cmd.Parameters.AddWithValue("@Canton", Canton);
                cmd.Parameters.AddWithValue("@Distrito", Distrito);
                cmd.Parameters.AddWithValue("@Apartamento", Apartamento);
                cmd.Parameters.AddWithValue("@Zipcode", Zipcode);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static String TipoAcceso(String Usr)
        {

            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT tipoAcceso AS DATA FROM tbLogin WHERE Username ='" + Usr + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }
    }
}