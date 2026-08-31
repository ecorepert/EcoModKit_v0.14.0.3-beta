// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Graphics.NamedColor
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Shared.Graphics;

/// <summary> Wrapper for ByteColor that contains named of base, shade index and result color </summary>
[Serialized]
public struct NamedColor
{
  public string Name;
  public ByteColor Color;
  public int Blend;

  public NamedColor(string name, ByteColor color);

  /// <summary> Returns variant name for display. Like "Teal #12" etc. For 0 index returns just name without shade index. </summary>
  public LocString GetDisplayName();

  public string GetBlend();
}
