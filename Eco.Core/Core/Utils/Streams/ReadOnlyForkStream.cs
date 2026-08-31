// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Streams.ReadOnlyForkStream
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable disable
namespace Eco.Core.Utils.Streams;

/// <summary>
/// Read-only stream which "forks" data which was read to <see cref="F:Eco.Core.Utils.Streams.ReadOnlyForkStream.fork" /> stream.
/// "Fork" means it will have copy of all data which was read from <see cref="T:System.IO.Stream" />.
/// It doesn't take ownership of <see cref="F:Eco.Core.Utils.Streams.ReadOnlyForkStream.fork" /> and you should Dispose it on you own.
/// </summary>
public class ReadOnlyForkStream : ReadOnlyWrapperStream
{
  public ReadOnlyForkStream(Stream fork, Stream stream, bool leaveOpen = false);

  public override int Read(byte[] buffer, int offset, int count);

  public override int ReadByte();
}
