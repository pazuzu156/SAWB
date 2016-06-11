/*
 * KalebKleinSoftware License Agreement
 * ------------------------------------
 * This software is freeware: meaning it's free to use and share, but you cannot modify/reverse engineer
 * it in any way. Distributing this software elsewhere than the GitHub is granted, but with the credits
 * of the author included. (This Readme)

 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
 * even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. This software is
 * provided AS IS, and the author assumes NO LIABILITY for the outcomes of using this software. You
 * hereby agree to this disclaimer by using This software. If you do not agree to adhere to this disclaimer,
 * you should not use this software. Should you revoke this disclaimer in the future, you should immediately
 * discontinue use of this software
 */
namespace SAWB
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.bGo = new System.Windows.Forms.Button();
			this.bRefresh = new System.Windows.Forms.Button();
			this.bBack = new System.Windows.Forms.Button();
			this.bForward = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.pbLoading = new System.Windows.Forms.ToolStripProgressBar();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miGoto = new System.Windows.Forms.ToolStripMenuItem();
			this.miHomepage = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(12, 53);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(991, 535);
			this.webBrowser1.TabIndex = 1;
			// 
			// txtURL
			// 
			this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtURL.Location = new System.Drawing.Point(172, 27);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(667, 20);
			this.txtURL.TabIndex = 2;
			// 
			// bGo
			// 
			this.bGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bGo.Location = new System.Drawing.Point(845, 24);
			this.bGo.Name = "bGo";
			this.bGo.Size = new System.Drawing.Size(75, 23);
			this.bGo.TabIndex = 3;
			this.bGo.Text = "Go";
			this.bGo.UseVisualStyleBackColor = true;
			this.bGo.Click += new System.EventHandler(this.bGo_Click);
			// 
			// bRefresh
			// 
			this.bRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bRefresh.Location = new System.Drawing.Point(926, 24);
			this.bRefresh.Name = "bRefresh";
			this.bRefresh.Size = new System.Drawing.Size(75, 23);
			this.bRefresh.TabIndex = 4;
			this.bRefresh.Text = "Refresh";
			this.bRefresh.UseVisualStyleBackColor = true;
			this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
			// 
			// bBack
			// 
			this.bBack.Location = new System.Drawing.Point(10, 24);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(75, 23);
			this.bBack.TabIndex = 5;
			this.bBack.Text = "Back";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Click);
			// 
			// bForward
			// 
			this.bForward.Location = new System.Drawing.Point(91, 24);
			this.bForward.Name = "bForward";
			this.bForward.Size = new System.Drawing.Size(75, 23);
			this.bForward.TabIndex = 6;
			this.bForward.Text = "Forward";
			this.bForward.UseVisualStyleBackColor = true;
			this.bForward.Click += new System.EventHandler(this.bForward_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.pbLoading});
			this.statusStrip1.Location = new System.Drawing.Point(0, 591);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1015, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(898, 17);
			this.lblStatus.Spring = true;
			this.lblStatus.Text = "Ready!";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pbLoading
			// 
			this.pbLoading.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.pbLoading.Name = "pbLoading";
			this.pbLoading.Size = new System.Drawing.Size(100, 16);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGoto,
            this.miHomepage,
            this.toolStripSeparator1,
            this.miExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// miGoto
			// 
			this.miGoto.Name = "miGoto";
			this.miGoto.ShortcutKeyDisplayString = "Ctrl+G";
			this.miGoto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.miGoto.Size = new System.Drawing.Size(209, 22);
			this.miGoto.Text = "Go to &URL";
			this.miGoto.Click += new System.EventHandler(this.miGoto_Click);
			// 
			// miHomepage
			// 
			this.miHomepage.Name = "miHomepage";
			this.miHomepage.ShortcutKeyDisplayString = "Ctrl+H";
			this.miHomepage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.miHomepage.Size = new System.Drawing.Size(209, 22);
			this.miHomepage.Text = "&Set as Homepage";
			this.miHomepage.Click += new System.EventHandler(this.miHomepage_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
			// 
			// miExit
			// 
			this.miExit.Name = "miExit";
			this.miExit.ShortcutKeyDisplayString = "Ctrl+Q";
			this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.miExit.Size = new System.Drawing.Size(209, 22);
			this.miExit.Text = "&Exit";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// miAbout
			// 
			this.miAbout.Name = "miAbout";
			this.miAbout.ShortcutKeyDisplayString = "Ctrl+?";
			this.miAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemQuestion)));
			this.miAbout.Size = new System.Drawing.Size(146, 22);
			this.miAbout.Text = "&About";
			this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1015, 613);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.bForward);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.bRefresh);
			this.Controls.Add(this.bGo);
			this.Controls.Add(this.txtURL);
			this.Controls.Add(this.webBrowser1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simple Ass Web Browser";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Button bGo;
		private System.Windows.Forms.Button bRefresh;
		private System.Windows.Forms.Button bBack;
		private System.Windows.Forms.Button bForward;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripProgressBar pbLoading;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miGoto;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miAbout;
		private System.Windows.Forms.ToolStripMenuItem miHomepage;
	}
}

