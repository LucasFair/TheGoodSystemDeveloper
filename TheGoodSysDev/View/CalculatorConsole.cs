using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.Model.Calculator;

namespace TheGoodSysDev.View
{
	/// <summary>
	/// Class <c>CalculatorConsole</c> contains the output to the console, as well as a byte input. 
	/// </summary>
	internal class CalculatorConsole
	{
		public byte ByteInput()  // Reads the input from 0 - 255.
		{
			return byte.Parse(Console.ReadLine());
		}
		public void WelcomeCalc()
		{
            Console.WriteLine("Welcome to this basic calculator.\nYou can input two numbers, then choose to either\n" +
				"add them together, subtract them, multiply or even divide them.\nHave fun!\n");
        }
		public void EnterNumberA()
		{
            Console.WriteLine("Please enter the first number:\n");
        }
		public void EnterNumberB()
		{
            Console.WriteLine("Please enter the second number:\n");
        }
		public void EnterOperator() 
		{
            Console.WriteLine("Please pick the operator you wish to use:\nA = Addition\nS = Subtract\nM = Multiply\nD = Divison\n");
        }
		public void Result() 
		{
			Console.WriteLine("The result is: ");
		}
	}
}
