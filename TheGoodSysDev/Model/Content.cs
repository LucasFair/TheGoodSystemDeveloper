using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodSysDev.Model
{
	internal class Content
	{
		internal string NeedsToBeInFile = "This needs to be in the text file.";
		internal string TextFileUnavailable = "The file does not exist. You may have to generate the file before you can load it.";
		internal string MakeAppendLogError = "The application ran into an error in regards to the log file and its creation or appending.";
		internal string CannotDivideZero = "Division by zero was attempted.";
		internal string OverflowValue = "The input was either higher or lower than what is allowed.";
		internal string InvalidInput = "There was either no input, or the input was not of the correct data type.";
		internal string Happiness = "There is no such thing as happiness. Don't be absurd.";
		internal string FilePathAndName = @"C:\Users\Fair\Documents\Hovedforløb\H1\ExceptionHandling\TheGoodSysDev\Asset\NeededFile.txt";
		internal string LogPathAndName = @"C:\Users\Fair\Documents\Hovedforløb\H1\ExceptionHandling\TheGoodSysDev\Asset\LogFile.log";
	}
}
