// Decompiled with JetBrains decompiler
// Type: Eco.Shared.LZ4.LZ4Utils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using K4os.Compression.LZ4;
using System;
using System.IO;

#nullable enable
namespace Eco.Shared.LZ4;

public class LZ4Utils
{
  /// <summary>
  /// Encodes <paramref name="data" /> in-place at same <paramref name="data" /> stream.
  /// If compressed data never overlap next uncompressed data it won't imply any extra copy operation.
  /// If <paramref name="force" /> is <c>false</c> then it will decide if it is better to keep uncompressed (if input length is 0 or if first block is greater in compressed size than uncompressed.
  /// </summary>
  public static bool StreamEncodeInPlace(
    MemoryStream data,
    int startPosition,
    bool force = true,
    LZ4Level level = 0);

  /// <summary>Encodes <paramref name="data" /> to <paramref name="compressed" /> stream.</summary>
  public static void StreamEncode(ReadOnlySpan<byte> data, MemoryStream compressed, LZ4Level level = 0);

  /// <summary>Decodes content of <paramref name="compressed" /> span with LZ4 and outputs decompressed result to <paramref name="decompressed" />.</summary>
  public static void StreamDecode(ReadOnlySpan<byte> compressed, MemoryStream decompressed);
}
