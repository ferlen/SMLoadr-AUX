﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMLoader.new_release
{
    class new_release
    {
        public void check()
        {
            string url = "https://github.com/thelucifermorningstar/SMLoadr-AUX/releases/download/1.0.3/SMA_1.0.3_x64.zip";
            WebRequest request = WebRequest.Create(url);

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusDescription == "OK")
                {

                    DialogResult dialog = MessageBox.Show("A new version is avaliable! (1.0.2) Go to Download?", "Update", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        Process.Start("https://github.com/thelucifermorningstar/SMLoadr-AUX/releases/");
                    }
                }

            }
            catch
            {

            }
        }
            



    }
}
