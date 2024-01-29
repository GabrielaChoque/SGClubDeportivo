using SGClubDeportivo.Vista;
using SGClubDeportivo.Vista.Gestiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubDeportivo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new frmGestionMensualidades());
            //Application.Run(new frmGestionInscripciones());
            //Application.Run(new frmGestionJugadors());
            //Application.Run(new frmPrincipalSecretario());
            Application.Run(new frmGestionGuiaPrecios());
        }
    }
}
