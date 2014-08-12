namespace System.Net {
	/// <summary>
	/// Represents the method that will handle the OpenReadCompleted event of a WebClient.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A OpenReadCompletedEventArgs containing event data.</param>
	public delegate void OpenReadCompletedEventHandler(object sender, OpenReadCompletedEventArgs e);
}