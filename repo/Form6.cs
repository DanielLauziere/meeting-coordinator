using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using Meeting_Organizer.Properties;

namespace Meeting_Organizer
{
    public partial class Form6 : Form
    {
        public ChromiumWebBrowser WatchMeetingBrowser;
        int version = Settings.Default.Version;
        string code = Settings.Default.Code;
        public Form6()
        {
            InitializeComponent();

            if (version == 3) { this.Text = Strings.meetingcoordinatorultimate; }
            else if (version == 2) { this.Text = Strings.meetingcoordinatroprofessional; }
            else if (version == 1) { this.Text = Strings.meetingcoordinatorbasic; }
            else { this.Text = Strings.meetingcoordinatorfree; }
            WatchMeetingBrowser = new ChromiumWebBrowser("https://blueskydeveloper.com/rtc-meeting-coordinator/index.php?name="+code);
            this.Controls.Add(WatchMeetingBrowser);
            button1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form3 frm3 = new Form3();
            frm3.Visible = true;
            frm3.Bounds = Screen.AllScreens[0].WorkingArea;
            frm3.Location = Screen.AllScreens[0].WorkingArea.Location;
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.WindowState = FormWindowState.Normal;
        }
    }
}
