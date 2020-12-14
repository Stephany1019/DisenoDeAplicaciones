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
        public static String Usuario_Activo;
        public static String IDUsuario_Activo;

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

        public static String retornaIDUsuario(String usuario) {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select id AS DATA from tbPersona where nombre ='" + usuario + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static String retornaCorreoUsuario(String id)
        {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select email AS DATA from tbPersona where id ='" + id + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
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

        public static Boolean nombreDirValido(String Usr, String Dir)
        {
            if (Dir != null)
            {
                String Resultado = "";
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                SqlDataAdapter da = new SqlDataAdapter("Select COUNT(nombreDir) AS DATA from tbDireccion where nombreDir ='" + Dir + "' AND Username = '" + Usr + "'", conx);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
                ds.Dispose();
                if (Resultado == "1") return true;
                else return false;
            }
            else
            {
                return false;
            }
        }

        public static Boolean MetPagoValido(String Usr)
        {
            if (Usr != null)
            {
                String Resultado = "";
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                SqlDataAdapter da = new SqlDataAdapter("Select COUNT(nombreMet) AS DATA from tbMetPagos where Username = '" + Usr + "'", conx);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
                ds.Dispose();
                if (Resultado == "0") return false;
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

        public static void AgregarPersona(String nombre, String apellido, String email, String telefono, String Pais, String Provincia, String Canton, String Distrito, String Apartamento, String Zipcode, string Tipo_usuario)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("Insert INTO tbPersona ( nombre, " + " apellido, email, telefono, Pais, Provincia, Canton, Distrito, Apartamento, Zipcode, Tipo_usuario) values ( @nombre," + " @apellido, @email, @telefono, @Pais, @Provincia, @Canton, @Distrito, @Apartamento, @Zipcode, @Tipo_usuario) "))
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
                cmd.Parameters.AddWithValue("@Tipo_usuario", Tipo_usuario);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static void AgregarMetPago(String Username, String nombreMet, String NombreTar, String Emisor, String CodSeg, String NumTar)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("Insert INTO tbMetPagos ( Username, " + " nombreMet, NombreTar, Emisor, CodSeg, NumTar) values ( @Username," + " @nombreMet, @NombreTar, @Emisor, @CodSeg, @NumTar) "))
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@nombreMet", nombreMet);
                cmd.Parameters.AddWithValue("@NombreTar", NombreTar);
                cmd.Parameters.AddWithValue("@Emisor", Emisor);
                cmd.Parameters.AddWithValue("@CodSeg", CodSeg);
                cmd.Parameters.AddWithValue("@NumTar", NumTar);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static void EliminarMetPago(String Username, String nombreMet)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM tbMetPagos WHERE Username ='" + Username + "' AND nombreMet ='" + nombreMet + "'"))
            {
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

        public static void ActualizarDireccion(String Username, String nombreDir, String Pais, String Provincia, String Canton, String Distrito, String Apartamento, String Zipcode)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("UPDATE tbDireccion SET Pais = @Pais, Provincia = @Provincia, Canton = @Canton, Distrito = @Distrito, Apartamento = @Apartamento, Zipcode = @Zipcode WHERE Username ='" + Username + "' AND nombreDir ='" + nombreDir + "'"))
            {
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

        public static void EliminarDireccion(String Username, String nombreDir)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM tbDireccion WHERE Username ='" + Username + "' AND nombreDir ='" + nombreDir + "'"))
            {
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static void ActualizarPass(String Username, String Pass)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("UPDATE tbLogin SET Pass = @Pass WHERE Username ='" + Username + "'"))
            {
                cmd.Parameters.AddWithValue("@Pass", Pass);
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

        public static void agregaPedido(String usuario, String local, string producto, string costoProducto, string precioTotal)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            String id = obtenerUltimoIDPedido();
            using (SqlCommand cmd = new SqlCommand("Insert INTO Pedidos (ID, Mensajero, Usuario, Local, Producto, Costo_Producto, Precio_Total, Estado) values (@ID, @Mensajero, @Usuario, @Local, @Producto, @Costo_Producto, @Precio_Total, @Estado) "))
            {
                cmd.Parameters.AddWithValue("@ID", int.Parse(id) + 1);
                cmd.Parameters.AddWithValue("@Mensajero", 2);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Local", local);
                cmd.Parameters.AddWithValue("@Producto", producto);
                cmd.Parameters.AddWithValue("@Costo_Producto", costoProducto);
                cmd.Parameters.AddWithValue("@Precio_Total", precioTotal);
                cmd.Parameters.AddWithValue("@Estado", "Pendiente");
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static String obtenerUltimoIDPedido()
        {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select max(ID) AS DATA from Pedidos", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static void agregaProducto(String nombre, String desc, float precio, int tipo) {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            String id = obtenerUltimoIDProducto();
            using (SqlCommand cmd = new SqlCommand("Insert INTO Producto (ID, Nombre, Descripcion, Precio, Tipo) values (@ID, @Nombre, @Descripcion, @Precio, @Tipo) "))
            {
                cmd.Parameters.AddWithValue("@ID", int.Parse(id)+1);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", desc);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static String obtenerUltimoIDProducto() {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select max(ID) AS DATA from Producto", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static void modificaProducto(String ID, String nombre, String desc, float precio, int tipo)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("UPDATE Producto SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Tipo = @Tipo WHERE ID ='" + ID + "'"))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", desc);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static void eliminaProducto(String nombre, String ID)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Producto WHERE Nombre ='" + nombre + "' AND ID ='" + ID + "'"))
            {
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public static String retornaDescProducto(String nombre) {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select Descripcion AS DATA from Producto where Nombre ='" + nombre + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static String retornaPrecioProducto(String nombre)
        {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select Precio AS DATA from Producto where Nombre ='" + nombre + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static String retornaIDProducto(String nombre)
        {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select ID AS DATA from Producto where Nombre ='" + nombre + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static String RetornaPais(String Usr,String Dir)
        {

            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select Pais AS DATA from tbDireccion where nombreDir ='" + Dir + "' AND Username = '" + Usr + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static String RetornaProvincia(String Usr, String Dir)
        {

            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select Provincia AS DATA from tbDireccion where nombreDir ='" + Dir + "' AND Username = '" + Usr + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static String RetornaCanton(String Usr, String Dir)
        {

            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select Canton AS DATA from tbDireccion where nombreDir ='" + Dir + "' AND Username = '" + Usr + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static String RetornaDistrito(String Usr, String Dir)
        {

            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select Distrito AS DATA from tbDireccion where nombreDir ='" + Dir + "' AND Username = '" + Usr + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static String RetornaApartamento(String Usr, String Dir)
        {

            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select Apartamento AS DATA from tbDireccion where nombreDir ='" + Dir + "' AND Username = '" + Usr + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static String RetornaZipcode(String Usr, String Dir)
        {

            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select Zipcode AS DATA from tbDireccion where nombreDir ='" + Dir + "' AND Username = '" + Usr + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            return Resultado;
        }

        public static SqlDataReader RetornaTipoProducto() {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            conx.Open();
            SqlCommand cmd = new SqlCommand("Select Descripcion AS DATA from tipo_producto", conx);
            SqlDataReader sqlReader = cmd.ExecuteReader();
            return sqlReader;
        }
    }
}