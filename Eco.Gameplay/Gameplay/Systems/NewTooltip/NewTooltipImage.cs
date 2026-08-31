// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.NewTooltipImage
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

/// <summary>Marks a method, property, or field as a tooltip image. Image with highest priority will be displayed as image for object's tooltip. Conent of a tooltip part will be used as image ID</summary>
/// <remarks>See tootlip.md for the full picture.</remarks>
public class NewTooltipImage : NewTooltipAttribute
{
  public NewTooltipImage(
    CacheAs cacheMode,
    int priority = 0,
    TTCat categories = TTCat.Default,
    TTFlags flags = TTFlags.None,
    Type overrideType = null);
}
