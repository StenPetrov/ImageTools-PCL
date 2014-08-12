using System.IO;

namespace System.Net {
	/// <summary>
	/// Provides data for the OpenReadCompleted event.
	/// </summary>
	public class OpenReadCompletedEventArgs : EventArgs {
		/// <summary>
		/// Gets a value that indicates which error occurred during an asynchronous operation.
		/// </summary>
		public Exception Error { get; private set;  }

		/// <summary>
		/// Gets a readable stream that contains the results of the OpenReadAsync method.
		/// </summary>
		public Stream Result { get; private set; }
	}
}