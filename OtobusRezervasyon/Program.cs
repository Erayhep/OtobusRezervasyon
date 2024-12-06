using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Otobilet;

namespace OtobusRezervasyon
{
        static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Giris()); // giriþ ekranýndan uygulamayý baþlat
            Application.ApplicationExit += (s, e) =>
            {
                Environment.Exit(0);
            };
        }

    }
}