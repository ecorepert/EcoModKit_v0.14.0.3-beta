// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.GarbageResidualTooltipLibrary
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[TooltipLibrary]
public static class GarbageResidualTooltipLibrary
{
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (CompostItem), new Type[] {})]
  public static LocString CompostSourcesTooltip(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (GarbageItem), new Type[] {})]
  public static LocString GarbageSourcesTooltip(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (TailingsItem), new Type[] {})]
  public static LocString TailingsSourcesTooltip(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (WetTailingsItem), new Type[] {})]
  public static LocString WetTailingsSourcesTooltip(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (ChemicalPollutantItem), new Type[] {})]
  public static LocString ChemicalPollutantSourcesTooltip(Type type);
}
