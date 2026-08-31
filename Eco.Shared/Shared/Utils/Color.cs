// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Color
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Utils;

[TypeConverter(typeof (ValueTypeTypeConverter))]
public struct Color : IEquatable<Color>
{
  public static Color White;
  public static Color LightGrey;
  public static Color Grey;
  public static Color BlueGrey;
  public static Color GreenGrey;
  public static Color Black;
  public static Color ClearWhite;
  public static Color ClearBlack;
  public static Color Red;
  public static Color Orange;
  public static Color Green;
  public static Color Yellow;
  public static Color NeonGreen;
  public static Color YellowGreen;
  public static Color ForestGreen;
  public static Color Blue;
  public static Color Cyan;
  public static Color LightBlue;
  public static Color LightYellow;
  public static Color LightGreen;
  public static Color LightRed;
  public static Color LightCyan;
  public static Color LightPurple;
  public static Color Brown;
  public static Color PaperGreen;
  public static Color PaperWhite;
  private float r;
  private float g;
  private float b;
  private float a;
  private static readonly Color[] SafeEyeColors;

  public static Color Random { get; }

  public static Color RandomRange(float rgbMin, float rgbMax, float a = 1f);

  public float R { get; set; }

  public float G { get; set; }

  public float B { get; set; }

  public float A { get; set; }

  public int IntA { get; }

  public int IntR { get; }

  public int IntG { get; }

  public int IntB { get; }

  public Color(float r, float g, float b, float a = 1f);

  public Color(Color source, float a);

  public Color(Vector3 source, float a = 1f);

  public Color(float r, float g, float b, float a, bool normalize);

  public Color Lerp(Color other, float percent);

  public static Color RandSkin();

  public static Color RandEye();

  public uint UIntUnit2y { get; }

  public uint UIntUnity { get; }

  public uint UInt { get; }

  public override string ToString();

  public string HexRGBA { get; }

  public string HexRGB { get; }

  public string IntRGB { get; }

  public Color(string hex);

  public bool Equals(Color other);

  public override bool Equals(object obj);

  public override int GetHashCode();

  public string Text(string text);

  public static bool operator ==(Color a, Color b);

  public static bool operator !=(Color a, Color b);

  public static Color operator *(Color a, float x);

  public static Color operator +(Color a, Color b);
}
