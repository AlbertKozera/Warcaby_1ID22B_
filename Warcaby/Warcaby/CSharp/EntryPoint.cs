﻿using System;
using System.Windows.Forms;
using Warcaby.CSharp.Forms;

namespace Warcaby.CSharp
{
    static class EntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainStage());
        }
    }
}
