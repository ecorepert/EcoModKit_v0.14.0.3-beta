// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.StreamExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.IO;

#nullable enable
namespace Eco.Shared.Utils;

public static class StreamExtensions
{
  /// <summary>Reads portion of <paramref name="source" /> stream to <paramref name="destination" />.</summary>
  public static void ReadTo(this Stream source, Stream destination, long start, long length);

  /// <summary>Reads <paramref name="count" /> of <paramref name="source" /> stream bytes to <paramref name="destination" />.</summary>
  public static void ReadTo(this Stream source, Stream destination, long count);
}
