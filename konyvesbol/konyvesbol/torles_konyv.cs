using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konyvesbol
{
    public partial class torles_konyv : Form
    {
        database Database = new database();
        public torles_konyv()
        {
            InitializeComponent();
        }

        private void ujkonyv_Click(object sender, EventArgs e)
        {
            konyvek deleteKonyvek = new konyvek(1, textBox_szerzo.Text, textBox_cim.Text, Convert.ToInt32(textBox_megev.Text), textBox_meghely.Text, textBox_kiado.Text, textBox_kate.Text, textBox_nyelv.Text, textBox_sorozat.Text, textBox_isbn.Text, Convert.ToInt32(textBox_ar.Text));
            if (Database.deleteKonyv(deleteKonyvek))
            {
                MessageBox.Show("Sikeres Törlés!");
                textBox_szerzo.Text = "";
                textBox_cim.Text = "";
                textBox_megev.Text = "";
                textBox_meghely.Text = "";
                textBox_kiado.Text = "";
                textBox_kate.Text = "";
                textBox_nyelv.Text = "";
                textBox_sorozat.Text = "";
                textBox_isbn.Text = "";
                textBox_ar.Text = "";

            }
            else
            {
                MessageBox.Show("Sikertelen Törlés!");
            }
            Program.konyvesbolt.konyvekBetoltese();
            Close();
        }

        private void torles_konyv_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.konyvesbolt.listBox_konyvek.Text + " adatainak a törlése!");
            konyvek ja = (konyvek)Program.konyvesbolt.listBox_konyvek.SelectedItem;
            textBox_konyvid.Text = Convert.ToString(ja.Konyvid);
            textBox_szerzo.Text = Convert.ToString(ja.Szerzo);
            textBox_cim.Text = Convert.ToString(ja.Cim);
            textBox_megev.Text = Convert.ToString(ja.Megjelenesi_ev);
            textBox_meghely.Text = Convert.ToString(ja.Megjelenes_helye);
            textBox_kiado.Text = Convert.ToString(ja.Kiado);
            textBox_kate.Text = Convert.ToString(ja.Kategoria);
            textBox_nyelv.Text = Convert.ToString(ja.Nyelv);
            textBox_sorozat.Text = Convert.ToString(ja.Sorozatcim);
            textBox_isbn.Text = Convert.ToString(ja.Isbn);
            textBox_ar.Text = Convert.ToString(ja.Ar);
        }
    }
}
