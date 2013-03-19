namespace System.IO {
	/// <summary>
	/// When it is called by an elevated-trust application, exposes a Stream around a file, supporting both synchronous and asynchronous read and write operations.
	/// </summary>
	public class FileStream : Stream {
		#region Constructor
		/// <summary>
		/// When it is called by trusted applications, initializes a new instance of the FileStream class with the specified path and creation mode.
		/// </summary>
		/// <param name="Path">A relative or absolute path for the file that the current FileStream object will encapsulate. </param>
		/// <param name="Mode">A FileMode constant that determines how to open or create the file. </param>
		public FileStream(string Path, FileMode Mode) {
			// Return.
			return;
		}
		#endregion

		#region Stream:Methods
		/// <summary>
		/// When overridden in a derived class, clears all buffers for this stream and causes any buffered data to be written to the underlying device.
		/// </summary>
		public override void Flush() {
			// Throw an exception.
			throw new NotImplementedException();
		}

		/// <summary>
		/// When overridden in a derived class, reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.
		/// </summary>
		/// <param name="Buffer">An array of bytes.</param>
		/// <param name="Offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
		/// <param name="Count">The maximum number of bytes to be read from the current stream.</param>
		public override int Read(byte[] Buffer, int Offset, int Count) {
			// Throw an exception.
			throw new NotImplementedException();
		}

		/// <summary>
		/// When overridden in a derived class, sets the position within the current stream.
		/// </summary>
		/// <param name="Offset">A byte offset relative to the origin parameter.</param>
		/// <param name="Origin">A value of type SeekOrigin indicating the reference point used to obtain the new position.</param>
		public override long Seek(long Offset, SeekOrigin Origin) {
			// Throw an exception.
			throw new NotImplementedException();
		}

		/// <summary>
		/// When overridden in a derived class, sets the length of the current stream.
		/// </summary>
		/// <param name="Value">The desired length of the current stream in bytes.</param>
		public override void SetLength(long Value) {
			// Throw an exception.
			throw new NotImplementedException();
		}

		/// <summary>
		/// When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.
		/// </summary>
		/// <param name="Buffer">An array of bytes.</param>
		/// <param name="Offset">The zero-based byte offset in buffer at which to begin copying bytes to the current stream.</param>
		/// <param name="Count">The number of bytes to be written to the current stream.</param>
		public override void Write(byte[] Buffer, int Offset, int Count) {
			// Throw an exception.
			throw new NotImplementedException();
		}
		#endregion

		#region Stream:Properties
		/// <summary>
		/// When overridden in a derived class, gets a value indicating whether the current stream supports reading.
		/// </summary>
		public override bool CanRead {
			get {
				// Throw an exception.
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// When overridden in a derived class, gets a value indicating whether the current stream supports seeking.
		/// </summary>
		public override bool CanSeek {
			get {
				// Throw an exception.
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// When overridden in a derived class, gets a value indicating whether the current stream supports writing.
		/// </summary>
		public override bool CanWrite {
			get {
				// Throw an exception.
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// When overridden in a derived class, gets the length in bytes of the stream.
		/// </summary>
		public override long Length {
			get {
				// Throw an exception.
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// When overridden in a derived class, gets or sets the position within the current stream.
		/// </summary>
		public override long Position {
			get {
				// Throw an exception.
				throw new NotImplementedException();
			}
			set {
				// Throw an exception.
				throw new NotImplementedException();
			}
		}
		#endregion
	}
}