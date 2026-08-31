// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Binary.ByteSpanReader
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.IO;
using System.Net;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Utils.Binary;

/// <summary>
/// Wraps <see cref="T:System.ReadOnlySpan`1" /> as source for binary data.
/// When Read* operation used then it changes internal state and so you need to avoid copy this struct if you need to keep reading position.
/// But similar if you copy it before Read operation(s) then you can use original copy for read position reset.
/// </summary>
public ref struct ByteSpanReader
{
  private ReadOnlySpan<byte> span;

  /// <summary>Returns how much bytes left for read.</summary>
  public int BytesLeft { get; }

  /// <summary>Returns unread span. Changes after every read operation.</summary>
  public ReadOnlySpan<byte> UnreadSpan { get; }

  public ByteSpanReader(ReadOnlySpan<byte> span);

  /// <summary>Read next byte from the reader and advance read position by 1.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public byte ReadByte();

  /// <summary>Read an unsigned int from the reader zig zag encoded and advance read position by 1-5 bytes (depending on how large is number).</summary>
  public uint ReadUInt32ZigZag();

  /// <summary>Read a short value from the reader and advance read position by 2. Always uses LittleEndian.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public short ReadInt16();

  /// <summary>Read an int value from the reader and advance read position by 4. Always uses LittleEndian.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int ReadInt32();

  /// <summary>Read a long value from the reader and advance read position by 8. Always uses LittleEndian.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public long ReadInt64();

  /// <summary>Read a unsigned short value from the reader and advance read position by 2. Always uses LittleEndian.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public ushort ReadUInt16();

  /// <summary>Read a unsigned int value from the reader and advance read position by 4. Always uses LittleEndian.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public uint ReadUInt32();

  /// <summary>Read a double value from the reader and advance read position by 8. Always uses LittleEndian.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public double ReadDouble();

  /// <summary>Read a <see cref="T:Eco.Shared.Math.Vector2" /> from the reader and advance read position by 8 (2 x float).</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Eco.Shared.Math.Vector2 ReadVector2();

  /// <summary>Read a <see cref="T:System.Numerics.Vector3" /> from the reader and advance read position by 12 (3 x float).</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Vector3 ReadVector3();

  /// <summary>Read a double value from the reader and advance read position by 4. Always uses LittleEndian.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float ReadSingle();

  /// <summary>
  /// [str len:zig zag uint][str:utf-8 encoded byte array]
  /// Reads a string from the reader and advance read position by string length and encoded length size.
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public string ReadString();

  /// <summary>
  /// [0 - false/1 - true:byte]
  /// Reads a boolean value from the reader and advance read position by 1.
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool ReadBoolean();

  /// <summary>
  /// [guid:byte[16]]
  /// Reads a Guid from the reader  and advance read position by 16.
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Guid ReadGuid();

  /// <summary>
  /// [address length:byte][address bytes:byte array][port:ushort]
  /// Reads an IP end point from the reader and advances position (depending on size of encoded endpoint).
  /// </summary>
  public IPEndPoint ReadIPEndPoint();

  /// <summary>Reads <paramref name="destination" /> length bytes to <paramref name="destination" />. Fails if not enough bytes to read.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void ReadBytesTo(Span<byte> destination);

  /// <summary>Reads <paramref name="count" /> bytes to <paramref name="output" />. Fails if not enough bytes to read.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void ReadBytesTo(Stream output, int count);

  /// <summary>Skips <paramref name="count" /> bytes.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Skip(int count);
}
