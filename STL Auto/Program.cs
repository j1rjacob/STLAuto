﻿using System;
using System.Windows.Forms;

namespace STL_Auto
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
            //Application.Run(new FormMain());
            Application.Run(new FormAuto());
        }
    }
}
