namespace System.Windows {
	/// <summary>
	/// Describes the width, height, and location of a rectangle.
	/// </summary>
	public struct Rect {
		/// <summary>
		/// Initializes a new instance of the Rect structure that has the specified x-coordinate, y-coordinate, width, and height.
		/// </summary>
		/// <param name="X">The x-coordinate of the top-left corner of the rectangle.</param>
		/// <param name="Y">The y-coordinate of the top-left corner of the rectangle.</param>
		/// <param name="Width">The width of the rectangle.</param>
		/// <param name="Height">The height of the rectangle.</param>
		public Rect(double X, double Y, double Width, double Height) {
			// Set the height of the rectangle.
			this.Height = Height;
			// Set the width of the rectangle.
			this.Width = Width;
			// Set the x-axis value of the left side of the rectangle.
			this.X = X;
			// Set the y-axis value of the top side of the rectangle.
			this.Y = Y;
		}

		/// <summary>
		/// Gets or sets the height of the rectangle.
		/// </summary>
		public double Height;

		/// <summary>
		/// Gets or sets the width of the rectangle.
		/// </summary>
		public double Width;

		/// <summary>
		/// Gets or sets the x-axis value of the left side of the rectangle.
		/// </summary>
		public double X;

		/// <summary>
		/// Gets or sets the y-axis value of the top side of the rectangle.
		/// </summary>
		public double Y;
	}
}