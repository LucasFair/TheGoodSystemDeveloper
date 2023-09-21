using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodSysDev.Model.Text
{
	/// <summary>
	/// Class <c>MakeTextFile</c> is what creates the "necessary file" which the program checks for.
	/// </summary>
	internal class MakeTextFile
	{
		Content content = new Content();
		public void MakeText()
		{
			using (StreamWriter sw = new StreamWriter(content.FilePathAndName))
			{
				sw.WriteLine(content.NeedsToBeInFile);
			}
		}
	}
}
