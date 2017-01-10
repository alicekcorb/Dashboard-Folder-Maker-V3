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
using System.Configuration;
using Microsoft;

namespace Dashboard_Folder_Maker_V3
{
   public class ButtonClick
    {
        private Form1 _form1;

        public ButtonClick(Form1 form1)
        {
            _form1 = form1;
        }
        public void ClickButtonOnce()
        {
            
      
        }

        public void CreateFolders(string path)
        {
         //the line below was only allowing one folder to be created in one box 
         //   _form1.baseDirectory = ConfigurationManager.AppSettings.Get(path);
            System.IO.Directory.CreateDirectory(path);
            System.IO.Directory.CreateDirectory(path + "\\" + "1.Freight.Bill.Dispatch");
            System.IO.Directory.CreateDirectory(path + "\\" + "2.Customer.Confirmation");
            System.IO.Directory.CreateDirectory(path + "\\" + "3.Signed.Carrier.Confirmation");
            System.IO.Directory.CreateDirectory(path + "\\" + "4.BOL.Delivery.Order");
            System.IO.Directory.CreateDirectory(path + "\\" + "5.Signed.POD");
           
        }
        // public void 
       

    }
    }
    


