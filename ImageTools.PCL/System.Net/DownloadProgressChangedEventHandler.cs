namespace System.Net {
	/// <summary>
	/// Represents the method that will handle the WebClient.DownloadProgressChanged event of a WebClient.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A DownloadProgressChangedEventArgs containing event data.</param>
	public delegate void DownloadProgressChangedEventHandler(object sender, DownloadProgressChangedEventArgs e);
}