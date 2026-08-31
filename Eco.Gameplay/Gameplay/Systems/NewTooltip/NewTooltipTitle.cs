// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.NewTooltipTitle
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

/// <summary>Marks a method, property, or field as a tooltip title. Title with highest priority will be displayed as title for object's tooltip.</summary>
/// <remarks>See tootlip.md for the full picture.</remarks>
public class NewTooltipTitle : NewTooltipAttribute
{
  /// <summary>Overrides default ecopedia page</summary>
  public string CustomEcopediaPage;

  public NewTooltipTitle(
    CacheAs cacheMode,
    int priority = 0,
    TTCat categories = TTCat.Default,
    TTFlags flags = TTFlags.None,
    Type overrideType = null,
    string customEcopediaPage = "");
}
