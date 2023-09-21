using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.Model.Calculator;
using TheGoodSysDev.Model.ExceptionHandling;
using TheGoodSysDev.Model.Text;
using TheGoodSysDev.View;

namespace TheGoodSysDev.Controller
{
	/// <summary>
	/// Class <c>ConsoleController</c> contains the methods that will be output to the console.
	/// </summary>
	internal class ConsoleController
	{
		Message cMsg = new Message();
		CheckTextFile ctf = new CheckTextFile();
		MakeTextFile makeText = new MakeTextFile();
		TextToConsole ttc = new TextToConsole();
		MakeAppendLogFile makeLog = new MakeAppendLogFile();
		Menu menu = new Menu();
		FindHappiness fh = new FindHappiness();
		BasicCalculator calc = new BasicCalculator();
		CalculatorConsole calcCon = new CalculatorConsole();
		
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
						FileMenu();
						break;
					case ConsoleKey.D2:
						cMsg.ClearConsole();
						ttc.OpenPrintText();
						break;
					case ConsoleKey.D3:
						cMsg.ClearConsole();
						calcCon.WelcomeCalc();
						calcCon.EnterNumberA();
						calc.CalcNumA();
						calcCon.EnterNumberB();
						calc.CalcNumB();
						calcCon.EnterOperator();
						calcCon.Result();
						calc.PrintResult();
						cMsg.WaitForInput();
						cMsg.ClearConsole();
						MainMenu();
						break;
					case ConsoleKey.D4:
						cMsg.ClearConsole();
						fh.GetHappiness();
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
						throw new NotImplementedException("Not implemented yet.");
						
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
