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
	public partial class GotoForm : Form
	{
		#region Properties
		/// <summary>
		/// Boolean to check if it's okay to pass given URL to the main form
		/// </summary>
		public bool GoPressed { get; private set; }

		/// <summary>
		/// The URL to pass into the main form
		/// </summary>
		public string URL { get; private set; }
		#endregion

		#region Constructor
		public GotoForm()
		{
			InitializeComponent();

			// Set keydown event listener on the text box
			// This sets URL property on every keydown event call
			// Also, listens for ESCAPE and ENTER keys for form events
			textBox1.KeyDown += textBox1_KeyDown;
		}
		#endregion

		#region Component Methods
		/// <summary>
		/// Listen for a keydown event on URL box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			// Set URL to the URL box's content
			this.URL = textBox1.Text;

			// If escape is pressed, close form
			// don't pass URL into main form
			if (e.KeyCode == Keys.Escape)
				this.Close();
			// If enter is pressed, close form
			// ensure URL is passed into main form on closing event call
			else if(e.KeyCode == Keys.Enter)
			{
				// If URL box is empty, throw an error
				if (textBox1.Text.Equals(""))
					MessageBox.Show("URL cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// If URL box has a URL, allow passing of URL and close
				else
				{
					GoPressed = true;
					this.Close();
				}
			}
		}

		/// <summary>
		/// Go button's click event handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			// If URL box is empty, throw an error
			if (textBox1.Text.Equals(""))
				MessageBox.Show("URL cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			// If URL box has a URL, allow passing of URL and close
			else
			{
				GoPressed = true;
				this.Close();
			}
		}
		#endregion
	}
}
