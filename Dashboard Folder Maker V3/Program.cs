using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Dashboard_Folder_Maker_V3
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

          
        }

        //prevent multiple instances of program from running
        //jump to existing process if exist.
        /// 
        /// check if given exe alread running or not
        /// 
        /// returns true if already running
    }
    }

