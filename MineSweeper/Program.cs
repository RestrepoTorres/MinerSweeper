using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MatrizEnTripleta mat = new MatrizEnTripleta(new Tripleta(3, 3, 0));
            mat.generarMinas(5);
            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Menu menu = new Menu(mat.muestraMatrizEnTripletas());
            Application.Run(menu);
            
        }
    }
}
