using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodSysDev.View
{
	internal class Menu
	{
		public void MainMenuGUI()
		{
            Console.WriteLine("Press 1 to enter [File Menu]\nPress 2 to enter [Check Number of Errors In The Error Log]" +
				"\n\nPress 0 to EXIT APPLICATION");
        }
		public void FileMenuGUI()
		{
            Console.WriteLine("Press 1 to [Generate NECESSARY TEXT FILE]\nPress 2 to [Load NECESSARY TEXT FILE]" +
				"\n\nPress Backspace to return to [Main Menu]");
        }
	}
}
