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
    public partial class Könyvesbolt : Form
    {
        database Database = new database();
        public Könyvesbolt()
        {
            InitializeComponent();
        }


        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Uj_Konyv.ShowDialog();
            konyvekBetoltese();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Modosit_Konyv.ShowDialog();
            konyvekBetoltese();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Torles_Konyv.ShowDialog();
            konyvekBetoltese();
        }

        private void újToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.Uj_Vasarlo.ShowDialog();
            vasarlokBetoltese();
        }

        private void módosításToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.Modosit_Vasarlo.ShowDialog();
            vasarlokBetoltese();
        }

        private void vásárlásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Könyvesbolt_Load(object sender, EventArgs e)
        {
            konyvekBetoltese();
            vasarlokBetoltese();
        }

        public void konyvekBetoltese()
        {
            listBox_konyvek.Items.Clear();
            foreach (konyvek item in Database.getAllkonyv())
            {
                listBox_konyvek.Items.Add(item);
            }
        }

        public void vasarlokBetoltese()
        {
            listBox_vasarlok.Items.Clear();
            foreach (vasarlok item in Database.getAllvasarlo())
            {
                listBox_vasarlok.Items.Add(item);
            }
        }
      

        private void törlésToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.Torles_Vasarlo.ShowDialog();
            vasarlokBetoltese();
        }

        private void megtekintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Megtekint.ShowDialog();

        }
    }
}
