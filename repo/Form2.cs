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
    public partial class Form2 : Form
    {



        public Form2()
        {
            InitializeComponent();
        }



/*

        public void openNewVideo(string newfile, string fsn)
        {
            if (videoStartedAlready) { this.Controls.Remove(axVLCPlugin21); }
            this.Controls.Clear();

            //this.axVLCPlugin21 = null;
            //this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2(); 

            this.axVLCPlugin21.Dock = DockStyle.Fill;
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.Size = new System.Drawing.Size(800, 450);
            this.axVLCPlugin21.TabIndex = 1;




            



            this.Controls.Add(axVLCPlugin21);




            axVLCPlugin21.playlist.add("File:///" + newfile, fsn, null);
            axVLCPlugin21.playlist.play();
            muteVideo(true);
            videoStartedAlready = true;
        }
        public void openNewPicture(string newfile, string fsn)
        {
            if (videoStartedAlready) { this.axVLCPlugin21 = null; this.Controls.Remove(axVLCPlugin21); }
            this.Controls.Clear();
            //this.PictureBox = null;
            this.PictureBox.Name = "pictureBox";
            this.PictureBox.Dock = DockStyle.Fill;
            this.PictureBox.Location = new Point(0, 0);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PictureBox.Image = Image.FromFile(newfile);
            this.Controls.Add(this.PictureBox);


        }

        public void playNewFile()
        {
            axVLCPlugin21.playlist.play();
        }
        public void pauseNewFile()
        {
            axVLCPlugin21.playlist.togglePause();
        }
        public void muteVideo(bool isVideo)
        {

            if (isVideo)
            {
                axVLCPlugin21.volume = 0;
                //axVLCPlugin21.audio.toggleMute();
            }

        }
        public void unMuteVideo(bool isVideo)
        {

            if (isVideo)
            {
                axVLCPlugin21.volume = 100;
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

    */

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}

