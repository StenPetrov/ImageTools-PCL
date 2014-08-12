using KeyJ;
using System;
using System.IO;

namespace ImageTools.IO.Jpeg {
	/// <summary>
	/// Image decoder for generating an image out of an jpg stream.
	/// </summary>
	public class JpegDecoderNano : IImageDecoder {
		#region IImageDecoder
		/// <summary>
		/// Gets the size of the header for this image type.
		/// </summary>
		public int HeaderSize {
			get {
				return 11;
			}
		}

		/// <summary>
		/// Indicates if the image decoder supports the specified file extension.
		/// </summary>
		/// <param name="Extension">The file extension.</param>
		public bool IsSupportedFileExtension(string Extension) {
			return Extension.ToUpper() == "JPG" || Extension.ToUpper() == "JPEG";
		}

		/// <summary>
		/// Indicates if the image decoder supports the specified file header.
		/// </summary>
		/// <param name="Header">The file header.</param>
		public bool IsSupportedFileFormat(byte[] Header) {
			return Header.Length >= 11 && Header[6] == 0x4A && Header[7] == 0x46 && Header[8] == 0x49 && Header[9] == 0x46 && Header[10] == 0x00;
		}

		/// <summary>
		/// Decodes the image from the specified stream and sets the data to image.
		/// </summary>
		/// <param name="Image">The image, where the data should be set to. Cannot be null (Nothing in Visual Basic).</param>
		/// <param name="Stream">The stream, where the image should be decoded from. Cannot be null (Nothing in Visual Basic).</param>
		public void Decode(ExtendedImage Image, Stream Stream) {
			// Initialize the input.
			byte[] Input = Stream is MemoryStream ? ((MemoryStream) Stream).ToArray() : null;
			// Initialize a new instance of the NanoJPEG class.
			NanoJPEG NanoJPEG = new NanoJPEG();
			// Check if the input is invalid.
			if (Input == null) {
				// Initialize a new instance of the MemoryStream class.
				using (MemoryStream MemoryStream = new MemoryStream()) {
					// Initialize the buffer.
					byte[] Buffer = new byte[16 * 1024];
					// Initialize the number of bytes read.
					int Read;
					// Read bytes and check if reading was successful.
					while ((Read = Stream.Read(Buffer, 0, Buffer.Length)) > 0) {
						// Write the read bytes.
						MemoryStream.Write(Buffer, 0, Read);
					}
					// Set the input.
					Input = MemoryStream.ToArray();
				}
			}
			// Decode the image.
			if (NanoJPEG.njDecode(Input) == nj_result_t.NJ_OK) {
				// Initialize the status indicating color.
				bool IsColor = NanoJPEG.njIsColor();
				// Initialize the RGB-formatted image..
				byte[] Output = NanoJPEG.njGetImage();
				// Initialzie the iterator.
				int i = Output.Length - 3, Height = NanoJPEG.njGetHeight(), Width = NanoJPEG.njGetWidth();
				// Initialize NanoJPEG to dispose of copies.
				NanoJPEG.njInit();
				// Check if the image has color.
				if (IsColor) {
					// Resize the RGB-formatted image to accommendate RGBA-formatting.
					Array.Resize(ref Output, Output.Length * 4 / 3);
					// Iterate through each pixel in the RGB-formatting.
					for (int j = Output.Length - 4; i >= 0; i -= 3, j -= 4) {
						// Change the pixel from RGB-formatting to RGBA-formatting.
						Buffer.BlockCopy(Output, i, Output, j, 3);
						// Set the alpha channel for the pixel.
						Output[j + 3] = 0;
					}
				} else {
					// Resize the Grayscale image to accommendate RGBA-formatting.
					Array.Resize(ref Output, Output.Length * 4);
					// Iterate through each pixel in the RGB-formatting.
					for (int j = Output.Length - 4; i >= 0; i -= 3, j -= 4) {
						// Change the pixel from Grayscale to RGBA-formatting.
						Output[j] = Output[j + 1] = Output[j + 2] = Output[i];
						// Set the alpha channel for the pixel.
						Output[j + 3] = 0;
					}
				}
				// Return the RGBA-formatted image.
				Image.SetPixels(Width, Height, Output);
			}
		}
		#endregion
	}
}