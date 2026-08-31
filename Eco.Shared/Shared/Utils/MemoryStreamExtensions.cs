// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.MemoryStreamExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Various methods to write to memory streams, that do not allocate memory.</summary>
public static class MemoryStreamExtensions
{
  /// <summary>
  /// byte<br />
  /// [1 byte]
  /// </summary>
  public static void Write(this MemoryStream stream, byte value);

  /// <summary>
  /// bool<br />
  /// [1 byte]
  /// </summary>
  public static byte ReadByte(this MemoryStream stream);

  /// <summary>
  /// bool<br />
  /// [1 byte]
  /// </summary>
  public static void Write(this MemoryStream stream, bool value);

  /// <summary>
  /// bool<br />
  /// [1 byte]
  /// </summary>
  public static bool ReadBool(this MemoryStream stream);

  /// <summary>
  /// short<br />
  /// [2 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, short value);

  /// <summary>
  /// short<br />
  /// [2 bytes]
  /// </summary>
  public static short ReadShort(this MemoryStream stream);

  /// <summary>
  /// ushort<br />
  /// [2 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, ushort value);

  /// <summary>
  /// ushort<br />
  /// [2 bytes]
  /// </summary>
  public static ushort ReadUShort(this MemoryStream stream);

  /// <summary>
  /// short span encoded as array<br />
  /// [length as zigzag int][ushort array]
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void WriteArray<T>(this MemoryStream stream, ReadOnlySpan<T> value) where T : unmanaged;

  /// <summary>
  /// short array<br />
  /// [length as zigzag int][ushort array]
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void WriteArray(this MemoryStream stream, ushort[] value);

  /// <summary>
  /// Reads <paramref name="count" /> <typeparamref name="T" /> values to <paramref name="array" />.
  /// It makes binary copy of stream data to array and won't correctly work if any kind of compression (like zig zag) was used.
  /// </summary>
  public static void ReadArray<T>(this MemoryStream stream, T[] array, int count) where T : unmanaged;

  /// <summary>
  /// Decodes ushort array.
  /// [count:int sig zag][ushort[count]]
  /// </summary>
  public static ushort[] ReadUShortArray(this MemoryStream stream);

  /// <summary>
  /// zig zag int<br />
  /// [1-5 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, int value);

  /// <summary>
  /// zig zag int<br />
  /// [1-5 bytes]
  /// </summary>
  public static int ReadInt(this MemoryStream stream);

  /// <summary>
  /// zig zag uint<br />
  /// [1-5 bytes]
  /// </summary>
  public static uint ReadUInt(this MemoryStream stream);

  /// <summary>
  /// non zig zag int<br />
  /// [4 bytes]
  /// </summary>
  public static void WriteNoZigZag(this MemoryStream stream, int value);

  /// <summary>
  /// zig zag uint<br />
  /// [1-5 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, uint value);

  /// <summary>
  /// non zig zag uint<br />
  /// [4 bytes]
  /// </summary>
  public static void WriteNoZigZag(this MemoryStream stream, uint value);

  /// <summary>
  /// zig zag long<br />
  /// [1-10 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, long value);

  /// <summary>
  /// zig zag ulong<br />
  /// [1-10 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, ulong value);

  /// <summary>
  /// non zig zag long<br />
  /// [8 bytes]
  /// </summary>
  public static void WriteNoZigZag(this MemoryStream stream, long value);

  /// <summary>
  /// zig zag long<br />
  /// [1-10 bytes]
  /// </summary>
  public static long ReadLong(this MemoryStream stream);

  /// <summary>
  /// zig zag long<br />
  /// [1-10 bytes]
  /// </summary>
  public static ulong ReadULong(this MemoryStream stream);

  /// <summary>
  /// float<br />
  /// [4 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, float value);

  /// <summary>
  /// float<br />
  /// [4 bytes]
  /// </summary>
  public static float ReadFloat(this MemoryStream stream);

  /// <summary>
  /// double<br />
  /// [8 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, double value);

  /// <summary>
  /// double<br />
  /// [8 bytes]
  /// </summary>
  public static double ReadDouble(this MemoryStream stream);

  /// <summary>
  /// <see cref="T:System.Guid" /><br />
  /// [16 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, Guid value);

  /// <summary>
  /// <see cref="T:System.Guid" /><br />
  /// [16 bytes]
  /// </summary>
  public static Guid ReadGuid(this MemoryStream stream);

  /// <summary>
  /// Encodes <see cref="T:System.Net.IPEndPoint" /> to <paramref name="stream" />.<br />
  /// [address bytes length:1 byte][address bytes:4-16 bytes][port:2 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, IPEndPoint endPoint);

  /// <summary>
  /// Encodes <see cref="T:System.String" /> <paramref name="value" /> to <paramref name="stream" />. Depending on <paramref name="signedZigZag" /> will either use <see cref="M:Eco.Shared.Utils.MemoryStreamExtensions.EncodeVariableLength(System.IO.MemoryStream,System.Int32)" /> for <c>true</c> or <see cref="M:Eco.Shared.Utils.MemoryStreamExtensions.EncodeVariableLength(System.IO.MemoryStream,System.UInt32)" /> for <c>false</c> when encoding string length.<br />
  /// [length: signed/unsigned int zigzag][utf8 bytes]
  /// </summary>
  public static void Write(this MemoryStream stream, string? value, bool signedZigZag);

  /// <summary>
  /// Encodes <see cref="T:System.String" /> <paramref name="value" /> to <paramref name="stream" />.<br />
  /// [length: unsigned int zigzag][utf8 bytes]
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Write(this MemoryStream stream, string? value);

  /// <summary>
  /// Decodes <see cref="T:System.String" /> from <paramref name="stream" />.<br />
  /// [length: unsigned int zigzag][utf8 bytes]
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static string ReadString(this MemoryStream stream);

  /// <summary>
  /// Decodes <see cref="T:System.String" /> from <paramref name="stream" />. Depending on <paramref name="signedZigZag" /> will either use <see cref="M:Eco.Shared.Utils.MemoryStreamExtensions.DecodeIntVariableLength(System.IO.MemoryStream)" /> for <c>true</c> or <see cref="M:Eco.Shared.Utils.MemoryStreamExtensions.DecodeUIntVariableLength(System.IO.MemoryStream)" /> for <c>false</c> when decoding string length.<br />
  /// [length: signed/unsigned int zigzag][utf8 bytes]
  /// </summary>
  public static string ReadString(this MemoryStream stream, bool signedZigZag);

  /// <summary>
  /// Returns <see cref="T:System.Span`1" /> which may be used for direct write access to <see cref="T:System.IO.MemoryStream" /> buffer (obtained with <see cref="M:System.IO.MemoryStream.GetBuffer" />) and advances stream position for <paramref name="bytesCount" />.
  /// This span should be used immediately before any other Stream write operation, because otherwise buffer may be re-allocated and Span reference become invalid.
  /// </summary>
  public static Span<byte> WriteSpan(this MemoryStream memoryStream, int bytesCount);

  /// <summary>
  /// Returns <see cref="T:System.ReadOnlySpan`1" /> for next <paramref name="bytesCount" /> bytes of <paramref name="memoryStream" /> and advances read position.
  /// This span should be used immediately before any other Stream write operation, because otherwise buffer may be re-allocated and Span reference become invalid.
  /// </summary>
  public static ReadOnlySpan<byte> ReadSpan(this MemoryStream memoryStream, int bytesCount);

  /// <summary>Returns <see cref="T:System.ReadOnlySpan`1" /> for <paramref name="memoryStream" /> buffer starting from current position and advances stream position to the end.</summary>
  public static ReadOnlySpan<byte> ReadSpanToEnd(this MemoryStream memoryStream);

  /// <summary>Returns <see cref="T:System.IO.Stream" /> byte content as <see cref="T:System.Span`1" />. It is alternative to <see cref="M:System.IO.MemoryStream.ToArray" />, but without byte array allocation.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Span<byte> GetBufferSpan(this MemoryStream stream);

  /// <summary>Returns <see cref="T:System.IO.Stream" /> byte content as <see cref="T:System.ArraySegment`1" />. It is alternative to <see cref="M:System.IO.MemoryStream.GetBuffer" />, but with used range only and with user provided byte array offset support.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ArraySegment<byte> GetBufferArraySegment(this MemoryStream stream);

  /// <summary>
  /// Shifts <paramref name="stream" /> content at given <paramref name="shiftPosition" /> by <paramref name="shift" />. Stream position and length adjusted if required.
  /// Useful when you need to insert or remove byte content from stream.
  /// </summary>
  public static void Shift(this MemoryStream stream, int shiftPosition, int shift);
}
