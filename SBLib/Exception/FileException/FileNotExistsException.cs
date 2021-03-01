
namespace SBLib.Exception
{
	public class FileNotExistsException : ExceptionHandle
	{
		public FileNotExistsException(string inMessage) : base(ExceptionLevel.FATAL, ExceptionCode.FILE_NOT_EXISTS, inMessage)
		{
			
		}
	}
}
