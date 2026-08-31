// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.UserDetailsTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players.UserHelpers;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class UserDetailsTooltipLibrary
{
  public static void Initialize();

  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString DetailsTooltipTitle(this UserTooltipDetails userDetails);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 70, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString SkillsetTooltip(this UserTooltipDetails userDetails);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 75, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TalentsTooltip(this UserTooltipDetails userDetails, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 80 /*0x50*/, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ContractTooltip(this UserTooltipDetails userDetails);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 110, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString Economy(this UserTooltipDetails userDetails);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 120, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString Titles(this UserTooltipDetails userDetails);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 120, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString Demographics(this UserTooltipDetails userDetails);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 120, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ResidencyTooltip(this UserTooltipDetails userDetails);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 140, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString Food(this UserTooltipDetails userDetails);

  [NewTooltipTitle(CacheAs.Global, 0, TTCat.Default, TTFlags.None, typeof (UserInventory), "")]
  public static LocString UserInventoryTooltipTitle { get; }

  public static void OnContractPropertyChanged(object sender, PropertyChangedEventArgs e);
}
