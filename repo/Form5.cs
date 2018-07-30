using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Organizer
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["type"] = 1;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            this.Close();
            Application.Restart();
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["type"] = 2;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            this.Close();
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
