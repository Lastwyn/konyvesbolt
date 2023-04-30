using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace konyvesbol
{
    class konyvek
    {
        int konyvid;
        string szerzo;
        string cim;
        int megjelenesi_ev;
        string megjelenes_helye;
        string kiado;
        string kategoria;
        string nyelv;
        string sorozatcim;
        string isbn;
        int ar;

        public int Konyvid { get => konyvid; set => konyvid = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Megjelenesi_ev { get => megjelenesi_ev; set => megjelenesi_ev = value; }
        public string Megjelenes_helye { get => megjelenes_helye; set => megjelenes_helye = value; }
        public string Kiado { get => kiado; set => kiado = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public string Nyelv { get => nyelv; set => nyelv = value; }
        public string Sorozatcim { get => sorozatcim; set => sorozatcim = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Ar { get => ar; set => ar = value; }

        public konyvek(int konyvid, string szerzo, string cim, int megjelenesi_ev, string megjelenes_helye, string kiado, string kategoria, string nyelv, string sorozatcim, string isbn, int ar)
        {
            this.konyvid = konyvid;
            this.szerzo = szerzo;
            this.cim = cim;
            this.megjelenesi_ev = megjelenesi_ev;
            this.megjelenes_helye = megjelenes_helye;
            this.kiado = kiado;
            this.kategoria = kategoria;
            this.nyelv = nyelv;
            this.sorozatcim = sorozatcim;
            this.isbn = isbn;
            this.ar = ar;
        }
        public override string ToString()
        {
            return $"{szerzo} || {cim} || {ar}";
        }
    }
}
