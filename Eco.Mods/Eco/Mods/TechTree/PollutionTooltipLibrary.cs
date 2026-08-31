// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PollutionTooltipLibrary
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Blocks;
using Eco.Gameplay.Garbage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[TooltipLibrary]
public static class PollutionTooltipLibrary
{
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 107, TTCat.Default, TTFlags.None, typeof (BlockItem), new Type[] {})]
  public static LocString GroundPollutionTooltip(this BlockItem blockItem);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 107, TTCat.Default, TTFlags.None, typeof (FractionalBlockItem), new Type[] {})]
  public static LocString FractionalGroundPollutionTooltip(this FractionalBlockItem frac);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 108, TTCat.Default, TTFlags.None, typeof (WasteBlockItem), new Type[] {})]
  public static LocString WastePollutionGraceTooltip(this WasteBlockItem waste);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 107, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString PollutionContainmentTooltip(this WorldObjectItem woItem);
}
