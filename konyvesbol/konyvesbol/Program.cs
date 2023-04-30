using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konyvesbol
{
    static class Program
    {
        static public uj_konyv Uj_Konyv = new uj_konyv();
        static public Könyvesbolt konyvesbolt = new Könyvesbolt();
        static public modosit_konyv Modosit_Konyv = new modosit_konyv();
        static public torles_konyv Torles_Konyv = new torles_konyv();
        static public uj_vasarlo Uj_Vasarlo = new uj_vasarlo();
        static public modosit_vasarlo Modosit_Vasarlo = new modosit_vasarlo();
        static public torles_vasarlo Torles_Vasarlo = new torles_vasarlo();
        static public megtekint Megtekint = new megtekint();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(konyvesbolt);
        }
    }
}
