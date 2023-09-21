using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodSysDev.View
{
	/// <summary>
	/// Class <c>Menu</c> contains all the menu GUIs used for the console.
	/// </summary>
	internal class Menu
	{
		public void MainMenuGUI()
		{
            Console.WriteLine("Press 1 to enter [File Menu]\nPress 2 to enter [Check Number of Errors In The Error Log]" +
				"\nPress 3 to use [Calculator]\nPress 4 to find happiness\n\nPress 0 to EXIT APPLICATION");
        }
		public void FileMenuGUI()
		{
            Console.WriteLine("Press 1 to [Generate NECESSARY TEXT FILE]\nPress 2 to [Load NECESSARY TEXT FILE]" +
				"\n\nPress Backspace to return to [Main Menu]");
        }
	}
}
