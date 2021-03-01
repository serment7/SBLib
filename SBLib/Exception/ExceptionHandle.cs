using System;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace SBLib
{
	public abstract class ExceptionHandle : System.Exception
	{
		public ExceptionHandle(ExceptionLevel inExceptionLevel, ExceptionCode inExceptionCode, string inMessage = "")
			: base(inMessage)
		{
			ExceptionCode = inExceptionCode;
			ExceptionLevel = inExceptionLevel;
		}

		public ExceptionHandle(ExceptionCode inExceptionCode, string inMessage = "")
			: base(inMessage)
		{
			ExceptionCode = inExceptionCode;
			ExceptionLevel = ExceptionLevel.ERROR;
		}

		public string GetMessage()
		{
			return $"Exception Level: {ExceptionLevel}, Code: {ExceptionCode}, Msg: {base.Message}";
		}

		public override string Message => GetMessage();

		public override string ToString()
		{
			return GetMessage();
		}

		public ExceptionCode ExceptionCode { get; } = ExceptionCode._NONE;
		public ExceptionLevel ExceptionLevel { get; } = ExceptionLevel.NONE;
	}
}
