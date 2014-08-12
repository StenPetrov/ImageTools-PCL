using System.Windows.Resources;

namespace System.Windows {
	/// <summary>
	/// Encapsulates a Silverlight application.
	/// </summary>
	public class Application {
		/// <summary>
		/// Gets the Application object for the current application.
		/// </summary>
		public static Application Current {
			get {
				// Return null.
				return null;
			}
		}

		/// <summary>
		/// Returns a resource file from a location in the application package.
		/// </summary>
		/// <param name="UriResource">A relative URI that identifies the resource file to be loaded. The URI is relative to the application package and does not need a leading forward slash. </param>
		public static StreamResourceInfo GetResourceStream(Uri UriResource) {
			// Return null.
			return null;
		}
	}
}