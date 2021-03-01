using System;
using System.Collections.Generic;
using System.Text;
using SBLib.Exception;
using SBLib;
using System.Linq;

namespace Launcher
{
	public class Args
	{
		Log logger = new Log("app.args");
		public Args(string[] inArgs)
		{
			args = inArgs;
			List<String> launcherModeList = Enum.GetNames(typeof(LauncherMode)).ToList();

			foreach (string arg in args)
			{
				if (launcherModeList.Exists(x => x == arg))
				{
					launcherMode = Enum.Parse<LauncherMode>(arg);
					return;
				}
			}
			
			if(launcherMode == LauncherMode.NONE)
			{
				throw logger.PrintException(new InitializeException("unknown launcherMode"));
			}
		}

		public string[] args;
		public LauncherMode launcherMode;
	}
}
