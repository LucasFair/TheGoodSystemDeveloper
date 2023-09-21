using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.Model;

namespace TheGoodSysDev.View
{
	internal class Message
	{
		public ConsoleKey WaitForInput()
		{
			var key = Console.ReadKey(true).Key;
			return key;
		}
		public void ClearConsole()
		{
			Console.Clear();
		}

		public void TextFileContent()
		{
            Console.WriteLine();
        }

		public void Exiting()
		{
            Console.WriteLine("Thank you for using this application.\nHave a nice day!\n");
        }
		public void AlreadyExist()
		{
			Console.WriteLine("The file already exists.");
		}
		public void DoesNotExist()
		{
			Console.WriteLine("The file does not exist.");
		}
		public void ConfirmDialog()
		{
			Console.WriteLine("Press Y for yes, or N for no");
		}

		public void WantToCreateText()
		{
			Console.WriteLine("Would you like to create the text file?");
		}
		public void CreatedTextFileSuccess()
		{
			Console.WriteLine("The text file has been created successfully!");
		}
	}
}
