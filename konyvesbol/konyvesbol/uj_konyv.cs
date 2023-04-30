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
    public partial class uj_konyv : Form
    {
        database Database = new database();
        public uj_konyv()
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
            konyvek insertKonyvek = new konyvek(1,textBox_szerzo.Text,textBox_cim.Text ,Convert.ToInt32(textBox_megev.Text),textBox_meghely.Text, textBox_kiado.Text,textBox_kate.Text,textBox_nyelv.Text,textBox_sorozat.Text,textBox_isbn.Text,Convert.ToInt32(textBox_ar.Text));
            if (Database.insertkonyv(insertKonyvek))
            {
                MessageBox.Show("Sikeres adatbevitel!");
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
                MessageBox.Show("Sikertelen adatbevitel!");
            }
            Program.konyvesbolt.konyvekBetoltese();
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_isbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_sorozat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nyelv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_kate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_kiado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_meghely_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_megev_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_cim_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_szerzo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
