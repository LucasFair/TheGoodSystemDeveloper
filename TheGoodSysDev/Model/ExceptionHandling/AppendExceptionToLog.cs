using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodSysDev.Model.ExceptionHandling
{
	/// <summary>
	/// Class <c>AppendExceptionToLog</c> is used to reference and receive eceptions for error logging.
	/// </summary>
	internal class AppendExceptionToLog
	{
		Content content = new Content();

		public void LogError(Exception ex)
		{
			if (!File.Exists(content.LogPathAndName))
			{
				// Error message
			}
			else
				using (StreamWriter sw = new StreamWriter(content.LogPathAndName, append: true))
				{
					sw.WriteLine($"Error: {ex.Message}");
				}
		}


	}
}
