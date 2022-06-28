using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace browserTest
{
    public partial class Application : Form
    {
        // Constructor
        public Application()
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
            tabContainer.TabPages.Add(newTabPage);

            tabContainer.TabPages[0].Controls.Add(new ChromiumWebBrowser("https://duckduckgo.com"));
            OpenWebPage("https://duckduckgo.com");
        }

        private string[] lastPages = { };
        private Uri uriResult;
        // yt, discord, twitch
        private bool[] specialButtonOpen = { false, false, false };

        // Special Buttons
        private ChromiumWebBrowser ytBrowser = new ChromiumWebBrowser("https://www.youtube.com");
        private ChromiumWebBrowser discordBrowser = new ChromiumWebBrowser("https://www.discord.com");
        private ChromiumWebBrowser twitchBrowser = new ChromiumWebBrowser("https://www.twitch.tv/");

        string ButtonPage = "";

        // Custom functions

        private void OpenWebPage(string page)
        {
            ChromiumWebBrowser currentBrowser = tabContainer.SelectedTab.Controls[0] as ChromiumWebBrowser;

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

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                OpenWebPage(textBox1.Text);
            }
        }

        /*
         * Top bar buttons and address box
         */

        private void BackButton_Click(object sender, EventArgs e)
        {
            //currentBrowser.GoForward();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            //currentBrowser.GoForward();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            OpenWebPage("https://duckduckgo.com");
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser currentBrowser = tabContainer.SelectedTab.Controls[0] as ChromiumWebBrowser;
            currentBrowser.Refresh();
        }

        private void AddressBox_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void AddressBox_Unfocus(object sender, EventArgs e)
        {
            ChromiumWebBrowser currentBrowser = tabContainer.SelectedTab.Controls[0] as ChromiumWebBrowser;
            textBox1.Text = currentBrowser.Address;
        }

        private void CloseTabButton_Click(object sender, EventArgs e)
        {
            OpenWebPage(textBox1.Text);
        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage("New Tab");
            ChromiumWebBrowser newBrowser = new ChromiumWebBrowser();
            newBrowser.Dock = DockStyle.Fill;
            newBrowser.Load("https://duckduckgo.com");
            newTabPage.BackColor = System.Drawing.Color.Black;
            newTabPage.Controls.Add(newBrowser);
            tabContainer.TabPages.Add(newTabPage);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            tabContainer.TabPages.Remove(tabContainer.SelectedTab);
        }

        /* 
         * Special buttons on left side and button maker input
         */

        private void YtButton_Click(object sender, EventArgs e)
        {
            discordBrowser.Visible = false;
            specialButtonOpen[1] = false;
            twitchBrowser.Visible = false;
            specialButtonOpen[2] = false;

            ytBrowser.Visible = false;
            ytBrowser.Dock = DockStyle.None;
            this.Controls.Add(ytBrowser);

            if (specialButtonOpen[0])
            {
                ytBrowser.Visible = false;
                tabContainer.Visible = true;
                specialButtonOpen[0] = false;

                ChromiumWebBrowser currentBrowser = tabContainer.SelectedTab.Controls[0] as ChromiumWebBrowser;
                textBox1.Text = currentBrowser.Address;
            }

            else
            {
                ytBrowser.Visible = true;
                ytBrowser.Height = this.Height - 75;
                ytBrowser.Width = this.Width - 50;
                ytBrowser.Location = new System.Drawing.Point(36, 35);
                tabContainer.Visible = false;

                specialButtonOpen[0] = true;

                textBox1.Text = "Youtube";
            }
        }

        private void DiscordButton_Click(object sender, EventArgs e)
        {
            ytBrowser.Visible = false;
            specialButtonOpen[0] = false;
            twitchBrowser.Visible = false;
            specialButtonOpen[2] = false;

            discordBrowser.Visible = false;
            discordBrowser.Dock = DockStyle.None;
            this.Controls.Add(discordBrowser);

            if (specialButtonOpen[1])
            {
                discordBrowser.Visible = false;
                tabContainer.Visible = true;
                specialButtonOpen[1] = false;

                ChromiumWebBrowser currentBrowser = tabContainer.SelectedTab.Controls[0] as ChromiumWebBrowser;
                textBox1.Text = currentBrowser.Address;
            }

            else
            {
                discordBrowser.Visible = true;
                discordBrowser.Height = this.Height - 75;
                discordBrowser.Width = this.Width - 50;
                discordBrowser.Location = new System.Drawing.Point(36, 35);
                tabContainer.Visible = false;

                specialButtonOpen[1] = true;

                textBox1.Text = "Discord";
            }
        }

        private void TwitchButton_Click(object sender, EventArgs e)
        {
            ytBrowser.Visible = false;
            specialButtonOpen[0] = false;
            discordBrowser.Visible = false;
            specialButtonOpen[1] = false;

            twitchBrowser.Visible = false;
            twitchBrowser.Dock = DockStyle.None;
            this.Controls.Add(twitchBrowser);

            if (specialButtonOpen[2])
            {
                twitchBrowser.Visible = false;
                tabContainer.Visible = true;
                specialButtonOpen[2] = false;

                ChromiumWebBrowser currentBrowser = tabContainer.SelectedTab.Controls[0] as ChromiumWebBrowser;
                textBox1.Text = currentBrowser.Address;
            }

            else
            {
                twitchBrowser.Visible = true;
                twitchBrowser.Height = this.Height - 75;
                twitchBrowser.Width = this.Width - 50;
                twitchBrowser.Location = new System.Drawing.Point(36, 35);
                tabContainer.Visible = false;

                specialButtonOpen[2] = true;

                textBox1.Text = "Twitch";
            }
        }

        private void SpecialButtonMakerSubmit_Click(object sender, EventArgs e)
        {
            string openedImage = "";
            bool isPNG = false;

            while (!isPNG)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine(openFileDialog1.FileName);
                    openedImage = openFileDialog1.FileName;

                    if (openedImage.EndsWith(".png"))
                    {
                        isPNG = true;
                    }
                }
            }

            Button testButton = new Button
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10),
                Image = System.Drawing.Image.FromFile(openedImage),
                BackColor = System.Drawing.SystemColors.WindowText,
                FlatStyle = FlatStyle.Flat,
            };

            testButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            testButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            testButton.FlatAppearance.BorderSize = 0;

            specialButtonPanel.Controls.Add(testButton);
            specialButtonPanel.Controls.SetChildIndex(button11, specialButtonPanel.RowCount);
            specialButtonPanel.Controls.SetChildIndex(testButton, specialButtonPanel.RowCount - 1);
            specialButtonMakerPage.Text = "";
            specialButtonMaker.Visible = false;
        }

        private void NewSpecialButton_Click(object sender, EventArgs e)
        {
            specialButtonMaker.Visible = true;
            specialButtonPanel.RowCount += 1;

            ButtonPage = specialButtonMakerPage.Text;
        }

        /*
         * Event Handlers
         */
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            tabContainer.Height = this.Height - 75;
            tabContainer.Width = this.Width - 65;

            textBox1.Width = this.Width - 245;

            topLayoutPanel.Location = new System.Drawing.Point(this.Width - (int)(topLayoutPanel.Width * 1.2), 0);
            topLayoutPanel.ColumnStyles[4].Width = this.Width - 245;

            ytBrowser.Height = this.Height - 75;
            ytBrowser.Width = this.Width - 50;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChromiumWebBrowser currentBrowser = tabContainer.SelectedTab.Controls[0] as ChromiumWebBrowser;
            textBox1.Text = currentBrowser.Address;
        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(delegate () { OnBrowserTitleChanged(sender, args); })
                );
            }
            else
            {
                tabContainer.SelectedTab.Text = args.Title;
            }
        }

        private void Browser_MouseDown(object sender, MouseEventArgs e)
        {
            System.Console.WriteLine(e);
        }
    }
}
