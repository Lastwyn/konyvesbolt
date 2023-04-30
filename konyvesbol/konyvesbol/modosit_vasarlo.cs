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
    public partial class modosit_vasarlo : Form
    {
        database Database = new database();
        public modosit_vasarlo()
        {
            InitializeComponent();
        }
        private bool HianyzoAdat()
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Adja meg a nevét!");
                textBox_nev.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Adja meg a szuletési dátumot!");
                dateTimePicker1.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_email.Text))
            {
                MessageBox.Show("Adja meg az Email címet!");
                textBox_email.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_felhasznalonev.Text))
            {
                MessageBox.Show("Adja meg a felhasználó nevét!");
                textBox_felhasznalonev.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_jelszo.Text))
            {
                MessageBox.Show("Adja meg a jelszavát!");
                textBox_jelszo.Focus();
                return true;
            }

            return false;
        }
        private void vasarlomodositas_Click(object sender, EventArgs e)
        {
            if (HianyzoAdat())
            {
                return;
            }
                vasarlok updateVasarlok = new vasarlok(1, textBox_nev.Text, dateTimePicker1.Value.Date, textBox_email.Text, textBox_felhasznalonev.Text, textBox_jelszo.Text);
                if (Database.updatevasarlok(updateVasarlok))
                {
                    MessageBox.Show("Sikeres módosítás!");
                    textBox_nev.Text = "";
                dateTimePicker1.Text = "";
                    textBox_email.Text = "";
                    textBox_felhasznalonev.Text = "";
                    textBox_jelszo.Text = "";

                }
                else
                {
                    MessageBox.Show("Sikertelen  módosítás!");
                }
                Program.konyvesbolt.vasarlokBetoltese();
                Close();
            
        }

        private void modosit_vasarlo_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.konyvesbolt.listBox_vasarlok.Text + " adatainak a módositása");
            vasarlok ja = (vasarlok)Program.konyvesbolt.listBox_vasarlok.SelectedItem;
            textBox_vasarloid.Text = Convert.ToString(ja.Vasarloid);
            textBox_nev.Text = Convert.ToString(ja.Nev);
            dateTimePicker1.Text = Convert.ToString(ja.Szuletesi_datum.Date);
            textBox_email.Text = Convert.ToString(ja.Email_cim);
            textBox_felhasznalonev.Text = Convert.ToString(ja.Felhasznalonev);
            textBox_jelszo.Text = Convert.ToString(ja.Jelszo);
        }
    }
}
