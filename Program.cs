﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Child_Adoption
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Signup());
            Application.Run(new Login());
            //Application.Run(new Employee());
            //Application.Run(new Admin());
            //Application.Run(new Homepage("Rahi"));
        }
    }
}
