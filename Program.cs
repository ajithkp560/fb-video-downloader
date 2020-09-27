using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookVideoDownloader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread _thread = new Thread(() =>
            {
                Application.Run(new Form1());
            });
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            //Application.Run(new Form1());
        }
    }
}
