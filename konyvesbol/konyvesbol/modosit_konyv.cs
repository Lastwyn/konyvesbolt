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
    public partial class modosit_konyv : Form
    {
        database Database = new database();
        public modosit_konyv()
        {
            InitializeComponent();
        }
        private bool HianyzoAdat()
        {
            if (string.IsNullOrEmpty(textBox_cim.Text))
            {
                MessageBox.Show("Adja meg a könyv címét!");
                textBox_cim.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_szerzo.Text))
            {
                MessageBox.Show("Adja meg a szerző nevét!");
                textBox_szerzo.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_megev.Text))
            {
                MessageBox.Show("Adja meg a megjelenés évét!");
                textBox_megev.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_meghely.Text))
            {
                MessageBox.Show("Adja meg a megjelenés helyét!");
                textBox_meghely.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_kiado.Text))
            {
                MessageBox.Show("Adja meg a kiadót!");
                textBox_kiado.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_kate.Text))
            {
                MessageBox.Show("Adja meg a kategóriát!");
                textBox_kate.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_nyelv.Text))
            {
                MessageBox.Show("Adja meg a nyelvet!");
                textBox_nyelv.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_sorozat.Text))
            {
                MessageBox.Show("Adja meg a sorozatcímet!");
                textBox_sorozat.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_isbn.Text))
            {
                MessageBox.Show("Adja meg az ISBN-t!");
                textBox_isbn.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_ar.Text))
            {
                MessageBox.Show("Adja meg az árát!");
                textBox_ar.Focus();
                return true;
            }

            return false;
        }
        private void ujkonyv_Click(object sender, EventArgs e)
        {

            if (HianyzoAdat())
            {
                return;
            }
            konyvek updateKonyvek = new konyvek(1, textBox_szerzo.Text, textBox_cim.Text, Convert.ToInt32(textBox_megev.Text), textBox_meghely.Text, textBox_kiado.Text, textBox_kate.Text, textBox_nyelv.Text, textBox_sorozat.Text, textBox_isbn.Text, Convert.ToInt32(textBox_ar.Text));
            if (Database.updatekonyv(updateKonyvek))
            {
                MessageBox.Show("Sikeres adatmódosítás!");
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
                MessageBox.Show("Sikertelen adatmódosítás!");
            }
            Program.konyvesbolt.konyvekBetoltese();
            Close();
        }

        private void modosit_konyv_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.konyvesbolt.listBox_konyvek.Text + " adatainak a módositása");
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
            textBox_isbn.Text =  Convert.ToString(ja.Isbn);
            textBox_ar.Text =  Convert.ToString(ja.Ar);
        }
    }
}
