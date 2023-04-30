using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace konyvesbol
{
    class database
    {
        static public MySqlCommand command;
        static public MySqlConnection connection;

        public database(string server = "localhost", string user = "root", string password = "", string db = "konyvesbolt_kesz")
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            builder.AllowZeroDateTime = true;
            connection = new MySqlConnection(builder.ConnectionString);
            if (Kapcsolatok())
            {
                command = connection.CreateCommand();
            }
        }
        private bool Kapcsolatok()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<konyvek> getAllkonyv()
        {
            List<konyvek> list = new List<konyvek>();
            command.CommandText = "SELECT * FROM konyv;";
            connection.Open();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    konyvek Konyvek = new konyvek(dr.GetInt32("konyvid"), dr.GetString("szerzo"), dr.GetString("cim"), dr.GetInt32("megjelenesi_ev"), dr.GetString("megjelenes_helye"), dr.GetString("kiado"),
                        dr.IsDBNull(6) ? "" : dr.GetString("kategoria"), dr.GetString("nyelv"),
                        dr.IsDBNull(8) ? "" : dr.GetString("sorozatcim"), dr.GetString("isbn"), dr.GetInt32("ar"));
                    list.Add(Konyvek);
                }
            }
            connection.Close();
            return list;
        }
        public List<vasarlok> getAllvasarlo()
        {
            List<vasarlok> vlist = new List<vasarlok>();
            command.CommandText = "SELECT * FROM vasarlo;";
            connection.Open();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    vasarlok Vasarlok = new vasarlok(dr.GetInt32("vasarloid"), dr.GetString("nev"), DateTime.Parse(dr.GetString("szuletesi_datum")), dr.GetString("email_cim"), dr.GetString("felhasznalonev"), dr.GetString("jelszo"));
                    vlist.Add(Vasarlok);
                 
                }
            }
            connection.Close();
            return vlist;
        }

        public List<vasarlasok> getAllvasarlas()
        {
            List<vasarlasok> valist = new List<vasarlasok>();
            command.CommandText = "SELECT `datum`,vasarlo.nev,konyv.cim,`darab` FROM `vasarlas` INNER JOIN konyv ON konyv.konyvid = vasarlas.konyvID INNER JOIN vasarlo ON vasarlas.vasarloID = vasarlo.vasarloid WHERE vasarlo.vasarloid=vasarlas.vasarloID ;";
            connection.Open();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    vasarlasok Vasarlasok = new vasarlasok(dr.GetDateTime("datum"),dr.GetString("nev"), dr.GetString("cim"),dr.GetInt32("darab"));
                    valist.Add(Vasarlasok);

                }
            }
            connection.Close();
            return valist;
        }

        public bool insertkonyv(konyvek insertKonyvek)
        {
            command.CommandText = "INSERT INTO `konyv`(`konyvid`, `szerzo`, `cim`, `megjelenesi_ev`, `megjelenes_helye`, `kiado`, `kategoria`, `nyelv`, `sorozatcim`, `isbn`, `ar`) VALUES (null,@szerzo,@cim,@megev,@meghely,@kiado,@kate,@nyelv,@sorozat,@isbn,@ar);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@szerzo", Program.Uj_Konyv.textBox_szerzo.Text);
            command.Parameters.AddWithValue("@cim", Program.Uj_Konyv.textBox_cim.Text);
            command.Parameters.AddWithValue("@megev", Program.Uj_Konyv.textBox_megev.Text);
            command.Parameters.AddWithValue("@meghely", Program.Uj_Konyv.textBox_meghely.Text);
            command.Parameters.AddWithValue("@kiado", Program.Uj_Konyv.textBox_kiado.Text);
            command.Parameters.AddWithValue("@kate", Program.Uj_Konyv.textBox_kate.Text);
            command.Parameters.AddWithValue("@nyelv", Program.Uj_Konyv.textBox_nyelv.Text);
            command.Parameters.AddWithValue("@sorozat", Program.Uj_Konyv.textBox_sorozat.Text);
            command.Parameters.AddWithValue("@isbn", Program.Uj_Konyv.textBox_isbn.Text);
            command.Parameters.AddWithValue("@ar", Program.Uj_Konyv.textBox_ar.Text);


            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool updatekonyv(konyvek updateKonyvek)
        {

            command.CommandText = "UPDATE konyv SET szerzo=@szerzo, cim=@cim,megjelenesi_ev=@megev,megjelenes_helye=@meghely,kiado=@kiado,kategoria=@kate,nyelv=@nyelv,sorozatcim=@sorozat,isbn=@isbn,ar=@ar WHERE konyvid = @konyvid ;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@konyvid", Program.Modosit_Konyv.textBox_konyvid.Text);
            command.Parameters.AddWithValue("@szerzo", Program.Modosit_Konyv.textBox_szerzo.Text);
            command.Parameters.AddWithValue("@cim", Program.Modosit_Konyv.textBox_cim.Text);
            command.Parameters.AddWithValue("@megev", Program.Modosit_Konyv.textBox_megev.Text);
            command.Parameters.AddWithValue("@meghely", Program.Modosit_Konyv.textBox_meghely.Text);
            command.Parameters.AddWithValue("@kiado", Program.Modosit_Konyv.textBox_kiado.Text);
            command.Parameters.AddWithValue("@kate", Program.Modosit_Konyv.textBox_kate.Text);
            command.Parameters.AddWithValue("@nyelv", Program.Modosit_Konyv.textBox_nyelv.Text);
            command.Parameters.AddWithValue("@sorozat", Program.Modosit_Konyv.textBox_sorozat.Text);
            command.Parameters.AddWithValue("@isbn", Program.Modosit_Konyv.textBox_isbn.Text);
            command.Parameters.AddWithValue("@ar", Program.Modosit_Konyv.textBox_ar.Text);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool deleteKonyv(konyvek deletekonyvek)
        {

            command.CommandText = "DELETE FROM konyv WHERE `konyvid`=@id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Program.Torles_Konyv.textBox_konyvid.Text);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool insertvasarlok(vasarlok insertVasarlok)
        {
            command.CommandText = "INSERT INTO `vasarlo`(`vasarloid`, `nev`, `szuletesi_datum`, `email_cim`, `felhasznalonev`, `jelszo`) VALUES(null, @nev, @szuletesi_datum, @email_cim, @felhasznalonev, @jelszo); ";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", Program.Uj_Vasarlo.textBox_nev.Text);
            command.Parameters.AddWithValue("@szuletesi_datum", Program.Uj_Vasarlo.dateTimePicker1.Value.Date);
            command.Parameters.AddWithValue("@email_cim", Program.Uj_Vasarlo.textBox_email.Text);
            command.Parameters.AddWithValue("@felhasznalonev", Program.Uj_Vasarlo.textBox_felhasznalonev.Text);
            command.Parameters.AddWithValue("@jelszo", Program.Uj_Vasarlo.textBox_jelszo.Text);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool updatevasarlok(vasarlok updateVasarlok)
        {

            command.CommandText = "UPDATE `vasarlo` SET nev = @nev, szuletesi_datum = @szuletesi_datum, email_cim = @email_cim, felhasznalonev =@felhasznalonev, jelszo = @jelszo WHERE vasarloid = @vasarloid;  ";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@vasarloid", Program.Modosit_Vasarlo.textBox_vasarloid.Text);
            command.Parameters.AddWithValue("@nev", Program.Modosit_Vasarlo.textBox_nev.Text);
            command.Parameters.AddWithValue("@szuletesi_datum", Program.Modosit_Vasarlo.dateTimePicker1.Value.Date);
            command.Parameters.AddWithValue("@email_cim", Program.Modosit_Vasarlo.textBox_email.Text);
            command.Parameters.AddWithValue("@felhasznalonev", Program.Modosit_Vasarlo.textBox_felhasznalonev.Text);
            command.Parameters.AddWithValue("@jelszo", Program.Modosit_Vasarlo.textBox_jelszo.Text);


            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public bool deletevasarlo(vasarlok deletevasarlo)
        {

            command.CommandText = "DELETE FROM vasarlo WHERE `vasarloid`=@id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Program.Torles_Vasarlo.textBox_vasarloid.Text);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }
}
