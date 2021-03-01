using System;
using System.Collections.Generic;
using System.Text;

namespace SBLib.Exception
{
	public class InitializeException : ExceptionHandle
	{
		public InitializeException(String inMessage) : base(ExceptionLevel.FATAL, ExceptionCode.FAILED_INITIALIZE, inMessage)
		{
		}
	}
}
