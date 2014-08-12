using System.Globalization;

namespace ImageTools {
	/// <summary>
	/// Represents the class containing extensions for the String class.
	/// </summary>
	public static class StringExtension {
		/// <summary>
		/// Returns a copy of this string converted to uppercase, using the casing rules of the specified culture.
		/// </summary>
		/// <param name="Subject">The subject.</param>
		/// <param name="Culture">An object that supplies culture-specific casing rules.</param>
		public static string ToUpper(this string Subject, CultureInfo Culture) {
			// Return the uppercase value.
			return Subject.ToUpper();
		}
	}
}