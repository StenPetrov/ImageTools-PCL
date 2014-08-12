using System.IO;

namespace System.Windows.Resources {
	/// <summary>
	/// Provides resource stream information for application resources or other packages obtained through the GetResourceStream method.
	/// </summary>
	public class StreamResourceInfo {
		/// <summary>
		/// Gets the stream that is contained by the resource.
		/// </summary>
		public Stream Stream {
			get {
				// Return null.
				return null;
			}
		}
	}
}