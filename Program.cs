﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Sheduler_Take_2
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
            Application.Run(new Form1());

            ProcessList processList = new ProcessList();
            processList.Add(0, 3);
            processList.Add(2, 4);
            processList.Add(1, 5);
            Process[] ps = processList.useFCFS();
            foreach (Process p in ps)
            {
                Console.WriteLine(p);
            }
        }
    }
}