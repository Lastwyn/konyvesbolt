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
    public partial class uj_vasarlo : Form
    {
        database Database = new database();
        public uj_vasarlo()
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
        private void uj_vasarlo_Load(object sender, EventArgs e)
        {
           
        }

        private void ujvasarlo_Click(object sender, EventArgs e)
        {
            if (HianyzoAdat())
            {
                return;
            }
                   
                vasarlok insertVasarlok = new vasarlok(1, textBox_nev.Text, dateTimePicker1.Value.Date, textBox_email.Text, textBox_felhasznalonev.Text, textBox_jelszo.Text);
                if (Database.insertvasarlok(insertVasarlok))
                {
                    MessageBox.Show("Sikeres adatbevitel!");
                    textBox_nev.Text = "";
                    dateTimePicker1.Text = "";
                    textBox_email.Text = "";
                    textBox_felhasznalonev.Text = "";
                    textBox_jelszo.Text = "";

                }
                else
                {
                    MessageBox.Show("Sikertelen adatbevitel!");
                }
      
            Program.konyvesbolt.vasarlokBetoltese();
            Close();
        }
    }
}
