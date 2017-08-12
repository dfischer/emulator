namespace Roluan.Emulator.Common.Exceptions
{
	/// <summary>
	/// Raised when an object is null
	/// </summary>
	public class TNullObjectException : TernaryException
	{
		public TNullObjectException(string message)
			: base(message)
		{
		}
	}
}