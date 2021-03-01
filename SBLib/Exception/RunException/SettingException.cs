using System;
using System.Collections.Generic;
using System.Text;

namespace SBLib.Exception
{
	public class SettingException : ExceptionHandle
	{
		public SettingException(String inMessage) : base(ExceptionLevel.FATAL, ExceptionCode.INVALID_SETTING, inMessage)
		{
		}
	}
}
