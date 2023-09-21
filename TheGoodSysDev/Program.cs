using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.Controller;

namespace TheGoodSysDev
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ConsoleController conCtr = new ConsoleController();
			conCtr.Run();
		}
	}
}
