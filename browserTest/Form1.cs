using System;
using System.Linq;
using System.Collections.Generic;
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

            TabPage newTabPage = new TabPage("New Tab");
            ChromiumWebBrowser newBrowser = new ChromiumWebBrowser();
            newBrowser.Dock = DockStyle.Fill;
            newBrowser.Load("https://duckduckgo.com");
            newBrowser.TitleChanged += OnBrowserTitleChanged;
            newBrowser.MouseDown += new System.Windows.Forms.MouseEventHandler(Browser_MouseDown);

            newTabPage.BackColor = System.Drawing.Color.Black;
            newTabPage.Controls.Add(newBrowser);
            tabControl1.TabPages.Add(newTabPage);

            tabControl1.TabPages[0].Controls.Add(new ChromiumWebBrowser("https://duckduckgo.com"));
            OpenWebPage("https://duckduckgo.com");
        }

        private string[] lastPages = { };
        private Uri uriResult;
        // yt, 
        private bool[] specialButtonOpen = { false };

        // Special Buttons
        private ChromiumWebBrowser ytBrowser = new ChromiumWebBrowser("https://www.youtube.com");

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
            System.Threading.Thread.Sleep(100);
            textBox1.Text = currentBrowser.Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //currentBrowser.GoForward();
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

        private void button8_Click(object sender, EventArgs e)
        {
            ytBrowser.Visible = false;
            ytBrowser.Dock = DockStyle.None;
            this.Controls.Add(ytBrowser);

            if (specialButtonOpen[0])
            {
                ytBrowser.Visible = false;
                tabControl1.Visible = true;
                specialButtonOpen[0] = false;
            }

            else
            {
                ytBrowser.Visible = true;
                ytBrowser.Height = this.Height - 75;
                ytBrowser.Width = this.Width - 50;
                ytBrowser.Location = new System.Drawing.Point(36, 35);
                tabControl1.Visible = false;

                specialButtonOpen[0] = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tabControl1.Height = this.Height - 75;
            tabControl1.Width = this.Width - 65;

            textBox1.Width = this.Width - 245;

            tableLayoutPanel1.Location = new System.Drawing.Point(this.Width - (int)(tableLayoutPanel1.Width * 1.2), 0);
            tableLayoutPanel1.ColumnStyles[4].Width = this.Width - 245;

            ytBrowser.Height = this.Height - 75;
            ytBrowser.Width = this.Width - 50;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChromiumWebBrowser currentBrowser = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
            textBox1.Text = currentBrowser.Address;
        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(
                    delegate () { OnBrowserTitleChanged(sender, args); }));
            }
            else
            {
                tabControl1.SelectedTab.Text = args.Title;
            }
        }

        private void Browser_MouseDown(object sender, MouseEventArgs e)
        {
            System.Console.WriteLine(e);
        }
    }
}
