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
    public partial class megtekint : Form
    {
        database Database = new database();
        public megtekint()
        {
            InitializeComponent();
        }

        private void megtekint_Load(object sender, EventArgs e)
        {
                listBox_megtekint.Items.Clear();
                foreach (vasarlasok item in Database.getAllvasarlas())
                {
                   listBox_megtekint.Items.Add(item);
                }
        }

        private void button_vissza_Click(object sender, EventArgs e)
        {
            Program.Megtekint.Close();
        }
    }
}
