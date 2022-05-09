using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browserTest
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();

            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            OpenWebPage("duckduckgo.com");
        }

        private string[] lastPages = { };

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                OpenWebPage(textBox1.Text);
            }
        }

        private void OpenWebPage(string page)
        {
            /*if (!page.StartsWith("https://") || !page.StartsWith("http://") || !page.StartsWith("www.")) {
                if (!page.EndsWith(".com/") || !page.EndsWith(".gov/") || !page.EndsWith(".org/") || !page.EndsWith(".xyz/"))
                {
                    page = "duckduckgo.com/?q=" + page;
                }
                label1.Text = page;
                page = "https://" + page;
                lastPages.Append(page);
                webBrowser1.Load(page);
                System.Threading.Thread.Sleep(500);
                textBox1.Text = webBrowser1.Address;
            }*/

            /*if (!page.Contains(".com") || !page.Contains(".gov") || !page.Contains(".org") || !page.Contains(".xyz") || !page.Contains(".net"))
            {
                page = "https://duckduckgo.com/?q=" + page;
            }*/

            page = "https://" + page;
            lastPages.Append(page);
            webBrowser1.Load(page);
            System.Threading.Thread.Sleep(500);
            textBox1.Text = webBrowser1.Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenWebPage("www.duckduckgo.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Unfocus(object sender, EventArgs e)
        {
            textBox1.Text = webBrowser1.Address;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenWebPage(textBox1.Text);
        }
    }
}
