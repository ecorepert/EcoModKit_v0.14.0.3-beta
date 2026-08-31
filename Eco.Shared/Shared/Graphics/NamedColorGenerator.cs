// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Graphics.NamedColorGenerator
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Graphics;

public static class NamedColorGenerator
{
  /// <summary> Generate a palette of colors with unique names. Blends every pair of base color. </summary>
  public static Dictionary<NamedColor, List<NamedColor>> DoBlends(
    Dictionary<NamedColors, ByteColor> baseColors,
    int blendsPerPair = 3);
}
