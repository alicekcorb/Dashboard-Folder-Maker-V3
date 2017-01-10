using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Dashboard_Folder_Maker_V3
{
    public partial class Form1 : Form
    {
        internal string ffDirectory = "S:\\";
        internal string toolBtnClick = "C:\\CrossonTools\\";

        public Form1()
        {
            InitializeComponent();

            //to hopefully help with the form appearing the same on different screen resolutions
            // StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            //opens the program in maximized window
            this.WindowState = FormWindowState.Maximized;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //prevent user from closing program by clicking the X (but can still end process thru task manager)
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnViewFolder2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewFolder1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewFolder4_Click(object sender, EventArgs e)
        {

        }

        private void btnViewFolder3_Click(object sender, EventArgs e)
        {

        }

        private void btnViewFolder5_Click(object sender, EventArgs e)
        {

        }

        private void btnViewFolder6_Click(object sender, EventArgs e)
        {

        }
    }
}
