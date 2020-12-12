using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing_Project.Accesos.Admin;
using Testing_Project.Usuarios;
using Testing_Project.Usuarios.Cliente;

namespace Testing_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLTransact.Login_autorizado = false;
            SQLTransact.Tipo_Acceso = "";
            SQLTransact.Usuario_Activo = "";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());

            if (SQLTransact.Login_autorizado)
            {
                if (SQLTransact.Tipo_Acceso.Contains("Empresarial"))
                { Application.Run(new FrmPrincipalEmpresarial()); }
                else if (SQLTransact.Tipo_Acceso.Contains("Mensajero"))
                { Application.Run(new FrmPrincipalMensajero()); }
                else if (SQLTransact.Tipo_Acceso.Contains("Usuario"))
                { Application.Run(new FrmPrincipalUsuario()); }
                else
                { Application.Run(new Admin()); }
            }
        }
    }
}
