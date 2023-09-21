using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.Model.ExceptionHandling;
using TheGoodSysDev.View;

namespace TheGoodSysDev.Model.Calculator
{
	/// <summary>
	/// Class <c>BasicCalculator</c> is a simple calculator, which is mainly here for the sake of breakage.
	/// </summary>
	internal class BasicCalculator
	{
		CalculatorConsole calcCon = new CalculatorConsole();
		AppendExceptionToLog aetl = new AppendExceptionToLog();
		Content content = new Content();

		byte numA;
		byte numB;
		char oprt;
		public void CalcNumA()
		{
			numA = calcCon.ByteInput();
		}
		public void CalcNumB()
		{
			numB = calcCon.ByteInput();
		}
		public byte CalculatorOperator()  // Spaghetti
		{
			try
			{
				oprt = (char)Console.ReadKey(true).Key;
				switch (oprt)
				{
					case (char)ConsoleKey.A:
						return (byte)(numA + numB);
					case (char)ConsoleKey.S:
						return (byte)(numA - numB);
					case (char)ConsoleKey.M:
						return (byte)(numA * numB);
					case (char)ConsoleKey.D:
						return (byte)(numA / numB);
					default:
						throw new Exception();
				}
			}
			catch (DivideByZeroException dbze)
			{
				aetl.LogError(dbze);
				throw new ArgumentException(content.CannotDivideZero, dbze);
			}
			catch (OverflowException ofe)
			{
				aetl.LogError(ofe);
				throw new ArgumentException(content.OverflowValue, ofe);
			}
			catch (FormatException fe)
			{
				aetl.LogError(fe);
				throw new ArgumentException(content.NoInput, fe);
			}

			finally
			{
				Debug.WriteLine("Please check the log file for more information.");
			}
		}
		public void PrintResult()
		{
			Console.WriteLine(CalculatorOperator());
		}
	}
}
