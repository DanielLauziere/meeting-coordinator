using CefSharp;
using Meeting_Organizer.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Organizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //Restart options for debugging
            /*
            Properties.Settings.Default["Version"] = 0;
            Properties.Settings.Default["Type"] = 0;
            Properties.Settings.Default["Language"] = "";
            Properties.Settings.Default["First_open"] = true;
            Properties.Settings.Default.Save();
            */
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */


            Cef.EnableHighDPISupport();

            var settings = new CefSettings()
            {
                //By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
                CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache")
            };
            settings.BrowserSubprocessPath = @"x86\CefSharp.BrowserSubprocess.exe";
            // Enable WebRTC                            
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");

            //Perform dependency check to make sure all relevant resources are in our output directory.
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);

            bool opened = Properties.Settings.Default.First_open;
            int type = Properties.Settings.Default.Type;
            int version = Properties.Settings.Default.Version;

            string language = Settings.Default.Language;
            if (language.Equals("english")) { Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en"); }
            else if (language.Equals("espanol")) { Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es"); }
            else if (language.Equals("khmer")) { Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("km"); }

            if (!opened)
            {

                if (type == 1){ Application.Run(new Form1());}
                else if (type == 2) {
                    if (version > 0) { Application.Run(new Form6()); }
                    else { Application.Run(new Form7()); }
                }
                else { Application.Run(new Form5()); }
            }
            else {
                Application.Run(new Form4());
            }
        }
    }
}
