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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAWB
{
	public partial class Form1 : Form
	{
		#region Variables
		string homepage;
		/// <summary>
		/// Settings
		/// </summary>
		Settings s;

		/// <summary>
		/// GotoURL form
		/// </summary>
		GotoForm gf;
		#endregion

		#region Constructor
		public Form1()
		{
			InitializeComponent();

			// Instantiate settings class
			// Load settings if a file exists
			// or create one if it doesn't
			s = new Settings();
			if (s.exists())
				s.load();
			else
				s.create();

			// Set the homepage
			this.homepage = s.Homepage;

			// Load URL into browser component from homepage
			// and set URL bar's text to that URL
			webBrowser1.Url = new Uri(homepage);
			txtURL.Text = homepage;

			// Listen for key events on URL bar
			txtURL.KeyDown += txtURL_KeyDown;

			// Events for when browser component has navigated to given URL
			// and load progress changed for updating status bar
			webBrowser1.Navigated += webBrowser1_Navigated;
			webBrowser1.ProgressChanged += webBrowser1_ProgressChanged;

			// Event handler for listening to the closing event
			// of the window
			this.FormClosing += Form1_FormClosing;
		}
		#endregion

		#region Event Called Methods
		/// <summary>
		/// Form closing event. Fired when window is closed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Make sure settings are saved before closing app
			s.save();
		}

		/// <summary>
		/// Fired when loading web pages. Updates progress bar on status bar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
		{
			// set the progress bar's maximum value
			pbLoading.Maximum = int.Parse(e.MaximumProgress.ToString());

			// set the progress bar's current value
			// ensure a negative isn't passed in
			// and it doesn't attempt to go over max limit set above
			if(e.CurrentProgress > -1
				&& e.CurrentProgress <= e.MaximumProgress)
			{
				pbLoading.Value = int.Parse(e.CurrentProgress.ToString());
			}

			// max = 0 when complete...for some fucking reason...
			// if it's not 0, set status text to loading and give percentage
			// Else, reset to ready status
			if(e.MaximumProgress != 0)
			{
				double percent = 100 * e.CurrentProgress / e.MaximumProgress;
				lblStatus.Text = "Loading page: " + txtURL.Text + " // " + int.Parse(percent.ToString()) + "%";
			}
			else
			{
				lblStatus.Text = "Ready!";
			}
		}

		/// <summary>
		/// Fired when browser component has navigated to a new URL
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			txtURL.Text = webBrowser1.Url.ToString();

			this.Text = "Simple Ass Web Browser - " + txtURL.Text;
		}

		/// <summary>
		/// Listens for key presses on URL bar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void txtURL_KeyDown(object sender, KeyEventArgs e)
		{
			// Load URL when ENTER key is pressed
			if(e.KeyCode == Keys.Enter)
			{
				loadURL();
			}
		}
		#endregion

		#region Control Methods
		/// <summary>
		/// Fired when back navigation button is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bBack_Click(object sender, EventArgs e)
		{
			webBrowser1.GoBack();
		}

		/// <summary>
		/// Fired when forward navigation button is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bForward_Click(object sender, EventArgs e)
		{
			webBrowser1.GoForward();
		}

		/// <summary>
		/// Fired when GO navigation button is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bGo_Click(object sender, EventArgs e)
		{
			loadURL();
		}

		/// <summary>
		/// Fired when refresh button is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bRefresh_Click(object sender, EventArgs e)
		{
			webBrowser1.Refresh();
		}

		/// <summary>
		/// Fired when About MenuStripItem is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void miAbout_Click(object sender, EventArgs e)
		{
			new AboutBox1().ShowDialog();
		}

		/// <summary>
		/// Fired when Goto URL MenuStripItem is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void miGoto_Click(object sender, EventArgs e)
		{
			openGotoWindow();
		}

		/// <summary>
		/// Listens to when the GotoForm is closing so it can set the new URL and load the page
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void gf_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(gf.GoPressed)
			{
				txtURL.Text = gf.URL;
				loadURL();
			}
		}

		/// <summary>
		/// Fired when Set Homepage MenuStripItem is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void miHomepage_Click(object sender, EventArgs e)
		{
			s.Homepage = txtURL.Text;
			MessageBox.Show(string.Format("You have set {0} as your new homepage", txtURL.Text), "Set Homepage", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Fired when Exit MenuStripItem is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void miExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Misc Methods
		/// <summary>
		/// Loads the URL into browser component
		/// </summary>
		private void loadURL()
		{
			// if URL bar doesn't have http or https, put it there
			if(!txtURL.Text.StartsWith("https"))
			{
				if (!txtURL.Text.StartsWith("http"))
				{
					string text = txtURL.Text;
					txtURL.Text = "http://" + text;
				}
			}

			// reset progress bar so it doesn't crash app
			pbLoading.Value = 0;
			pbLoading.Maximum = 0;

			// Load the URL
			webBrowser1.Url = new Uri(txtURL.Text);
		}

		/// <summary>
		/// Opens the GotoForm
		/// </summary>
		private void openGotoWindow()
		{
			gf = new GotoForm();
			gf.FormClosing += gf_FormClosing;
			gf.ShowDialog();
			gf = null;
		}
		#endregion
	}
}
