// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Binary.BitReader
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Net;

#nullable disable
namespace Eco.Shared.Utils.Binary;

/// <summary>
/// This class provides functionally to read bit-wide values, tracking <c>bitOffset</c> (in opposite to byte-wide values for regular <see cref="T:System.IO.MemoryStream" /> or byte array).
/// </summary>
public static class BitReader
{
  /// <summary>
  /// Reads boolean from byte array using <c>bitPosition</c>. Boolean represented as single bit.
  /// </summary>
  /// <param name="buffer">byte array.</param>
  /// <param name="bitPosition">position in array in bits.</param>
  /// <returns>boolean value. <c>true</c> - if bit was 1, <c>false</c> - otherwise.</returns>
  public static bool BitReadBoolean(this byte[] buffer, ref int bitPosition);

  /// <summary>
  /// Reads a byte value from byte array using <c>bitPosition</c>. It may have offset within a byte.
  /// </summary>
  /// <param name="buffer">byte array.</param>
  /// <param name="bitPosition">position in array in bits.</param>
  /// <returns>byte value.</returns>
  public static byte BitReadByte(this byte[] buffer, ref int bitPosition);

  /// <summary>
  /// Reads a ushort value from byte array using <c>bitPosition</c>. It may have offset within a byte.
  /// </summary>
  /// <param name="buffer">byte array.</param>
  /// <param name="bitPosition">position in array in bits.</param>
  /// <returns>ushort value.</returns>
  public static ushort BitReadUInt16(this byte[] buffer, ref int bitPosition);

  /// <summary>
  /// Reads a byte array from a source byte array using <c>bitPosition</c>. It may have offset within a byte.
  /// </summary>
  /// <param name="buffer">source byte array.</param>
  /// <param name="length">number of bytes to read.</param>
  /// <param name="bitPosition">position in array in bits.</param>
  /// <returns>result byte array.</returns>
  public static byte[] BitReadBytes(this byte[] buffer, int length, ref int bitPosition);

  public static IPEndPoint BitReadIPEndPoint(this byte[] buffer, ref int bitPosition);
}
