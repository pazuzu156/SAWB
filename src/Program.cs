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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAWB
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
