﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Language"] = "english";
            Properties.Settings.Default["First_open"] = false;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            this.Close();
            Application.Restart();
            Environment.Exit(0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Language"] = "espanol";
            Properties.Settings.Default["First_open"] = false;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            this.Close();
            Application.Restart();
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Language"] = "khmer";
            Properties.Settings.Default["First_open"] = false;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            this.Close();
            Application.Restart();
            Environment.Exit(0);
        }




    }
}
