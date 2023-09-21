using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodSysDev.Model.ExceptionHandling
{
	internal class MakeAppendLogFile
	{
		Content content = new Content();
		DateTime currDT = DateTime.Now;
		public void MakeLog()
		{
			try
			{
				if (!File.Exists(content.LogPathAndName))
				{

					using (StreamWriter sw = new StreamWriter(content.LogPathAndName))
					{
						sw.WriteLine($"|{currDT}|\n");
					}
				}
				else
					using (StreamWriter sw = new StreamWriter(content.LogPathAndName, append: true))
					{
						sw.WriteLine($"|{currDT}|\n");
						
					}
			}
			catch (Exception e)
			{
				throw new ArgumentException(content.MakeAppendLogError, e);
			}
		}
	}
}




