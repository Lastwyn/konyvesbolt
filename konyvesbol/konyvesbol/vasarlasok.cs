using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvesbol
{
    class vasarlasok
    {
        DateTime datum;
        string nev;
        string cim;
        int darab;

        public DateTime Datum { get => datum; set => datum = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Darab { get => darab; set => darab = value; }

        public vasarlasok(DateTime datum, string nev, string cim, int darab)
        {
            this.datum = datum;
            this.nev = nev;
            this.cim = cim;
            this.darab = darab;
        }

        public override string ToString()
        {
            return $"{datum} || {nev} || {cim} || {darab}";
        }
    }
}
