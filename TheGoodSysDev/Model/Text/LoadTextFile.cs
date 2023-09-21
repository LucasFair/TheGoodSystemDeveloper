using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.View;
using TheGoodSysDev.Model.ExceptionHandling;

namespace TheGoodSysDev.Model.Text
{
	internal class LoadTextFile
	{
		Content content = new Content();
		AppendExceptionToLog aetl = new AppendExceptionToLog();
		public string ReadText()
		{
			try
			{
				using (StreamReader sr = File.OpenText(content.FilePathAndName + "a"))
				{
					return sr.ReadToEnd();
				}
			}
			catch (FileNotFoundException ex)
			{
				aetl.LogError(ex);
				throw new ArgumentException(content.TextFileUnavailable, ex);
			}
			finally
			{
			
			}
		}
	}
}
