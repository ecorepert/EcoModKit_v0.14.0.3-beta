// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Binary.ByteArrayReader
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Net;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Utils.Binary;

/// <summary>
/// Utility class to read structured data from byte array.
/// </summary>
public static class ByteArrayReader
{
  /// <summary>Read a byte from byte array using provided offset.</summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded byte value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static byte ReadByte(this byte[] data, ref int offset);

  /// <summary>Read a unsigned int from data array zig zag encoded.</summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded unsigned int value.</returns>
  /// <exception cref="T:System.Exception">if value can't be decoded from byte array.</exception>
  public static uint ReadUInt32ZigZag(this byte[] data, ref int offset);

  /// <summary>
  /// Read a short value from data array. Always uses LittleEndian.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded short value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static short ReadInt16(this byte[] data, ref int offset);

  /// <summary>
  /// Read a int value from data array. Always uses LittleEndian.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded int value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int ReadInt32(this byte[] data, ref int offset);

  /// <summary>
  /// Read a long value from data array. Always uses LittleEndian.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded long value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static long ReadInt64(this byte[] data, ref int offset);

  /// <summary>
  /// Read a ushort value from data array. Always uses LittleEndian.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded ushort value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ushort ReadUInt16(this byte[] data, ref int offset);

  /// <summary>
  /// Read a uint value from data array. Always uses LittleEndian.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded uint value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static uint ReadUInt32(this byte[] data, ref int offset);

  /// <summary>
  /// Read a double value from data array. Always uses LittleEndian.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded double value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static double ReadDouble(this byte[] data, ref int offset);

  /// <summary>
  /// Read a vector3 value from data array. Always uses LittleEndian.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded float value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3 ReadVector3(this byte[] data, ref int offset);

  /// <summary>
  /// Read a float value from data array. Always uses LittleEndian.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded float value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float ReadSingle(this byte[] data, ref int offset);

  /// <summary>
  /// [str len:zig zag uint][str:utf-8 encoded byte array]
  /// Reads a string from byte array using provided <c>offset</c>.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded string.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static string ReadString(this byte[] data, ref int offset);

  /// <summary>
  /// [0 - false/1 - true:byte]
  /// Reads a boolean value from byte array using provided <c>offset</c>.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded boolean value.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool ReadBoolean(this byte[] data, ref int offset);

  /// <summary>
  /// [guid:byte[16]]
  /// Reads a Guid from byte array using provided <c>offset</c>.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded Guid.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Guid ReadGuid(this byte[] data, ref int offset);

  /// <summary>
  /// [address length:byte][address bytes:byte array][port:ushort]
  /// Reads a IP end point from byte array using provided <c>offset</c>.
  /// </summary>
  /// <param name="data">byte array.</param>
  /// <param name="offset">reference to offset, will be modified to next read position.</param>
  /// <returns>decoded IP endpoint.</returns>
  public static IPEndPoint ReadIPEndPoint(this byte[] data, ref int offset);
}
