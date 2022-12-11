using System;
using System.IO;

namespace NumberProcessor
{
	public static class Globals
	{
		public static int MaxLimit = 152;
		public static string FileName() => "storage.txt";

		internal static void CheckFileExistance()
		{
			if (!File.Exists(FileName())) { File.Create(FileName()); }
		}
	}
}
