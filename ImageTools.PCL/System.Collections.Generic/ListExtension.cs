using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System {
	/// <summary>
	/// Represents the class containing extensions for the List class.
	/// </summary>
	public static class ListExtension {
		/// <summary>
		/// Returns a read-only IList wrapper for the current collection.
		/// </summary>
		/// <param name="Subject">The subject.</param>
		public static ReadOnlyCollection<T> AsReadOnly<T>(this List<T> Subject) {
			// Initialize a new instance of the ReadOnlyCollection class.
			return new ReadOnlyCollection<T>(Subject);
		}
	}
}