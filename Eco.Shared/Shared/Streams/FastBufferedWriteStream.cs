// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Streams.FastBufferedWriteStream
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.IO;

#nullable disable
namespace Eco.Shared.Streams;

/// <summary>Fast optimized alternative to <see cref="T:System.IO.BufferedStream" /> with write-only non-seekable support which allows to minimize number of checks and calculations, because of limitations.</summary>
public class FastBufferedWriteStream : Stream
{
  public const uint DefaultBufferSize = 65536 /*0x010000*/;
  protected long position;
  protected Stream stream;

  public FastBufferedWriteStream(Stream stream, uint bufferSize = 65536 /*0x010000*/, bool leaveOpen = true);

  public override bool CanRead { get; }

  public override bool CanSeek { get; }

  public override bool CanWrite { get; }

  public override long Length { get; }

  public override long Position { get; set; }

  public override void WriteByte(byte value);

  public override void Write(byte[] buffer, int offset, int count);

  public override void Write(ReadOnlySpan<byte> buffer);

  public override void Flush();

  public override int Read(byte[] buffer, int offset, int count);

  public override long Seek(long offset, SeekOrigin origin);

  public override void SetLength(long value);

  protected override void Dispose(bool disposing);
}
