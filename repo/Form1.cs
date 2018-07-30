using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CefSharp.WinForms;
using System.IO;
using Meeting_Organizer.Properties;
using System.Globalization;
using System.Resources;
using System.Collections;

namespace Meeting_Organizer
{


    public partial class Form1 : Form

    {



        Form3 frm3 = null;
        int version = Settings.Default.Version;
        bool opened = Settings.Default.First_open;
        string code = Settings.Default.Code;

        bool splash = Settings.Default.Splash;
        string language = Settings.Default.Language;

        

        public ChromiumWebBrowser SecurityCamBrowser;
        public ChromiumWebBrowser MeetingBroadcastBrowser;
        public ChromiumWebBrowser RecieveBrowser;

        public PictureBox SplashBox;



        Image mySplashScreen = Properties.Resources.splash;



        bool isVideo = false;
        bool isPicture = false;

        bool Frm2isBrowser = false;
        bool Frm2isVideo = false;
        bool Frm2isPicture = false;
        bool Frm2isSecurity = false;

        Form2 frm = null;

        public int imageIndex = 0;
        public string[] images;
        public int t = 0;
        string ext2 = "";







        public Form1()
        {



            Console.WriteLine(language);
            Console.WriteLine("True or False: {0}", splash);

            /*
            if (language.Equals("english")) { Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en"); }
            else if (language.Equals("espanol")) { Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es"); }
            else if (language.Equals("khmer")) { Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("km"); }
            */

            if (!opened) {

            }

            InitializeComponent();

            if (version == 3) { this.Text = Strings.meetingcoordinatorultimate; }
            else if (version == 2) { this.Text = Strings.meetingcoordinatroprofessional; }
            else if (version == 1) { this.Text = Strings.meetingcoordinatorbasic; }
            else{ this.Text = Strings.meetingcoordinatorfree; }

            this.splitContainer4.SplitterDistance = 40;
            this.splitContainer5.SplitterDistance = 40;
            this.splitContainer6.SplitterDistance = 40;
            this.splitContainer7.SplitterDistance = 40;
            this.splitContainer8.SplitterDistance = 40;

            this.label1.Text = Strings.opensomething;

            
            button4.Enabled = false;
            button5.Enabled = false;

            if (version == 0) {
                SecurityCamBrowser = new ChromiumWebBrowser("about_blank");
                MeetingBroadcastBrowser = new ChromiumWebBrowser("about_blank");
                RecieveBrowser = new ChromiumWebBrowser("about_blank");
            }
            else
            {
                SecurityCamBrowser = new ChromiumWebBrowser("about_blank");
                MeetingBroadcastBrowser = new ChromiumWebBrowser("https://blueskydeveloper.com/rtc-meeting-coordinator/meetingswitch.php?name=" + code);
                RecieveBrowser = new ChromiumWebBrowser("https://blueskydeveloper.com/rtc-meeting-coordinator/recievesvaing.php?name=" + code);
                splitContainer7.Panel2.Controls.Add(SecurityCamBrowser);
                splitContainer4.Panel2.Controls.Add(MeetingBroadcastBrowser);
                splitContainer5.Panel2.Controls.Add(RecieveBrowser);
            }




            if (frm == null)
                {
                    frm = new Form2();
                }
                else
                {
                    frm.Close();
                    frm = new Form2();
                }
                place_splash(splash);
            

        }




        private void Form1_Resize(object sender, System.EventArgs e)
        {
            // only resize if 
            if (this.WindowState != FormWindowState.Minimized)
            {

                Control control = (Control)sender;
                // Minimum window size 
                if (control.Size.Height < 250) { Height = 249; }
                if (control.Size.Width < 200) { Width = 199; }



                // Ensure the Form remains square (Height = Width).
                //if (control.Size.Height != control.Size.Width)
                //{ control.Size = new Size(control.Size.Width, control.Size.Width);}
                int dif = 0;
                int pers = 0;
                if (control.Size.Height < control.Size.Width) { dif = control.Size.Width - control.Size.Height; pers = control.Size.Width / control.Size.Height; }
                else { dif = control.Size.Height - control.Size.Width; pers = control.Size.Height / control.Size.Width; pers = pers + 2; }


                if (pers < 3)
                {


                    this.splitContainer1.Orientation = Orientation.Vertical;
                    this.splitContainer2.Orientation = Orientation.Horizontal;
                    this.splitContainer3.Orientation = Orientation.Horizontal;



                    this.splitContainer1.SplitterDistance = this.Size.Width / 2;
                    this.splitContainer2.SplitterDistance = this.Size.Height / 2;
                    this.splitContainer3.SplitterDistance = this.Size.Height / 2;

                    /*
                    this.button2.Location = new Point(3, 40);
                    this.button3.Location = new Point(3, 80);
                    this.button4.Location = new Point(3, 120);
                    this.button5.Location = new Point(3, 160);
                    this.button6.Location = new Point(3, 200);
                    this.button7.Location = new Point(3, 240);
                    this.button8.Location = new Point(3, 280);
                    this.button9.Location = new Point(3, 320);
                    */

                }
                else if (control.Size.Height > control.Size.Width)
                {
                    this.splitContainer1.Orientation = Orientation.Horizontal;
                    this.splitContainer2.Orientation = Orientation.Horizontal;
                    this.splitContainer3.Orientation = Orientation.Horizontal;
                    
                    this.splitContainer1.SplitterDistance = this.Size.Height / 2;
                    this.splitContainer2.SplitterDistance = this.Size.Height / 4;
                    this.splitContainer3.SplitterDistance = this.Size.Height / 4;

                    /*
                    this.button2.Location = new Point(3, 40);
                    this.button3.Location = new Point(3, 80);
                    this.button4.Location = new Point(3, 120);
                    this.button5.Location = new Point(3, 160);
                    this.button6.Location = new Point(3, 200);
                    this.button7.Location = new Point(3, 240);
                    this.button8.Location = new Point(3, 280);
                    this.button9.Location = new Point(3, 320);
                    */




                }
                else if (control.Size.Height < control.Size.Width)
                {
                    this.splitContainer1.Orientation = Orientation.Vertical;
                    this.splitContainer2.Orientation = Orientation.Vertical;
                    this.splitContainer3.Orientation = Orientation.Vertical;
                    this.splitContainer1.SplitterDistance = this.Size.Width / 2;
                    this.splitContainer2.SplitterDistance = this.Size.Width / 4;
                    this.splitContainer3.SplitterDistance = this.Size.Width / 4;
                    /*
                    this.button2.Location = new Point(40, 3);
                    this.button3.Location = new Point(80, 3);
                    this.button4.Location = new Point(120, 3);
                    this.button5.Location = new Point(160, 3);
                    this.button6.Location = new Point(200, 3);
                    this.button7.Location = new Point(240, 3);
                    this.button8.Location = new Point(280, 3);
                    this.button9.Location = new Point(320, 3);
                    */
                }
                this.splitContainer4.SplitterDistance = 40;
                this.splitContainer5.SplitterDistance = 40;
                this.splitContainer6.SplitterDistance = 40;
                this.splitContainer7.SplitterDistance = 40;
                this.splitContainer8.SplitterDistance = 40;


            }

        }

        ToolTip toolTip1;


        private void tt(object sender, EventArgs e)
        {
            Button button = sender as Button;

            String name = button.Name;

            String tooltip = "";

            if (name.Equals("button1")) { tooltip = Strings.button1; }
            else if (name.Equals("button2")) { tooltip = Strings.button2; }
            else if (name.Equals("button3")) { tooltip = Strings.button3; }
            else if (name.Equals("button4")) { tooltip = Strings.button4; }
            else if (name.Equals("button5")) { tooltip = Strings.button5; }
            else if (name.Equals("button6")) { tooltip = Strings.button6; }
            else if (name.Equals("button7")) { tooltip = Strings.button7; }
            else if (name.Equals("button8")) { tooltip = Strings.button8; }
            else if (name.Equals("button9")) { tooltip = Strings.button9; }
            else if (name.Equals("button10")) { tooltip = Strings.button10; }
            else if (name.Equals("button11")) { tooltip = Strings.button11; }
            else if (name.Equals("button12")) { tooltip = Strings.button12; }
            else if (name.Equals("button13")) { tooltip = Strings.button13; }
            else if (name.Equals("button14")) { tooltip = Strings.button14; }

            this.label1.Text = tooltip;

           //toolTip1.SetToolTip(button, "Back One Page");

        }


        private void button_MouseEnter(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            //btn.BackColor = SystemColors.ButtonHighlight;
            //btn.BackColor = Color.DarkGray;
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            //btn.BackColor = SystemColors.ButtonHighlight;
            //btn.BackColor = SystemColors.Info;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //            openFileDialog1.Filter = "Pic or Vid(*.jpg, *.jpeg, *.gif, *.tiff, *.bmp, *.png, *.mp4, *.avi, *.flv, *.wmv, *.mov) | *.jpg, *.jpeg, *.gif, *.tiff, *.bmp, *.png, *.mp4, *.avi, *.flv, *.wmv, *.mov";
            openFileDialog1.Filter = "Pic or Vid(*.jpg, *.jpeg, *.gif, *.tiff, *.bmp, *.png, *.mp4, *.avi, *.flv, *.wmv, *.mov) | *.jpg; *.jpeg; *.gif; *.tiff; *.bmp; *.png; *.mp4; *.avi; *.flv; *.wmv; *.mov";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string text = openFileDialog1.FileName;
                string newfile = text.Replace(@"\", "/");

                /*
                if (frm == null)
                {
                    frm = new Form2();

                }
                else
                {
                    frm.Close();
                    frm = new Form2();
                }
                place_splash();
                */



                string ext = Path.GetExtension(openFileDialog1.FileName);
                Console.WriteLine(ext);
                if (ext == ".JPG" || ext == ".JPEG" || ext == ".BMP" || ext == ".PNG" || ext == ".GIF" || ext == ".TIFF" || ext == ".jpg" || ext == ".jpeg" || ext == ".bmp" || ext == ".png" || ext == ".gif" || ext == ".tiff")
                {


                    button2.Enabled = true;
                    button3.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button8.Enabled = true;
                    button9.Enabled = true;



                    string filePath = Path.GetDirectoryName(newfile);
                    string[] files = Directory.GetFiles(filePath);

                    images = new string[0];

                    for (int i = 0; i < files.Length; i++)
                    {

                        ext2 = Path.GetExtension(files[i]);
                        if (ext2 == ".JPG" || ext2 == ".JPEG" || ext2 == ".BMP" || ext2 == ".PNG" || ext2 == ".GIF" || ext2 == ".TIFF" || ext2 == ".jpg" || ext2 == ".jpeg" || ext2 == ".bmp" || ext2 == ".png" || ext2 == ".gif" || ext2 == ".tiff")
                        {


                            Array.Resize(ref images, images.Length + 1);
                            images[images.Length - 1] = files[i];


                            t = t + 1;
                        }
                    }
                    /*
                    _pictureIndex++;
                    if (_pictureIndex > files.Length)
                    {
                        _pictureIndex = 0;
                    }
                    */


                    // choose the picture that was already selected
                    for (int r = 0; r < images.Length; r++)
                    {
                        if (images[r] == text)
                        { imageIndex = r; }
                    }


                    //frm.openNewPicture(newfile, openFileDialog1.SafeFileName);
                    openNewPicture(images[imageIndex], openFileDialog1.SafeFileName);

                    var len = files.Length;

                    this.label1.Text = Strings.imagenumber +" "+ (imageIndex + 1) +" "+ Strings.of + images.Length;














                }
                else
                {
                    openNewVideo(newfile, openFileDialog1.SafeFileName);
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;

                    this.label1.Text = Strings.videoopened;
                }


                /*
                frm.TopLevel = false;
                this.splitContainer2.Panel2.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                */



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sc = Screen.AllScreens.Length;
            if (sc > 1)
            {
                return_to_window();
                frm.Controls.Clear();
                muteVideo(isVideo);
                place_splash(splash);
                this.label1.Text = Strings.notdisplaying;
            }
            else
            {
                Prompt.ShowDialog(Strings.connectthetv, Strings.thereisnotv);
            }
            label1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sc = Screen.AllScreens.Length;
            if (sc > 1)
            {
                return_to_window();
                frm.Controls.Clear();

                frm.Visible = true;
                unMuteVideo(isVideo);
                frm.Bounds = Screen.AllScreens[1].WorkingArea;
                frm.Location = Screen.AllScreens[1].WorkingArea.Location;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.WindowState = FormWindowState.Maximized;

                if (isVideo)
                {
                    Frm2isVideo = true;
                    frm.Controls.Add(axWindowsMediaPlayer1);
                }
                else
                {
                    Frm2isPicture = true;
                    frm.Controls.Add(PictureBox);
                }

                this.label1.Text = Strings.displaying;
            }
            else
            {
                Prompt.ShowDialog(Strings.connectthetv, Strings.thereisnotv);
            }
            label1.BringToFront();
            
        }










        private void button4_Click(object sender, EventArgs e)
        {
            playNewFile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pauseNewFile();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stretchPhoto();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fitPhoto();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isVideo) { rewind(); }
            else
            {
                if (imageIndex != 0)
                {
                    imageIndex = imageIndex - 1;
                    this.label1.Text = Strings.imagenumber + (imageIndex + 1) + Strings.of + (images.Length);
                    openNewPicture(images[imageIndex], images[imageIndex]);

                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isVideo) { fastForward(); }
            else
            {
                if (imageIndex < images.Length - 1)
                {
                    imageIndex = imageIndex + 1;
                    this.label1.Text = Strings.imagenumber + (imageIndex + 1) + Strings.of + (images.Length);
                    openNewPicture(images[imageIndex], images[imageIndex]);

                }
            }
        }

        public static class Prompt
        {
            public static void ShowDialog(string text, string caption)
            {
                Form prompt = new Form();
                prompt.Width = 250;
                prompt.Height = 200;
                prompt.Text = caption;
                Label textLabel = new Label() { Left = 2, Width = 250, Top = 20, Text = text };
                //NumericUpDown inputBox = new NumericUpDown() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = Strings.ok, Left = 50, Width = 100, Top = 100 };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                //prompt.Controls.Add(inputBox);
                prompt.ShowDialog();
                //return (int)inputBox.Value;
            }
        }
































        public void openNewVideo(string newfile, string fsn)
        {



            return_to_window();

            frm.Controls.Clear();
            this.splitContainer8.Panel2.Controls.Clear();
            place_splash(splash);
            if (isVideo) { this.axWindowsMediaPlayer1.Ctlcontrols.stop(); this.axWindowsMediaPlayer1 = null; }
            if (isPicture) {  this.PictureBox = null; }

            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(800, 450);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.splitContainer8.Panel2.Controls.Add(this.axWindowsMediaPlayer1);
            String u = "File:///" + newfile;
            axWindowsMediaPlayer1.URL = u;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            /*
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            
            this.axVLCPlugin21.Dock = DockStyle.Fill;
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.Size = new System.Drawing.Size(800, 450);
            this.axVLCPlugin21.TabIndex = 1;

            this.splitContainer8.Panel2.Controls.Add(axVLCPlugin21);

            axVLCPlugin21.playlist.add("File:///" + newfile, fsn, null);
            axVLCPlugin21.playlist.play();
           */
            muteVideo(true);


            isVideo = true;
            isPicture = false;
        }

        public void openNewPicture(string newfile, string fsn)
        {
            if (isVideo) {  this.axWindowsMediaPlayer1 = null; }
            if (isPicture) {  this.PictureBox = null; }

            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PictureBox.Name = "pictureBox";
            this.PictureBox.Dock = DockStyle.Fill;
            this.PictureBox.Location = new Point(0, 0);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PictureBox.Image = Image.FromFile(newfile);


            if (Frm2isPicture == true) {

                frm.Controls.Clear();
                frm.Controls.Add(PictureBox);
                frm.BringToFront();

            }
            else {
                this.splitContainer8.Panel2.Controls.Clear();
                this.splitContainer8.Panel2.Controls.Add(this.PictureBox);
            }

            isVideo = false;
            isPicture = true;
            
        }

        public void playNewFile()
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        public void pauseNewFile()
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        public void rewind()
        {
            double t = axWindowsMediaPlayer1.currentMedia.duration;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = t - 50000;
        }
        public void fastForward()
        {
            double t = axWindowsMediaPlayer1.currentMedia.duration;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = t + 50000;   
        }
        public void muteVideo(bool isVideo)
        {

            if (isVideo)
            {
                axWindowsMediaPlayer1.settings.volume = 0;
                //axVLCPlugin21.audio.toggleMute();
            }

        }
        public void unMuteVideo(bool isVideo)
        {

            if (isVideo)
            {
                axWindowsMediaPlayer1.settings.volume = 100;
                //axVLCPlugin21.audio.toggleMute();
            }

        }
        public void stretchPhoto()
        {
            this.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void fitPhoto()
        {
            this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }



        public void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string objTextBox = this.textBox1.Text;
                SecurityCamBrowser.Load("http://" + objTextBox);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            return_to_window();
            frm.Controls.Clear();
            place_splash(splash);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            var sc = Screen.AllScreens.Length;
            if (sc > 1)
            {
                frm.Controls.Clear();

                frm.Visible = true;
                frm.Bounds = Screen.AllScreens[1].WorkingArea;
                frm.Location = Screen.AllScreens[1].WorkingArea.Location;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.WindowState = FormWindowState.Maximized;
                frm.Controls.Add(RecieveBrowser);
                frm.BringToFront();

                this.label1.Text = Strings.displaying;
            }
            else
            {
                Prompt.ShowDialog(Strings.connectthetv, Strings.thereisnotv);
            }
            label1.BringToFront();

            Frm2isBrowser = true;
        }

        public void place_splash(Boolean s) {

            if (s)
            {

                var sc = Screen.AllScreens.Length;
                if (sc > 1)
                {



                    frm.Controls.Clear();

                    frm.Visible = true;
                    frm.Bounds = Screen.AllScreens[1].WorkingArea;
                    frm.Location = Screen.AllScreens[1].WorkingArea.Location;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.WindowState = FormWindowState.Maximized;

                    SplashBox = new System.Windows.Forms.PictureBox();

                    SplashBox.Name = "splashPictureBox";
                    SplashBox.Dock = DockStyle.Fill;
                    SplashBox.Location = new Point(0, 0);
                    SplashBox.TabIndex = 1;
                    SplashBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    SplashBox.Image = mySplashScreen;

                    frm.Controls.Add(SplashBox);

                    this.label1.Text = Strings.displaying;
                }
                else
                {
                    Prompt.ShowDialog(Strings.connectthetv, Strings.thereisnotv);
                }
                label1.BringToFront();
            }
            else {

                frm.Visible = false;

            }
        }

        public void return_to_window()
        {
            if (Frm2isBrowser) { splitContainer5.Panel2.Controls.Add(RecieveBrowser); Frm2isBrowser = false; }
            if (Frm2isPicture) { this.splitContainer8.Panel2.Controls.Add(this.PictureBox); Frm2isPicture = false; }
            if (Frm2isVideo) { this.splitContainer8.Panel2.Controls.Add(axWindowsMediaPlayer1); Frm2isVideo = false; }
            if (Frm2isSecurity) { this.splitContainer7.Panel2.Controls.Add(SecurityCamBrowser); Frm2isSecurity = false; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            return_to_window();
            frm.Controls.Clear();
            place_splash(splash);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var sc = Screen.AllScreens.Length;
            if (sc > 1)
            {
                frm.Controls.Clear();
                frm.Visible = true;
                frm.Bounds = Screen.AllScreens[1].WorkingArea;
                frm.Location = Screen.AllScreens[1].WorkingArea.Location;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.WindowState = FormWindowState.Maximized;
                frm.Controls.Add(SecurityCamBrowser);
                frm.BringToFront();

                this.label1.Text = Strings.displaying;
            }
            else
            {
                Prompt.ShowDialog(Strings.connectthetv, Strings.thereisnotv);
            }
            label1.BringToFront();

            Frm2isSecurity = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.Visible = true;
            frm3.Bounds = Screen.AllScreens[0].WorkingArea;
            frm3.Location = Screen.AllScreens[0].WorkingArea.Location;
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.WindowState = FormWindowState.Normal;
        }
    }
}

