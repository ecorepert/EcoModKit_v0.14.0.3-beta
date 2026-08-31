// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.HashingPassThroughStream
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable disable
namespace Eco.Core.Serialization;

/// <summary>Write-only stream that hashes everything written through it (xxHash64) while forwarding to a target stream.
/// With <see cref="F:System.IO.Stream.Null" /> as target it acts as a hash-only sink. Reusable via <see cref="M:Eco.Core.Serialization.HashingPassThroughStream.Reset(System.IO.Stream)" />; not thread-safe.</summary>
public sealed class HashingPassThroughStream : Stream
{
  public void Reset(Stream target);

  public ulong Hash { get; }

  public override void Write(byte[] buffer, int offset, int count);

  public override void WriteByte(byte value);

  public override void Flush();

  public override bool CanRead { get; }

  public override bool CanSeek { get; }

  public override bool CanWrite { get; }

  public override long Length { get; }

  public override long Position { get; set; }

  public override int Read(byte[] buffer, int offset, int count);

  public override long Seek(long offset, SeekOrigin origin);

  public override void SetLength(long value);
}
