using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sinema_bilet_satisi_EN_SON
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
            Application.Run(new Baslangıc_Formu());
        }
    }
}
