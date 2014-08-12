namespace System.Net {
	/// <summary>
	/// Provides common methods for sending data to and receiving data from a resource identified by a URI.
	/// </summary>
	public class WebClient {
		/// <summary>
		/// Opens a readable stream to the specified resource.
		/// </summary>
		/// <param name="Address">The location of the resource to be downloaded.</param>
		public void OpenReadAsync(Uri Address) {
			// Return.
			return;
		}

		#pragma warning disable 67
		/// <summary>
		/// Occurs when an asynchronous download operation successfully transfers some or all of the data.
		/// </summary>
		public event DownloadProgressChangedEventHandler DownloadProgressChanged;

		/// <summary>
		/// Occurs when an asynchronous resource-read operation is completed.
		/// </summary>
		public event OpenReadCompletedEventHandler OpenReadCompleted;
		#pragma warning restore 67
	}
}