namespace System.Net {
	/// <summary>
	/// Provides data for the event that is raised when there is an exception that is not handled in any application domain.
	/// </summary>
	public class UnhandledExceptionEventArgs : EventArgs {
		/// <summary>
		/// Initializes a new instance of the UnhandledExceptionEventArgs class with the exception object and a common language runtime termination flag.
		/// </summary>
		/// <param name="Exception">The exception that is not handled.</param>
		/// <param name="IsTerminating">True if the runtime is terminating; otherwise, false.</param>
		public UnhandledExceptionEventArgs(object Exception, bool IsTerminating) {
			// Set the exception that is not handled.
			this.Exception = Exception;
		}

		/// <summary>
		/// The exception that is not handled.
		/// </summary>
		public object Exception { get; private set; }
	}
}