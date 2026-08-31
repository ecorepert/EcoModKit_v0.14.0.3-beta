// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.SeekableRead
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Helps to make seekable read on non-seekable streams.</summary>
internal struct SeekableRead
{
  private long position;

  public readonly Stream InputStream { get; }

  public readonly Stream SeekableStream { get; }

  /// <summary>Prepares members reader. It checks if Base Stream is seekable and if it isn't then it makes new <see cref="T:System.IO.BinaryReader" /> with <see cref="T:Eco.Core.Utils.Streams.ReadOnlyForkStream" /> which "taps" to new seekable instance stream.</summary>
  public static SeekableRead Start(ref BinaryReader reader);

  /// <summary>Resets seekable read to position from which it was started.</summary>
  public Stream Reset();

  /// <summary>Resets seekable read to position from which it was started and returns either same reader or new reader if stream was changed.</summary>
  public BinaryReader ResetReader(BinaryReader reader);
}
