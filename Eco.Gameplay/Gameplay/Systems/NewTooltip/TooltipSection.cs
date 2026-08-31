// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipSection
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

/// <summary>A single section for a tooltip that contains a title and some content, can be wrapped by line or foldable.</summary>
public class TooltipSection : IBsonSerializable
{
  public LocString Title { get; }

  public LocString Content { get; }

  public bool AllowLineWrapping { get; }

  public bool IsFoldable { get; }

  public bool Empty { get; }

  public static TooltipSection SectionLoc(string title, string content);

  public static TooltipSection SectionLoc(string content);

  public static implicit operator LocString(TooltipSection section);

  public TooltipSection(
    LocString title,
    LocString content,
    bool allowLineWrapping = false,
    bool isFoldable = false);

  public TooltipSection(LocString content);

  public TooltipSection WithLineWrapping();

  public TooltipSection MakeFoldable();

  public BSONArray ToBson();

  /// <summary>Casts <paramref name="value" /> to <see cref="T:Eco.Gameplay.Systems.NewTooltip.TooltipSection" /> (if possible).</summary>
  public static TooltipSection Cast(object value);

  public static explicit operator TooltipSection(LocString locStr);

  public static explicit operator TooltipSection(string str);
}
