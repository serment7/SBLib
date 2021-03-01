using System;
using System.Collections.Generic;
using System.Text;

namespace SBLib.Exception
{
	public class FileExistsException : ExceptionHandle
	{
		public FileExistsException(ExceptionCode inExceptionCode, String inMessage = "") : base(inExceptionCode, inMessage)
		{
		}

		public FileExistsException(ExceptionLevel inExceptionLevel, ExceptionCode inExceptionCode, String inMessage = "") : base(inExceptionLevel, inExceptionCode, inMessage)
		{
		}
	}
}
