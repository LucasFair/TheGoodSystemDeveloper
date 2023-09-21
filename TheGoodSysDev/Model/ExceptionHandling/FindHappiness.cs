using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodSysDev.Model.ExceptionHandling
{
	/// <summary>
	/// Class <c>FindHappiness</c> will grant the user eternal happiness.
	/// </summary>
	internal class FindHappiness
	{
		AppendExceptionToLog aetl = new AppendExceptionToLog();
		public void GetHappiness()
		{
			try
			{
				throw new NotImplementedException();
			}
			catch (NotImplementedException nie)
			{
				aetl.LogError(nie);
				throw new NotImplementedException();
			}
		}
	}
}
