// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.CompressionUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using K4os.Compression.LZ4;
using System;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Utils;

public static class CompressionUtils
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static byte[] Compress(this byte[] source, LZ4Level level = 0);

  public static byte[] Compress(this ReadOnlySpan<byte> source, LZ4Level level = 0);

  /// <summary>Decompresses <paramref name="compressed" /> data to uncompressed byte array.</summary>
  public static byte[] Decompress(this byte[] compressed);

  /// <summary>Decompresses <paramref name="data" /> and then converts it to <typeparamref name="TResult" /> using provided <paramref name="converter" />.</summary>
  public static TResult Decompress<TResult>(
    this ReadOnlySpan<byte> data,
    Func<MemoryStream, TResult> converter);

  /// <summary>Decompresses <paramref name="data" /> and then converts it to <typeparamref name="TResult" /> using provided <paramref name="converter" />. Supports custom context.</summary>
  public static TResult Decompress<TContext, TResult>(
    this ReadOnlySpan<byte> data,
    TContext ctx,
    Func<MemoryStream, TContext, TResult> converter);

  [Obsolete("Kept for compatibility with 8.3 saves, may be removed since 10.0")]
  public static Stream LegacyDecompress(this MemoryStream stream);

  public static byte[] Compress(this int[] source, bool useLZ4 = true);

  public static string DecompressString(this byte[] source);

  public static int[] DecompressIntArray(this byte[] source, bool useLZ4 = true);

  public static byte[] LZ4Encode(byte[] source);

  public static void LZ4Decode(in ReadOnlySpan<byte> source, in Span<byte> output);

  private class BinaryIntArrayWriter : BinaryWriter
  {
    public BinaryIntArrayWriter(Stream output);

    public void Write(int[] array);
  }

  private class BinaryIntArrayReader : BinaryReader
  {
    public BinaryIntArrayReader(Stream input);

    public int[] ToIntArray();
  }
}
