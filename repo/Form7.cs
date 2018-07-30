using Meeting_Organizer.Properties;
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
    public partial class Form7 : Form
    {        int version = Settings.Default.Version;

        public Form7()
        {
            InitializeComponent();

            if (version == 0) { checkBoxFree.Checked = true; }
            else if (version == 1) { checkBoxBasic.Checked = true; }
            else if (version == 2) { checkBoxProfessional.Checked = true; }
            else if (version == 3) { checkBoxUltimate.Checked = true; }
        }



        private void checkBoxFree_Click(object sender, EventArgs e)
        {
            checkBoxBasic.Checked = false;
            checkBoxProfessional.Checked = false;
            checkBoxUltimate.Checked = false;
        }
        private void checkBoxBasic_Click(object sender, EventArgs e)
        {
            checkBoxFree.Checked = false;
            checkBoxProfessional.Checked = false;
            checkBoxUltimate.Checked = false;
        }
        private void checkBoxProfessional_Click(object sender, EventArgs e)
        {
            checkBoxFree.Checked = false;
            checkBoxBasic.Checked = false;
            checkBoxUltimate.Checked = false;
        }
        private void checkBoxUltimate_Click(object sender, EventArgs e)
        {
            checkBoxFree.Checked = false;
            checkBoxBasic.Checked = false;
            checkBoxProfessional.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string value = textBox1.Text;

            // Use ToCharArray to convert string to array.
            char[] array = value.ToCharArray();

            int total = 0;
            // Loop through array.
            for (int i = 0; i < array.Length; i++)
            {

                // Get character from array.
                char letter = array[i];
                int num = letter - '0';
                if (i % 2 != 0) { total = total + num; } else { total = total - num; }

            }


            //Console.WriteLine(total);

            if (array.Length == 16)
            {
                if (checkBoxFree.Checked) { Properties.Settings.Default["Version"] = 0; }
                if (total == -83)
                {
                    Properties.Settings.Default["Code"] = value;
                    if (checkBoxBasic.Checked) { Properties.Settings.Default["Version"] = 1; }
                }
                if (total == -479)
                {
                    Properties.Settings.Default["Code"] = value;
                    if (checkBoxProfessional.Checked) { Properties.Settings.Default["Version"] = 2; }
                }
                if (total == 450)
                {
                    Properties.Settings.Default["Code"] = value;
                    if (checkBoxUltimate.Checked) { Properties.Settings.Default["Version"] = 3; }
                }
            }


            Properties.Settings.Default.Save(); // Saves settings in application configuration file

            Console.WriteLine(Settings.Default.Splash);


            this.Close();
            Application.Restart();
            Environment.Exit(0);








        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Type"] = 0;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file

            Console.WriteLine(Settings.Default.Splash);


            this.Close();
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
