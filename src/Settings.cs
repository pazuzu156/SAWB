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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SAWB
{
	public class Settings
	{
		private static string SettingsFile = "settings.json";

		public string Homepage { get; set; }

		public bool exists()
		{
			return (File.Exists(SettingsFile)) ? true : false;
		}

		public void create()
		{
			this.Homepage = "https://google.com";
		}

		public void load()
		{
			using(var reader = new StreamReader(File.Open(SettingsFile, FileMode.Open, FileAccess.Read)))
			{
				var json = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(reader.ReadToEnd());

				this.Homepage = json["homepage"];
			}
		}

		public void save()
		{
			if (exists()) File.Delete(SettingsFile);

			using(var writer = new StreamWriter(File.Open(SettingsFile, FileMode.OpenOrCreate, FileAccess.Write)))
			{
				var json = new JavaScriptSerializer().Serialize(new
					{
						homepage = this.Homepage
					});

				writer.Write(json);
			}
		}
	}
}
