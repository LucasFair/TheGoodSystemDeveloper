using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodSysDev.Model.ExceptionHandling;

namespace TheGoodSysDev.Model.Text
{
	internal class CheckTextFile
	{
		/// <summary>
		/// Class <c>CheckFile</c> checks if the necessary file exists and tells the controller whether or not to create one.
		/// </summary>
		Content content = new Content();
		public bool CheckFile()
		{
			if (File.Exists(content.FilePathAndName))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
