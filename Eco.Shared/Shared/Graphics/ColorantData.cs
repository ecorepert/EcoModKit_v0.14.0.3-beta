// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Graphics.ColorantData
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Shared.Graphics;

/// <summary>
/// Struct that holds colorant data.
/// Can be replaced with tech tree data storage,
/// but it anyways provides all needed data to operate with colorant and paint mixing in general
/// </summary>
public class ColorantData
{
  public LocString Name;
  public Color VisualColor;
  public ByteColor MixingColor;
  public string ItemLink;

  public ColorantData(LocString name, ByteColor mixingColor, Color visualColor);

  public ColorantData(LocString name, ByteColor mixingColor, string itemLink);
}
