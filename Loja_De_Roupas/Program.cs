using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_De_Roupas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //na Program.cs ela chama o Form1.cs e tem que mudar isso para login
            Application.Run(new Login());
            //criar outro método para o usuarioDAO
            //if(dr.HasRows)
            //   retur true;
        }
    }
}
