using System.Reflection;

namespace System.Reflection {
	/// <summary>
	/// Represents the class containing extensions for the Assembly class.
	/// </summary>
	public static class AssemblyExtension {
		/// <summary>
		/// Gets an AssemblyName for this assembly.
		/// </summary>
		/// <param name="Assembly">The assembly.</param>
		public static AssemblyName GetName(this Assembly Assembly) {
			// Return a new instance of the AssemblyName class.
			return new AssemblyName(Assembly.FullName);
		}
	}
}