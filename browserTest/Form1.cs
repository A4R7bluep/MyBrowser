using System;
using System.Linq;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace browserTest
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();

            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            tabControl1.TabPages[0].Controls.Add(new ChromiumWebBrowser("https://duckduckgo.com"));
            OpenWebPage("https://duckduckgo.com");
        }

        private string[] lastPages = { };
        private Uri uriResult;

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                OpenWebPage(textBox1.Text);
            }
        }

        private void OpenWebPage(string page)
        {
            ChromiumWebBrowser currentBrowser = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (!(Uri.TryCreate(page, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps)))
            {
                page = "https://duckduckgo.com/?q=" + page + "&ia=web";
            }
            else
            {
                page = uriResult.ToString();
            }

            lastPages.Append(page);
            currentBrowser.Load(page);
            System.Threading.Thread.Sleep(500);
            textBox1.Text = currentBrowser.Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //currentBrowser.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //currentBrowser.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenWebPage("https://duckduckgo.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser currentBrowser = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
            currentBrowser.Refresh();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Unfocus(object sender, EventArgs e)
        {
            ChromiumWebBrowser currentBrowser = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
            textBox1.Text = currentBrowser.Address;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenWebPage(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage("New Tab");
            ChromiumWebBrowser newBrowser = new ChromiumWebBrowser();
            newBrowser.Dock = DockStyle.Fill;
            newBrowser.Load("https://duckduckgo.com");
            newTabPage.BackColor = System.Drawing.Color.Black;
            newTabPage.Controls.Add(newBrowser);
            tabControl1.TabPages.Add(newTabPage);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tabControl1.Height = this.Height - 85;
            textBox1.Width = this.Width - 250;
        }
    }
}
