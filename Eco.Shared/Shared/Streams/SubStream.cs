// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Streams.SubStream
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.IO;

#nullable disable
namespace Eco.Shared.Streams;

/// <summary>
/// Wrapper around existing stream which allows to use portion of stream without copying it to another stream.
/// </summary>
public class SubStream : Stream
{
  public SubStream(Stream stream, long length, bool leaveOpen = false);

  public override void Flush();

  public override long Seek(long offset, SeekOrigin origin);

  public override void SetLength(long value);

  public override int Read(byte[] buffer, int offset, int count);

  public override int ReadByte();

  public override void Write(byte[] buffer, int offset, int count);

  public override bool CanRead { get; }

  /// <summary>Not supported for now, but may be implemented.</summary>
  public override bool CanSeek { get; }

  public override bool CanWrite { get; }

  public override long Length { get; }

  public override long Position { get; set; }

  protected override void Dispose(bool disposing);
}
