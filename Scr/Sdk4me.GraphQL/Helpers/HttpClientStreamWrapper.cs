using System.IO;
using System.Net.Http;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Helper class that wraps an HttpClient and a Stream to ensure proper disposal of both.
    /// </summary>
    internal class HttpClientStreamWrapper : Stream
    {
        private readonly Stream innerStream;
        private readonly HttpClient client;
        private bool disposed = false;

        /// <summary>
        /// Gets a value indicating whether the current stream supports reading.
        /// </summary>
        public override bool CanRead
        {
            get => innerStream.CanRead;
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking.
        /// </summary>
        public override bool CanSeek 
        {
            get => innerStream.CanSeek; 
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports writing.
        /// </summary>
        public override bool CanWrite 
        {
            get => innerStream.CanWrite;
        }

        /// <summary>
        /// Gets the length of the stream in bytes.
        /// </summary>
        public override long Length
        {
            get => innerStream.Length; 
        }

        /// <summary>
        /// Gets or sets the position within the current stream.
        /// </summary>
        public override long Position 
        {
            get => innerStream.Position;
            set => innerStream.Position = value; 
        }

        /// <summary>
        /// Clears all buffers for this stream and causes any buffered data to be written to the underlying device.
        /// </summary>
        public override void Flush()
        {
            innerStream.Flush();
        }

        /// <summary>
        /// Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.
        /// </summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in the buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero if the end of the stream has been reached.</returns>
        public override int Read(byte[] buffer, int offset, int count)
        {
            return innerStream.Read(buffer, offset, count);
        }

        /// <summary>
        /// Sets the position within the current stream.
        /// </summary>
        /// <param name="offset">A byte offset relative to the origin parameter.</param>
        /// <param name="origin">A value of type SeekOrigin indicating the reference point used to obtain the new position.</param>
        /// <returns>The new position within the current stream.</returns>
        public override long Seek(long offset, SeekOrigin origin)
        {
            return innerStream.Seek(offset, origin);
        }

        /// <summary>
        /// Sets the length of the current stream.
        /// </summary>
        /// <param name="value">The desired length of the current stream in bytes.</param>
        public override void SetLength(long value)
        {
            innerStream.SetLength(value);
        }

        /// <summary>
        /// Writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.
        /// </summary>
        /// <param name="buffer">An array of bytes. This method copies count bytes from buffer to the current stream.</param>
        /// <param name="offset">The zero-based byte offset in the buffer at which to begin copying bytes to the current stream.</param>
        /// <param name="count">The number of bytes to be written to the current stream.</param>
        public override void Write(byte[] buffer, int offset, int count)
        {
            innerStream.Write(buffer, offset, count);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientStreamWrapper"/> class.
        /// </summary>
        /// <param name="client">The HttpClient instance to wrap.</param>
        /// <param name="innerStream">The inner Stream instance to wrap.</param>
        public HttpClientStreamWrapper(HttpClient client, Stream innerStream)
        {
            this.client = client;
            this.innerStream = innerStream;
        }

        /// <summary>
        /// Releases the unmanaged resources used by the Stream and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    innerStream.Dispose();
                    client.Dispose();
                }
                disposed = true;
            }
            base.Dispose(disposing);
        }
    }
}
