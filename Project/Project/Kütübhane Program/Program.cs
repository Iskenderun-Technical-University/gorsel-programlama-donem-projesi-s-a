using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütübhane_Program
{
    static class Program
    {
        public static Home home;
        public static ROMANLAR romanlar;
        public static ÇOCUK_KİTAPLARI cocukkitap;
        public static Tarih tarih;
        public static Psikolojik psikolojik;
        public static int adet = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            home = new Home();
            romanlar = new ROMANLAR();
            cocukkitap = new ÇOCUK_KİTAPLARI();
            tarih = new Tarih();
            psikolojik = new Psikolojik();
            Application.Run(home);
        }
    }
}
