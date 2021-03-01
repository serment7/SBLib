using System;
using System.Collections.Generic;
using System.Text;
using SBLib.Exception;
using SBLib;

namespace Launcher
{
	public class ServerApp
	{
		public ServerApp(Args inArgs)
		{
			if (LauncherMode.SERVER != inArgs.launcherMode )
			{
				throw new InitializeException($"ServerApp: invalid launcherMode({inArgs.launcherMode})");
			}
		}

		Log logger = new Log("app.server");
	}
}
