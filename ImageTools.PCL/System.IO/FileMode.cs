namespace System.IO {
	/// <summary>
	/// Specifies how the operating system should open a file.
	/// </summary>
	public enum FileMode {
		/// <summary>
		/// Specifies that the operating system should open an existing file. The ability to open the file is dependent on the value specified by FileAccess. A System.IO.FileNotFoundException is thrown if the file does not exist.
		/// </summary>
		Open
	}
}