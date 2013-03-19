namespace System {
	/// <summary>
	/// The exception that is thrown when a non-fatal application error occurs.
	/// </summary>
	public class ApplicationException : Exception {
		/// <summary>
		/// Initializes a new instance of the ApplicationException class.
		/// </summary>
		public ApplicationException() { }

		/// <summary>
		/// Initializes a new instance of the ApplicationException class with a specified error message.
		/// </summary>
		/// <param name="Message">A message describing the exception.</param>
		public ApplicationException(string Message)	{ }

		/// <summary>
		/// Initializes a new instance of the ApplicationException class with a specified error message and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="Message">The error message that explains the reason for the exception.</param>
		/// <param name="InnerException">The exception that is the cause of the current exception.</param>
		public ApplicationException(string Message, Exception InnerException) { }
	}
}