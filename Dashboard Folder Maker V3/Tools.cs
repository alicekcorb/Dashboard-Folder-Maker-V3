using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dashboard_Folder_Maker_V3
{
   
        /// <summary>
        /// Common Usage Tools.
        /// </summary>
        public class Tools
        {
            [DllImport("user32.dll")]
            private static extern
                bool SetForegroundWindow(IntPtr hWnd);
            [DllImport("user32.dll")]
            private static extern
                bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
            [DllImport("user32.dll")]
            private static extern
                bool IsIconic(IntPtr hWnd);

            /// <summary>
            /// check if current process already running. if runnung, set focus to 
            /// existing process and returns true otherwise returns false.
            /// </summary>
            /// <returns></returns>
            public static bool AlreadyRunning()
            {
                /*
                const int SW_HIDE = 0;
                const int SW_SHOWNORMAL = 1;
                const int SW_SHOWMINIMIZED = 2;
                const int SW_SHOWMAXIMIZED = 3;
                const int SW_SHOWNOACTIVATE = 4;
                const int SW_RESTORE = 9;
                const int SW_SHOWDEFAULT = 10;
                */
                const int SW_RESTORE = 9;

                //string myName=Path.GetFileNameWithoutExtension(Application.ExecutablePath);
                Process me = Process.GetCurrentProcess();
                Process[] arrProcesses = Process.GetProcessesByName(me.ProcessName);
                if (arrProcesses.Length > 1)
                {
                    for (int i = 0; i < arrProcesses.Length; i++)
                    {
                        if (arrProcesses[i].Id != me.Id)
                        {
                            // get the window handle
                            IntPtr hWnd = arrProcesses[i].MainWindowHandle;
                            // if iconic, we need to restore the window
                            if (IsIconic(hWnd))
                            {
                                ShowWindowAsync(hWnd, SW_RESTORE);
                            }
                            // bring it to the foreground
                            SetForegroundWindow(hWnd);
                            break;
                        }
                    }
                    return true;
                }

                return false;
            }
        }
    }


