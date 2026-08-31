// Decompiled with JetBrains decompiler
// Type: Microsoft.IO.RecyclableMemoryStreamManager
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.IO;

#nullable disable
namespace Microsoft.IO;

/// <summary>Manages pools of RecyclableMemoryStream objects.</summary>
/// <remarks>
/// There are two pools managed in here. The small pool contains same-sized buffers that are handed to streams
/// as they write more data.
/// 
/// For scenarios that need to call GetBuffer(), the large pool contains buffers of various sizes, all
/// multiples of LargeBufferMultiple (1 MB by default). They are split by size to avoid overly-wasteful buffer
/// usage. There should be far fewer 8 MB buffers than 1 MB buffers, for example.
/// </remarks>
public class RecyclableMemoryStreamManager
{
  public const int DefaultBlockSize = 131072 /*0x020000*/;
  public const int DefaultLargeBufferMultiple = 1048576 /*0x100000*/;
  public const int DefaultMaximumBufferSize = 134217728 /*0x08000000*/;

  /// <summary>
  /// Initializes the memory manager with the default block/buffer specifications.
  /// </summary>
  public RecyclableMemoryStreamManager();

  /// <summary>
  /// Initializes the memory manager with the given block requiredSize.
  /// </summary>
  /// <param name="blockSize">Size of each block that is pooled. Must be &gt; 0.</param>
  /// <param name="largeBufferMultiple">Each large buffer will be a multiple of this value.</param>
  /// <param name="maximumBufferSize">Buffers larger than this are not pooled.</param>
  /// <exception cref="T:System.ArgumentOutOfRangeException">blockSize is not a positive number, or largeBufferMultiple is not a positive number, or maximumBufferSize is less than blockSize.</exception>
  /// <exception cref="T:System.ArgumentException">maximumBufferSize is not a multiple of largeBufferMultiple.</exception>
  public RecyclableMemoryStreamManager(
    int blockSize,
    int largeBufferMultiple,
    int maximumBufferSize);

  /// <summary>
  /// The size of each block. It must be set at creation and cannot be changed.
  /// </summary>
  public int BlockSize { get; }

  /// <summary>
  /// All buffers are multiples of this number. It must be set at creation and cannot be changed.
  /// </summary>
  public int LargeBufferMultiple { get; }

  /// <summary>Gets or sets the maximum buffer size.</summary>
  /// <remarks>Any buffer that is returned to the pool that is larger than this will be
  /// discarded and garbage collected.</remarks>
  public int MaximumBufferSize { get; }

  /// <summary>Number of bytes in small pool not currently in use.</summary>
  public long SmallPoolFreeSize { get; }

  /// <summary>
  /// Number of bytes currently in use by stream from the small pool.
  /// </summary>
  public long SmallPoolInUseSize { get; }

  /// <summary>Number of bytes in large pool not currently in use.</summary>
  public long LargePoolFreeSize { get; }

  /// <summary>
  /// Number of bytes currently in use by streams from the large pool.
  /// </summary>
  public long LargePoolInUseSize { get; }

  /// <summary>How many blocks are in the small pool.</summary>
  public long SmallBlocksFree { get; }

  /// <summary>How many buffers are in the large pool.</summary>
  public long LargeBuffersFree { get; }

  /// <summary>
  /// How many bytes of small free blocks to allow before we start dropping
  /// those returned to us.
  /// </summary>
  public long MaximumFreeSmallPoolBytes { get; set; }

  /// <summary>
  /// How many bytes of large free buffers to allow before we start dropping
  /// those returned to us.
  /// </summary>
  public long MaximumFreeLargePoolBytes { get; set; }

  /// <summary>
  /// Maximum stream capacity in bytes. Attempts to set a larger capacity will
  /// result in an exception.
  /// </summary>
  /// <remarks>A value of 0 indicates no limit.</remarks>
  public long MaximumStreamCapacity { get; set; }

  /// <summary>
  /// Whether to save callstacks for stream allocations. This can help in debugging.
  /// It should NEVER be turned on generally in production.
  /// </summary>
  public bool GenerateCallStacks { get; set; }

  /// <summary>
  /// Whether dirty buffers can be immediately returned to the buffer pool. E.g. when GetBuffer() is called on
  /// a stream and creates a single large buffer, if this setting is enabled, the other blocks will be returned
  /// to the buffer pool immediately.
  /// Note when enabling this setting that the user is responsible for ensuring that any buffer previously
  /// retrieved from a stream which is subsequently modified is not used after modification (as it may no longer
  /// be valid).
  /// </summary>
  public bool AggressiveBufferReturn { get; set; }

  /// <summary>
  /// Retrieve a new MemoryStream object with no tag and a default initial capacity.
  /// </summary>
  /// <returns>A MemoryStream.</returns>
  public MemoryStream GetStream();

  /// <summary>
  /// Retrieve a new MemoryStream object with the given tag and a default initial capacity.
  /// </summary>
  /// <param name="tag">A tag which can be used to track the source of the stream.</param>
  /// <returns>A MemoryStream.</returns>
  public MemoryStream GetStream(string tag);

  /// <summary>
  /// Retrieve a new MemoryStream object with the given tag and at least the given capacity.
  /// </summary>
  /// <param name="tag">A tag which can be used to track the source of the stream.</param>
  /// <param name="requiredSize">The minimum desired capacity for the stream.</param>
  /// <returns>A MemoryStream.</returns>
  public MemoryStream GetStream(string tag, int requiredSize);

  /// <summary>
  /// Retrieve a new MemoryStream object with the given tag and at least the given capacity, possibly using
  /// a single contiguous underlying buffer.
  /// </summary>
  /// <remarks>Retrieving a MemoryStream which provides a single contiguous buffer can be useful in situations
  /// where the initial size is known and it is desirable to avoid copying data between the smaller underlying
  /// buffers to a single large one. This is most helpful when you know that you will always call GetBuffer
  /// on the underlying stream.</remarks>
  /// <param name="tag">A tag which can be used to track the source of the stream.</param>
  /// <param name="requiredSize">The minimum desired capacity for the stream.</param>
  /// <param name="asContiguousBuffer">Whether to attempt to use a single contiguous buffer.</param>
  /// <returns>A MemoryStream.</returns>
  public MemoryStream GetStream(string tag, int requiredSize, bool asContiguousBuffer);

  /// <summary>
  /// Retrieve a new MemoryStream object with the given tag and with contents copied from the provided
  /// buffer. The provided buffer is not wrapped or used after construction.
  /// </summary>
  /// <remarks>The new stream's position is set to the beginning of the stream when returned.</remarks>
  /// <param name="tag">A tag which can be used to track the source of the stream.</param>
  /// <param name="buffer">The byte buffer to copy data from.</param>
  /// <param name="offset">The offset from the start of the buffer to copy from.</param>
  /// <param name="count">The number of bytes to copy from the buffer.</param>
  /// <returns>A MemoryStream.</returns>
  public MemoryStream GetStream(string tag, byte[] buffer, int offset, int count);
}
