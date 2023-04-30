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
    public partial class torles_vasarlo : Form
    {
        database Database = new database();
        public torles_vasarlo()
        {
            InitializeComponent();
        }

        private void vasarlotorles_Click(object sender, EventArgs e)
        {
            vasarlok torlesVasarlok = new vasarlok(1, textBox_nev.Text, dateTimePicker1.Value.Date, textBox_email.Text, textBox_felhasznalonev.Text, textBox_jelszo.Text);
            if (Database.deletevasarlo(torlesVasarlok))
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

        private void torles_vasarlo_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.konyvesbolt.listBox_vasarlok.Text + " adatainak törlése");
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
