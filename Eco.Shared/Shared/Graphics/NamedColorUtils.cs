// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Graphics.NamedColorUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Graphics;

/// <summary>Static utility methods for working with dye colors</summary>
public static class NamedColorUtils
{
  /// <summary>Table mapping every <see cref="T:Eco.Shared.Graphics.NamedColors" /> type to its RGB value for rendering.</summary>
  public static readonly Dictionary<NamedColors, ByteColor> BaseColors;
  /// <summary> Contains all generated named colors based on basic ones and the result of NamedColorGenerator </summary>
  public static readonly List<NamedColor> AllColors;
  public static readonly Dictionary<NamedColor, List<NamedColor>> GroupedColors;

  /// <summary> Returns a <see cref="T:Eco.Shared.Utils.ByteColor" /> instance matching the RGB value of a <see cref="T:Eco.Shared.Graphics.NamedColors" /> dye type. </summary>
  public static ByteColor GetNamedColor(this NamedColors namedColor);

  /// <summary> Returns all base named colors </summary>
  public static List<ByteColor> GetBaseColors();

  /// <summary>Returns a random <see cref="T:Eco.Shared.Graphics.NamedColors" /> from the available in "BASE" table.</summary>
  public static NamedColors GetRandomNamedColor();

  /// <summary>Returns a random <see cref="T:Eco.Shared.Utils.ByteColor" /> from the available in "BASE" table.</summary>
  public static ByteColor GetRandomByteColor();

  /// <summary>Returns a random <see cref="T:Eco.Shared.Graphics.NamedColors" /> from the available in "BLENDED" table.</summary>
  public static NamedColor GetRandomNamedColorAll();

  /// <summary> Returns the closest <see cref="T:Eco.Shared.Graphics.NamedColors" /> to a given <see cref="T:Eco.Shared.Utils.Color" /></summary>
  public static NamedColor GetClosestNamedColor(ByteColor requestedColor);

  /// <summary> Gets closest name of a color.</summary>
  public static LocString GetClosestColorName(ByteColor color);
}
