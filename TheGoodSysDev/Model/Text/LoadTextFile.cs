using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.View;
using TheGoodSysDev.Model.ExceptionHandling;
using System.Diagnostics;

namespace TheGoodSysDev.Model.Text
{
	/// <summary>
	/// Class <c>LoadTextFile</c> reads the file from its path.
	/// </summary>
	internal class LoadTextFile
	{
		Content content = new Content();
		AppendExceptionToLog aetl = new AppendExceptionToLog();
		public string ReadText()
		{
			try
			{
				using (StreamReader sr = File.OpenText(content.FilePathAndName + "a"))  // Purposely forces a "File Not Found Exception"
																						// in order to get the error here 
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
				Debug.WriteLine("The file could not be found. Please check the path location.");
			}
		}
	}
}
