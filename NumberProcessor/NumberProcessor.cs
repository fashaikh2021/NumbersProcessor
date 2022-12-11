using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NumberProcessor
{
	public class NumberProcessor
	{
		public string ProcessAndWriteToFile(int ValueToProcess)
		{
			Globals.CheckFileExistance();
			string lastEnterredText = "0";
			try
			{
				lastEnterredText = File.ReadLines(Globals.FileName()).Last();
			}
			catch(Exception e)
			{
			//implement log
			}
			int lastOutCome = getValidatedNumberToProcess(lastEnterredText, ValueToProcess);
			File.AppendAllText(Globals.FileName(), lastOutCome.ToString() + Environment.NewLine);
			return lastOutCome.ToString();
		}

		private int getValidatedNumberToProcess(string lastLineOfFile, int ValueToProcess)
		{
			int LastProcessedResult = 0;
			int.TryParse(lastLineOfFile, out LastProcessedResult);
			
			return ProcessedResult(LastProcessedResult, ValueToProcess);
		}

		private int ProcessedResult(int LastProcessedResult, int ValueToProcess)
		{
			return LastProcessedResult + ValueToProcess >= Globals.MaxLimit ? 
				         (LastProcessedResult + ValueToProcess) - Globals.MaxLimit : (LastProcessedResult + ValueToProcess);
		}
	}
}
