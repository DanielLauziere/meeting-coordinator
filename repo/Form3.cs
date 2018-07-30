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
using System.Globalization;
using System.Resources;

namespace Meeting_Organizer
{
    public partial class Form3 : Form
    {

        ResourceManager res_man;    // declare Resource manager to access to specific cultureinfo
        CultureInfo cul;            // declare culture info

        public Form3()
        {
            InitializeComponent();

            int version = Settings.Default.Version;
            bool opened = Settings.Default.Splash;
            int type = Settings.Default.Type;
            if (opened) { checkBoxSplash.Checked = true; }

            string language = Settings.Default.Language;
            if (language.Equals("english")) { checkBoxEnglish.Checked = true; }
            else if (language.Equals("espanol")) { checkBoxEspanol.Checked = true; }
            else if (language.Equals("khmer")) { checkBoxKhmer.Checked = true; }
            else { checkBoxEnglish.Checked = true; }

            if (version == 0) { checkBoxFree.Checked = true; }
            else if (version == 1) { checkBoxBasic.Checked = true; }
            else if (version == 2) { checkBoxProfessional.Checked = true; }
            else if (version == 3) { checkBoxUltimate.Checked = true; }

            if (type == 1) { checkBoxLocal.Checked = true; }
            else if (type == 2) { checkBoxRemote.Checked = true; }




        }


        private void Form3_FormClosing(Object sender, FormClosingEventArgs e)
        {


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


            if (checkBoxEnglish.Checked) { Properties.Settings.Default["Language"] = "english"; }
            if (checkBoxEspanol.Checked) { Properties.Settings.Default["Language"] = "espanol"; }
            if (checkBoxKhmer.Checked) { Properties.Settings.Default["Language"] = "khmer"; }
            if (checkBoxSplash.Checked) { Properties.Settings.Default["Splash"] = true; Console.WriteLine("True"); }
            else { Properties.Settings.Default["Splash"] = false; Console.WriteLine("False"); }

            if (checkBoxLocal.Checked) { Properties.Settings.Default["Type"] = 1; }
            else if (checkBoxRemote.Checked) { Properties.Settings.Default["Type"] = 2; }


            Properties.Settings.Default.Save(); // Saves settings in application configuration file

            Console.WriteLine(Settings.Default.Splash);


            this.Close();
            Application.Restart();
            Environment.Exit(0);
        }



        private void checkBoxEnglish_Click(object sender, EventArgs e)
        {
            checkBoxEspanol.Checked = false;
            checkBoxKhmer.Checked = false;
        }
        private void checkBoxEspanol_Click(object sender, EventArgs e)
        {
            checkBoxEnglish.Checked = false;
            checkBoxKhmer.Checked = false;
        }
        private void checkBoxKhmer_Click(object sender, EventArgs e)
        {
            checkBoxEnglish.Checked = false;
            checkBoxEspanol.Checked = false;
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

        private void checkBoxLocal_Click (object sender, EventArgs e)
        {
            checkBoxRemote.Checked = false;
            checkBoxLocal.Checked = true;
        }
        private void checkBoxRemote_Click(object sender, EventArgs e)
        {
            checkBoxLocal.Checked = false;
            checkBoxRemote.Checked = true;
        }


    }
}
