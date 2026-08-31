// Decompiled with JetBrains decompiler
// Type: Microsoft.IO.RecyclableMemoryStream
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.IO;

#nullable disable
namespace Microsoft.IO;

/// <summary>
/// MemoryStream implementation that deals with pooling and managing memory streams which use potentially large
/// buffers.
/// </summary>
/// <remarks>
/// This class works in tandem with the RecylableMemoryStreamManager to supply MemoryStream
/// objects to callers, while avoiding these specific problems:
/// 1. LOH allocations - since all large buffers are pooled, they will never incur a Gen2 GC
/// 2. Memory waste - A standard memory stream doubles its size when it runs out of room. This
/// leads to continual memory growth as each stream approaches the maximum allowed size.
/// 3. Memory copying - Each time a MemoryStream grows, all the bytes are copied into new buffers.
/// This implementation only copies the bytes when GetBuffer is called.
/// 4. Memory fragmentation - By using homogeneous buffer sizes, it ensures that blocks of memory
/// can be easily reused.
/// 
/// The stream is implemented on top of a series of uniformly-sized blocks. As the stream's length grows,
/// additional blocks are retrieved from the memory manager. It is these blocks that are pooled, not the stream
/// object itself.
/// 
/// The biggest wrinkle in this implementation is when GetBuffer() is called. This requires a single
/// contiguous buffer. If only a single block is in use, then that block is returned. If multiple blocks
/// are in use, we retrieve a larger buffer from the memory manager. These large buffers are also pooled,
/// split by size--they are multiples of a chunk size (1 MB by default).
/// 
/// Once a large buffer is assigned to the stream the blocks are NEVER again used for this stream. All operations take place on the
/// large buffer. The large buffer can be replaced by a larger buffer from the pool as needed. All blocks and large buffers
/// are maintained in the stream until the stream is disposed (unless AggressiveBufferReturn is enabled in the stream manager).
/// 
/// </remarks>
public sealed class RecyclableMemoryStream : MemoryStream
{
  /// <summary>Allocate a new RecyclableMemoryStream object.</summary>
  /// <param name="memoryManager">The memory manager.</param>
  public RecyclableMemoryStream(RecyclableMemoryStreamManager memoryManager);

  /// <summary>Allocate a new RecyclableMemoryStream object.</summary>
  /// <param name="memoryManager">The memory manager.</param>
  /// <param name="tag">A string identifying this stream for logging and debugging purposes.</param>
  public RecyclableMemoryStream(RecyclableMemoryStreamManager memoryManager, string tag);

  /// <summary>Allocate a new RecyclableMemoryStream object.</summary>
  /// <param name="memoryManager">The memory manager.</param>
  /// <param name="tag">A string identifying this stream for logging and debugging purposes.</param>
  /// <param name="requestedSize">The initial requested size to prevent future allocations.</param>
  public RecyclableMemoryStream(
    RecyclableMemoryStreamManager memoryManager,
    string tag,
    int requestedSize);

  ~RecyclableMemoryStream();

  /// <summary>
  /// Returns the memory used by this stream back to the pool.
  /// </summary>
  /// <param name="disposing">Whether we're disposing (true), or being called by the finalizer (false).</param>
  protected override void Dispose(bool disposing);

  /// <summary>Equivalent to Dispose.</summary>
  public override void Close();

  /// <summary>Gets or sets the capacity.</summary>
  /// <remarks>Capacity is always in multiples of the memory manager's block size, unless
  /// the large buffer is in use.  Capacity never decreases during a stream's lifetime.
  /// Explicitly setting the capacity to a lower value than the current value will have no effect.
  /// This is because the buffers are all pooled by chunks and there's little reason to
  /// allow stream truncation.
  /// </remarks>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public override int Capacity { get; set; }

  /// <summary>Gets the number of bytes written to this stream.</summary>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public override long Length { get; }

  /// <summary>Gets the current position in the stream.</summary>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public override long Position { get; set; }

  /// <summary>Whether the stream can currently read.</summary>
  public override bool CanRead { get; }

  /// <summary>Whether the stream can currently seek.</summary>
  public override bool CanSeek { get; }

  /// <summary>Always false.</summary>
  public override bool CanTimeout { get; }

  /// <summary>Whether the stream can currently write.</summary>
  public override bool CanWrite { get; }

  /// <summary>
  /// Returns a single buffer containing the contents of the stream.
  /// The buffer may be longer than the stream length.
  /// </summary>
  /// <returns>A byte[] buffer.</returns>
  /// <remarks>IMPORTANT: Doing a Write() after calling GetBuffer() invalidates the buffer. The old buffer is held onto
  /// until Dispose is called, but the next time GetBuffer() is called, a new buffer from the pool will be required.</remarks>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public override byte[] GetBuffer();

  /// <summary>
  /// Returns a new array with a copy of the buffer's contents. You should almost certainly be using GetBuffer combined with the Length to
  /// access the bytes in this stream. Calling ToArray will destroy the benefits of pooled buffers, but it is included
  /// for the sake of completeness.
  /// </summary>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  [Obsolete("This method has degraded performance vs. GetBuffer and should be avoided.")]
  public override byte[] ToArray();

  /// <summary>
  /// Reads from the current position into the provided buffer.
  /// </summary>
  /// <param name="buffer">Destination buffer.</param>
  /// <param name="offset">Offset into buffer at which to start placing the read bytes.</param>
  /// <param name="count">Number of bytes to read.</param>
  /// <returns>The number of bytes read.</returns>
  /// <exception cref="T:System.ArgumentNullException">buffer is null.</exception>
  /// <exception cref="T:System.ArgumentOutOfRangeException">offset or count is less than 0.</exception>
  /// <exception cref="T:System.ArgumentException">offset subtracted from the buffer length is less than count.</exception>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public override int Read(byte[] buffer, int offset, int count);

  /// <summary>
  /// Reads from the specified position into the provided buffer.
  /// </summary>
  /// <param name="buffer">Destination buffer.</param>
  /// <param name="offset">Offset into buffer at which to start placing the read bytes.</param>
  /// <param name="count">Number of bytes to read.</param>
  /// <param name="streamPosition">Position in the stream to start reading from.</param>
  /// <returns>The number of bytes read.</returns>
  /// <exception cref="T:System.ArgumentNullException">buffer is null.</exception>
  /// <exception cref="T:System.ArgumentOutOfRangeException">offset or count is less than 0.</exception>
  /// <exception cref="T:System.ArgumentException">offset subtracted from the buffer length is less than count.</exception>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public int SafeRead(byte[] buffer, int offset, int count, ref int streamPosition);

  /// <summary>Writes the buffer to the stream.</summary>
  /// <param name="buffer">Source buffer.</param>
  /// <param name="offset">Start position.</param>
  /// <param name="count">Number of bytes to write.</param>
  /// <exception cref="T:System.ArgumentNullException">buffer is null.</exception>
  /// <exception cref="T:System.ArgumentOutOfRangeException">offset or count is negative.</exception>
  /// <exception cref="T:System.ArgumentException">buffer.Length - offset is not less than count.</exception>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public override void Write(byte[] buffer, int offset, int count);

  /// <summary>
  /// Returns a useful string for debugging. This should not normally be called in actual production code.
  /// </summary>
  public override string ToString();

  /// <summary>
  /// Writes a single byte to the current position in the stream.
  /// </summary>
  /// <param name="value">byte value to write.</param>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public override void WriteByte(byte value);

  /// <summary>
  /// Reads a single byte from the current position in the stream.
  /// </summary>
  /// <returns>The byte at the current position, or -1 if the position is at the end of the stream.</returns>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public override int ReadByte();

  /// <summary>
  /// Reads a single byte from the specified position in the stream.
  /// </summary>
  /// <param name="streamPosition">The position in the stream to read from.</param>
  /// <returns>The byte at the current position, or -1 if the position is at the end of the stream.</returns>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public int SafeReadByte(ref int streamPosition);

  /// <summary>Sets the length of the stream.</summary>
  /// <exception cref="T:System.ArgumentOutOfRangeException">value is negative or larger than MaxStreamLength.</exception>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  public override void SetLength(long value);

  /// <summary>
  /// Sets the position to the offset from the seek location.
  /// </summary>
  /// <param name="offset">How many bytes to move.</param>
  /// <param name="loc">From where.</param>
  /// <returns>The new position.</returns>
  /// <exception cref="T:System.ObjectDisposedException">Object has been disposed.</exception>
  /// <exception cref="T:System.ArgumentOutOfRangeException">offset is larger than MaxStreamLength.</exception>
  /// <exception cref="T:System.ArgumentException">Invalid seek origin.</exception>
  /// <exception cref="T:System.IO.IOException">Attempt to set negative position.</exception>
  public override long Seek(long offset, SeekOrigin loc);

  /// <summary>
  /// Synchronously writes this stream's bytes to the parameter stream.
  /// </summary>
  /// <param name="stream">Destination stream.</param>
  /// <remarks>Important: This does a synchronous write, which may not be desired in some situations.</remarks>
  public override void WriteTo(Stream stream);

  private struct BlockAndOffset
  {
    public int Block;
    public int Offset;

    public BlockAndOffset(int block, int offset);
  }
}
