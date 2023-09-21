using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.Model.Text;

namespace TheGoodSysDev.View
{
	internal class TextToConsole
	{
		LoadTextFile ltf = new LoadTextFile();
		public void OpenPrintText()
		{
			Console.ResetColor();
			Console.WriteLine("The contents of the text file is:\n");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(ltf.ReadText());
			Console.ResetColor();
            Console.WriteLine("END OF FILE");
        }
	}
}
