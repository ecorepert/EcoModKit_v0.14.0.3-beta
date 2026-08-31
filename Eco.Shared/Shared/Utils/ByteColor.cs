// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ByteColor
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>
/// Fast 4 byte item variation of a color for efficient storage and operating inside chunk.
/// Allows to store colors more efficiently for each chunk per 1000+ block each
/// Good as we do not care about alpha, and has less memory that hex color storage.
/// 
/// Occupies 4 times less memory that regular color.
/// So for min draw distance in eco it will be small 256kb overhead instead of 1mb of data. (loaded 8x8 chunk grid)
/// </summary>
[Serialized]
public struct ByteColor : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public static ByteColor Clear;
  public static ByteColor White;

  [Serialized]
  public readonly byte R { get; }

  [Serialized]
  public readonly byte G { get; }

  [Serialized]
  public readonly byte B { get; }

  [Serialized]
  public readonly byte A { get; }

  public ByteColor(byte r, byte g, byte b, byte a);

  public ByteColor(byte r, byte g, byte b);

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();

  /// <summary> Converts Eco.Shared.Utils.Color to ByteColor. Trims alpha and changes to byte. </summary>
  public static ByteColor Get(Color color);

  public static ByteColor Get(float r, float g, float b, float a);

  public string HexRGBA { get; }

  public string HexRGB { get; }

  public bool EqualsNoAlpha(ByteColor other);

  /// <summary> Converts Byte color to Eco.Shared.Color </summary>
  public Color Convert();

  /// <summary> Returns new instance of byte color with target Alpha </summary>
  public ByteColor WithAlpha(byte coat);

  /// <summary> Compares 2 color hex values as string. Counts only for RGB, without alpha </summary>
  public bool CompareHexRGB(string hexString);

  public static ByteColor FromHex(string hex);

  /// <summary> Tries to validate provided hex input, puts # if missing, returns white if bad format </summary>
  public static string ValidateHex(string hex);

  /// <summary> Calculate the Euclidean distance between current color and target. Ignores Alpha. </summary>
  public float Distance(ByteColor c);

  /// <summary> Returns clamped byte color instance in [0-225] range, based on integer input</summary>
  public static ByteColor Clamped(float r, float g, float b);

  /// <summary> Interpolates color towards another </summary>
  public ByteColor Lerp(ByteColor to, float t);

  /// <summary> Get hue value of byte color </summary>
  public float GetHue();

  public override bool Equals(object obj);

  public override int GetHashCode();

  public static bool operator ==(ByteColor left, ByteColor right);

  public static bool operator !=(ByteColor left, ByteColor right);

  public static ByteColor operator +(ByteColor a, ByteColor b);

  public static ByteColor operator *(ByteColor a, float b);
}
