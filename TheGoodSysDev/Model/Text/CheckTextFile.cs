using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodSysDev.Model.Text
{
	internal class CheckTextFile
	{
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
