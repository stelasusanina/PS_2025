using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Helpers
{
	public class Delegates
	{
		public static readonly ILogger logger = LoggerHelper.GetLogger("Hello");
		public static readonly ILogger loggerFile = LoggerHelper.GetLogger("FileLogger");
		public static void Log(string error)
		{
			logger.LogError(error);
		}
		public static void Log2(string error)
		{
            Console.WriteLine("- DELEGATES -");
            Console.WriteLine($"{error}");
            Console.WriteLine("- DELEGATES -");
		}
		public static void LogFile(string message)
		{
			loggerFile.LogInformation(message);
		}
	}
}
