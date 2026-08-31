// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Streams.StreamWithLength
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable disable
namespace Eco.Core.Utils.Streams;

/// <summary>Adds Length and Position (get) support to Stream.</summary>
public class StreamWithLength : WrapperStream
{
  public StreamWithLength(Stream stream, long length, bool leaveOpen = false);

  public StreamWithLength(Stream stream, long length, long position, bool leaveOpen = false);

  public override long Length { get; }

  public override long Position { get; set; }

  public override void SetLength(long value);

  public override long Seek(long offset, SeekOrigin origin);

  public override int Read(byte[] buffer, int offset, int count);

  public override void Write(byte[] buffer, int offset, int count);

  public override int ReadByte();

  public override void WriteByte(byte value);
}
