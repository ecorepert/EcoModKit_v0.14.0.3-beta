// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Streams.FastReusableBufferedWriteStream
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.IO;

#nullable disable
namespace Eco.Shared.Streams;

/// <summary>Extends <see cref="T:Eco.Shared.Streams.FastBufferedWriteStream" /> with re-usability logic. It allows to call <see cref="M:Eco.Shared.Streams.FastReusableBufferedWriteStream.Reset(System.IO.Stream)" /> with new backing stream instead of new buffered stream instance creation. Initially initialized with <see cref="F:System.IO.Stream.Null" /> backing stream.</summary>
public class FastReusableBufferedWriteStream : FastBufferedWriteStream
{
  public FastReusableBufferedWriteStream(uint bufferSize = 65536 /*0x010000*/);

  /// <summary>Use this method to Reset to another backing Stream. It won't Flush to previous stream so you should call <see cref="M:Eco.Shared.Streams.FastBufferedWriteStream.Flush" /> explicitly if needed.
  /// <see cref="P:Eco.Shared.Streams.FastBufferedWriteStream.Position" /> and <see cref="P:Eco.Shared.Streams.FastBufferedWriteStream.Length" /> set to 0 after call to the method.</summary>
  public void Reset(Stream stream);
}
