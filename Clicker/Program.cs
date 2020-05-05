using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clicker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            bool b = false;
            System.Threading.Mutex m = new System.Threading.Mutex(true, "OnlyTest", out b);
            if (b)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
                m.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Clicker已经启动！");
            }
        }
    }
}
