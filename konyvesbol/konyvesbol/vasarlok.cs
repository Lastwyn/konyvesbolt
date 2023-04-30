using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace konyvesbol
{
    class vasarlok
    {
        int vasarloid;
        string nev;
        DateTime szuletesi_datum;
        string email_cim;
        string felhasznalonev;
        string jelszo;

        public int Vasarloid { get => vasarloid; set => vasarloid = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletesi_datum { get => szuletesi_datum; set => szuletesi_datum = value; }
        public string Email_cim { get => email_cim; set => email_cim = value; }
        public string Felhasznalonev { get => felhasznalonev; set => felhasznalonev = value; }
        public string Jelszo { get => jelszo; set => jelszo = value; }

        public vasarlok(int vasarloid, string nev, DateTime szuletesi_datum, string email_cim, string felhasznalonev, string jelszo)
        {
            this.vasarloid = vasarloid;
            this.nev = nev;
            this.szuletesi_datum = szuletesi_datum;
            this.email_cim = email_cim;
            this.felhasznalonev = felhasznalonev;
            this.jelszo = jelszo;
        }
        public override string ToString()
        {
            return $"{felhasznalonev} || {email_cim}";
        }
    }
}
