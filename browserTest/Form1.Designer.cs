namespace browserTest
{
    partial class Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.topLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.specialButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.specialButtonMaker = new System.Windows.Forms.GroupBox();
            this.specialButtonMakerPage = new System.Windows.Forms.TextBox();
            this.specialButtonMakerLabel1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.topLayoutPanel.SuspendLayout();
            this.specialButtonPanel.SuspendLayout();
            this.specialButtonMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(30, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 30);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(57, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 30);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowText;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(87, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 30);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.WindowText;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1230, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 28);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.CloseTabButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(121, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1032, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            this.textBox1.Click += new System.EventHandler(this.AddressBox_Click);
            this.textBox1.Leave += new System.EventHandler(this.AddressBox_Unfocus);
            // 
            // tabContainer
            // 
            this.tabContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabContainer.Location = new System.Drawing.Point(36, 464);
            this.tabContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tabContainer.Multiline = true;
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.Padding = new System.Drawing.Point(0, 0);
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(1228, 217);
            this.tabContainer.TabIndex = 8;
            this.tabContainer.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1195, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 28);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NewTabButton_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1159, 5);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 28);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // topLayoutPanel
            // 
            this.topLayoutPanel.ColumnCount = 8;
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1038F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.topLayoutPanel.Controls.Add(this.button1, 0, 0);
            this.topLayoutPanel.Controls.Add(this.button7, 5, 0);
            this.topLayoutPanel.Controls.Add(this.textBox1, 4, 0);
            this.topLayoutPanel.Controls.Add(this.button6, 6, 0);
            this.topLayoutPanel.Controls.Add(this.button5, 7, 0);
            this.topLayoutPanel.Controls.Add(this.button2, 1, 0);
            this.topLayoutPanel.Controls.Add(this.button3, 2, 0);
            this.topLayoutPanel.Controls.Add(this.button4, 3, 0);
            this.topLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topLayoutPanel.Name = "topLayoutPanel";
            this.topLayoutPanel.RowCount = 1;
            this.topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayoutPanel.Size = new System.Drawing.Size(1264, 36);
            this.topLayoutPanel.TabIndex = 11;
            // 
            // specialButtonPanel
            // 
            this.specialButtonPanel.ColumnCount = 1;
            this.specialButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.specialButtonPanel.Controls.Add(this.button11, 0, 3);
            this.specialButtonPanel.Controls.Add(this.button10, 0, 2);
            this.specialButtonPanel.Controls.Add(this.button9, 0, 1);
            this.specialButtonPanel.Controls.Add(this.button8, 0, 0);
            this.specialButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.specialButtonPanel.Location = new System.Drawing.Point(0, 36);
            this.specialButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.specialButtonPanel.Name = "specialButtonPanel";
            this.specialButtonPanel.RowCount = 4;
            this.specialButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.specialButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.specialButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.specialButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.specialButtonPanel.Size = new System.Drawing.Size(36, 645);
            this.specialButtonPanel.TabIndex = 12;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.WindowText;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(3, 86);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 21);
            this.button11.TabIndex = 6;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.NewSpecialButton_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.WindowText;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button10.Image = global::browserTest.Properties.Resources.twitch;
            this.button10.Location = new System.Drawing.Point(3, 57);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 23);
            this.button10.TabIndex = 5;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.TwitchButton_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.WindowText;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(3, 30);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 21);
            this.button9.TabIndex = 4;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.DiscordButton_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.WindowText;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 21);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.YtButton_Click);
            // 
            // specialButtonMaker
            // 
            this.specialButtonMaker.Controls.Add(this.specialButtonMakerLabel1);
            this.specialButtonMaker.Controls.Add(this.specialButtonMakerPage);
            this.specialButtonMaker.ForeColor = System.Drawing.Color.White;
            this.specialButtonMaker.Location = new System.Drawing.Point(39, 39);
            this.specialButtonMaker.Name = "specialButtonMaker";
            this.specialButtonMaker.Size = new System.Drawing.Size(266, 158);
            this.specialButtonMaker.TabIndex = 13;
            this.specialButtonMaker.TabStop = false;
            this.specialButtonMaker.Text = "Make New Special Button";
            this.specialButtonMaker.Visible = false;
            // 
            // specialButtonMakerPage
            // 
            this.specialButtonMakerPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.specialButtonMakerPage.Location = new System.Drawing.Point(6, 39);
            this.specialButtonMakerPage.Name = "specialButtonMakerPage";
            this.specialButtonMakerPage.Size = new System.Drawing.Size(254, 23);
            this.specialButtonMakerPage.TabIndex = 0;
            // 
            // specialButtonMakerLabel1
            // 
            this.specialButtonMakerLabel1.AutoSize = true;
            this.specialButtonMakerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.specialButtonMakerLabel1.Location = new System.Drawing.Point(6, 16);
            this.specialButtonMakerLabel1.Name = "specialButtonMakerLabel1";
            this.specialButtonMakerLabel1.Size = new System.Drawing.Size(195, 20);
            this.specialButtonMakerLabel1.TabIndex = 1;
            this.specialButtonMakerLabel1.Text = "Input Special Button Page";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "%USERPROFILE%\\Pictures";
            this.openFileDialog1.Title = "Browse Image Files";
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.specialButtonMaker);
            this.Controls.Add(this.specialButtonPanel);
            this.Controls.Add(this.topLayoutPanel);
            this.Controls.Add(this.tabContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Application";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Web Browser";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.topLayoutPanel.ResumeLayout(false);
            this.topLayoutPanel.PerformLayout();
            this.specialButtonPanel.ResumeLayout(false);
            this.specialButtonMaker.ResumeLayout(false);
            this.specialButtonMaker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TableLayoutPanel topLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel specialButtonPanel;
        private System.Windows.Forms.Button button8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox specialButtonMaker;
        private System.Windows.Forms.TextBox specialButtonMakerPage;
        private System.Windows.Forms.Label specialButtonMakerLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

