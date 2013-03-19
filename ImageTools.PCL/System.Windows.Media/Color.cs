namespace System.Windows.Media {
	/// <summary>
	/// Represents an ARGB (alpha, red, green, blue) color.
	/// </summary>
	public struct Color {
		/// <summary>
		/// Creates a new Color structure by using the specified sRGB alpha channel and color channel values.
		/// </summary>
		/// <param name="Alpha">The alpha channel, A, of the new color.</param>
		/// <param name="Red">The red channel, R, of the new color.</param>
		/// <param name="Green">The green channel, G, of the new color.</param>
		/// <param name="Blue">The blue channel, B, of the new color.</param>
		public static Color FromArgb(int Alpha, int Red, int Green, int Blue) {
			// Initialize a new instance of the Color class.
			Color Color = new Color();
			// Sets the sRGB alpha channel value of the color.
			Color.A = (byte) Alpha;
			// Sets the sRGB red channel value of the color.
			Color.R = (byte) Red;
			// Sets the sRGB green channel value of the color.
			Color.G = (byte) Green;
			// Sets the sRGB blue channel value of the color.
			Color.B = (byte) Blue;
			// Return the color.
			return Color;
		}

		/// <summary>
		/// Gets or sets the sRGB alpha channel value of the color.
		/// </summary>
		public byte A { get; set; }

		/// <summary>
		/// Gets or sets the sRGB blue channel value of the color.
		/// </summary>
		public byte B { get; set; }

		/// <summary>
		/// Gets or sets the sRGB green channel value of the color.
		/// </summary>
		public byte G { get; set; }

		/// <summary>
		/// Gets or sets the sRGB red channel value of the color.
		/// </summary>
		public byte R { get; set; }
	}
}