//2016.11.02 Graf Exum
//http://www.github.com/grafexum



using System;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwipeHTML
{
    public partial class SwipeHtml : Form
    {
        public SwipeHtml()
        {
            InitializeComponent();
        }

        public static String ReturnHTML(string Url)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            return result;
        }


        private void btnDoScrap_Click(object sender, EventArgs e)
        {
            var InputText = txtInputBox.Text;
            //ReturnHTML(InputText);
            SaveFileDialog Save = new SaveFileDialog();
            Save.Filter = "Html files (*.html)|*.html";
            try
            {
                if (Save.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(Save.FileName))
                        sw.WriteLine(ReturnHTML(InputText));
                }
            }
            catch
            {
                txtInputBox.Text = "Error!!";
            }
        }
    }
}
