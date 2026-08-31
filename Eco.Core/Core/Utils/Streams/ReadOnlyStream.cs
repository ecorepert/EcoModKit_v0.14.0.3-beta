// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Streams.ReadOnlyStream
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable disable
namespace Eco.Core.Utils.Streams;

/// <summary>Base class for read-only stream wrappers.</summary>
public abstract class ReadOnlyStream : Stream
{
  public override bool CanRead { get; }

  public override bool CanWrite { get; }

  public override bool CanSeek { get; }

  public override long Length { get; }

  public override long Position { get; set; }

  public override long Seek(long offset, SeekOrigin origin);

  public override void SetLength(long value);

  public override void Write(byte[] buffer, int offset, int count);

  public override void Flush();
}
