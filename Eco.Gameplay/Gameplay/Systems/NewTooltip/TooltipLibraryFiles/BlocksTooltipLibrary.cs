// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.BlocksTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Blocks;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class BlocksTooltipLibrary
{
  public static void Initialize();

  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "Building")]
  public static LocString TooltipTitle(this BlockForm blockForm);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 0, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DescriptionTooltip(this BlockForm blockForm, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 500, TTCat.Controls, TTFlags.None, typeof (BlockItem), new Type[] {})]
  public static LocString BlockItemControls(Type blockItemType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 50, TTCat.Default, TTFlags.None, typeof (BlockItem), new Type[] {})]
  public static LocString BlockItemTier(Type blockItemType);

  [NewTooltipTitle(CacheAs.SubType, 0, TTCat.Default, TTFlags.None, null, "Building")]
  public static LocString TooltipTitle(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Global, 0, TTCat.Default, TTFlags.None, typeof (BlockFill), new Type[] {})]
  public static LocString BlockFillDescription();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 50, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString BlockTierHelpText(this BlockTier blockTier);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString BlockTierTooltip(this BlockTier blockTier);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 101, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString NextTierUp(this BlockTier blockTier);
}
