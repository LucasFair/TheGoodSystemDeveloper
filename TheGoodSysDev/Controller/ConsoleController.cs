using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.Model.ExceptionHandling;
using TheGoodSysDev.Model.Text;
using TheGoodSysDev.View;

namespace TheGoodSysDev.Controller
{
	internal class ConsoleController
	{
		Message cMsg = new Message();
		CheckTextFile ctf = new CheckTextFile();
		MakeTextFile makeText = new MakeTextFile();
		TextToConsole ttc = new TextToConsole();
		MakeAppendLogFile makeLog = new MakeAppendLogFile();
		Menu menu = new Menu();
		public void Run()
		{
			makeLog.MakeLog();
			MainMenu();
		}
		public void MainMenu()
		{
			cMsg.ClearConsole();
			menu.MainMenuGUI();
			while (true)
			{
				var selectIn = Console.ReadKey(true).Key;
				switch (selectIn)
				{
					case ConsoleKey.D1:
						cMsg.ClearConsole();
						menu.FileMenuGUI();
						break;
					case ConsoleKey.D2:
						cMsg.ClearConsole();
						ttc.OpenPrintText();
						break;
					case ConsoleKey.D0:
						cMsg.ClearConsole();
						cMsg.Exiting();
						Environment.Exit(0);
						break;
					default:
						break;
				}
			}
		}
		public void FileMenu()
		{
			cMsg.ClearConsole();
			while (true)
			{
				menu.FileMenuGUI();
				var selectIn = Console.ReadKey(true).Key;
				switch (selectIn)
				{
					case ConsoleKey.D1:
						cMsg.ClearConsole();
						GenerateTextFile();
						break;
					case ConsoleKey.D2:
						cMsg.ClearConsole();
						break;
					case ConsoleKey.Backspace:
						cMsg.ClearConsole();
						MainMenu();
						break;
					default:
						break;
				}
			}
		}
		public void GenerateTextFile()
		{
			if (ctf.CheckFile() == false)
			{
				cMsg.DoesNotExist();
				cMsg.WaitForInput();
				cMsg.ClearConsole();
				cMsg.WantToCreateText();
				cMsg.ConfirmDialog();
				makeText.MakeText();
				cMsg.CreatedTextFileSuccess();
			}
			else
			{
				cMsg.AlreadyExist();

				ttc.OpenPrintText();
			}
		}
	}
}
