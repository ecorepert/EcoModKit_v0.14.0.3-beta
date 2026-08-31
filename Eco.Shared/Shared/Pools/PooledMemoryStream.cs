// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.PooledMemoryStream
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Buffers;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Shared.Pools;

/// <summary>
/// PooledMemoryStream (based on https://github.com/itn3000/PooledStream).
/// It uses .NET Standard <see cref="T:System.Buffers.ArrayPool`1" /> for buffer allocations.
/// Also it has <see cref="M:Eco.Shared.Pools.PooledMemoryStream.Truncate" /> which returns buffer to <see cref="T:System.Buffers.ArrayPool`1" /> and resets length, position and capacity to zero.
/// It makes the stream reusable without holding extra memory for buffer.
/// </summary>
public class PooledMemoryStream : MemoryStream
{
  /// <summary>Shared pool of <see cref="T:Eco.Shared.Pools.PooledMemoryStream" /> for zero-allocations <see cref="T:System.IO.MemoryStream" /> instances.</summary>
  public static readonly PoolService<PooledMemoryStream> Shared;

  public PooledMemoryStream();

  public PooledMemoryStream(ArrayPool<byte> pool, int capacity = 4096 /*0x1000*/);

  public override bool CanRead { get; }

  public override bool CanSeek { get; }

  public override bool CanWrite { get; }

  public override long Length { get; }

  public override long Position { get; set; }

  public override int Capacity { get; set; }

  public override void Flush();

  public override int ReadByte();

  public override int Read(byte[] buffer, int offset, int count);

  public override int Read(Span<byte> buffer);

  public override long Seek(long offset, SeekOrigin origin);

  public override void SetLength(long value);

  public override void WriteTo(Stream stream);

  public override void WriteByte(byte value);

  public override void Write(byte[] buffer, int offset, int count);

  public override void Write(ReadOnlySpan<byte> buffer);

  protected override void Dispose(bool disposing);

  public void Reserve(int capacity);

  public void Truncate();

  public override byte[] ToArray();

  public override Task CopyToAsync(
    Stream destination,
    int bufferSize,
    CancellationToken cancellationToken);

  /// <summary>
  /// This buffer is only valid until next Write or Reset operation.
  /// </summary>
  /// <returns>current buffer.</returns>
  public override byte[] GetBuffer();

  /// <summary>Returns occupied array segment of memory stream buffer.</summary>
  public override bool TryGetBuffer(out ArraySegment<byte> buffer);
}
