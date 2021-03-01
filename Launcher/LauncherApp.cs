using System;
using SBLib;

namespace Launcher
{
	class LauncherApp
	{
		static void Main(string[] inArgs)
		{
			Log logger = null;
			try
			{
				string logConfigPath = "..\\config\\log4net.xml";
				logConfigPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), logConfigPath);

				LogManager.Init(logConfigPath);

				logger = new Log("app.launcher");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);

				return;
			}

			try
			{
				Args args = new Args(inArgs);

			}
			catch(SBLib.ExceptionHandle exceptionHandle)
			{
				logger.PrintException(exceptionHandle);
			}
			catch(Exception ex)
			{
				logger.PrintFatal(ex.Message);
			}
		}
	}
}
