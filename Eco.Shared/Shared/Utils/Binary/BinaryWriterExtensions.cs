// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Binary.BinaryWriterExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.IO;

#nullable disable
namespace Eco.Shared.Utils.Binary;

public static class BinaryWriterExtensions
{
  /// <summary>
  /// In c# bool takes 8 bits. It means there is excess of 7 bits.
  /// It can be improved by encoding it as a part of some existing int, so it would take only 1 bit.
  /// This method shifts all bits to the left and writes bool value in the last bit.
  /// </summary>
  public static int AppendBoolToInt(this int value, bool boolVal);

  /// <summary>This does reverse of <see cref="M:Eco.Shared.Utils.Binary.BinaryWriterExtensions.AppendBoolToInt(System.Int32,System.Boolean)" />. It extracts bool value and returns original int.</summary>
  public static int ExtractBoolFromInt(this int value, out bool boolVal);

  /// <summary>
  /// Replaces previously encoded <paramref name="oldValue" /> with <paramref name="newValue" /> at <paramref name="position" />. To perform this operation <paramref name="writer" /> backing stream should be <see cref="T:System.IO.MemoryStream" />.
  /// Length of encoded number may be different, in this case data after encoded number will be shifted left or right.
  /// </summary>
  public static void ReplaceZigZag(
    this BinaryWriter writer,
    int position,
    int oldValue,
    int newValue);

  /// <summary>Encodes a signed integer using variable number of bytes, depending on the actual value of the integer.</summary>
  /// <remarks>This method can end up encoding the integer using between 1 and 5 bytes.</remarks>
  public static void EncodeVariableLength(this BinaryWriter writer, int value);

  /// <summary>Encodes an unsigned integer using variable number of bytes, depending on the actual value of the integer.</summary>
  /// <remarks>This method can end up encoding the integer using between 1 and 5 bytes.</remarks>
  public static void EncodeVariableLength(this BinaryWriter writer, uint value);

  /// <inheritdoc cref="M:Eco.Shared.Utils.Binary.BinaryWriterExtensions.GetZigZagLength(System.Int32)" />
  public static int GetZigZagLength(this BinaryWriter writer, int value);

  /// <remarks>This method can end up encoding the integer using between 1 and 10 bytes.</remarks>
  /// <inheritdoc cref="M:Eco.Shared.Utils.Binary.BinaryWriterExtensions.EncodeVariableLength(System.IO.BinaryWriter,System.Int32)" />
  public static void EncodeVariableLength(this BinaryWriter writer, long value);

  /// <remarks>This method can end up encoding the integer using between 1 and 10 bytes.</remarks>
  /// <inheritdoc cref="M:Eco.Shared.Utils.Binary.BinaryWriterExtensions.EncodeVariableLength(System.IO.BinaryWriter,System.UInt32)" />
  public static void EncodeVariableLength(this BinaryWriter writer, ulong value);

  /// <summary>Writes a string key,value Dictionary using a BinaryWriter</summary>
  public static void WriteDictionary(
    this BinaryWriter writer,
    Dictionary<string, string> dictionary);
}
