﻿using System;
using System.Windows.Forms;

namespace EventsDelegatesAsgmt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // --- EzCalc ---
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AiCalc());
        }
    }
}
