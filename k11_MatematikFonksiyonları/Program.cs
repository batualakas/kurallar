using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k11_MatematikFonksiyonları
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ////Application.Run(new MatematikFonksiyonları());
            //Application.Run(new StringFonkisyonlar());
            Application.Run(new DateTimeFonksiyonlar());
        }
    }
}
