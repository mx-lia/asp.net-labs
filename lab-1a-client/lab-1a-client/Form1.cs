using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1a_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:54247/sum.mys");
            string requestParams = "x=" + Number1.Value + "&y=" + Number2.Value;

            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                    Result.Text = rdr.ReadToEnd();
                    rdr.Close();
                }
            }
        }
    }
}
