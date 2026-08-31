// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.SettlementTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Settlements.Annexation;
using Eco.Gameplay.Settlements.ClaimStakes;
using Eco.Gameplay.Settlements.Components;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class SettlementTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy("SettlementLineageNameChangedEvent", null, null)]
  [TooltipAffectedBy("AdvertisementToNewPeopleEnteringWorld", null, null)]
  [TooltipAffectedBy("LeaderAndCitizensUpdatedEvent", null, null)]
  [TooltipAffectedBy("FoundedEvent", null, null)]
  [TooltipAffectedBy("Enabled", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 100, TTCat.Default, TTFlags.ClearCacheForAllUsers, null, new Type[] {})]
  public static LocString SettlementHeaderTooltip(this 
  #nullable disable
  Settlement settlement, User user);

  [TooltipAffectedBy(typeof (Settlement), "HostObject", null, null)]
  [TooltipAffectedBy(typeof (Settlement), "Leader", "MarkedUpName", null)]
  [TooltipAffectedBy(typeof (Settlement), "Constitution", "MarkedUpName", null)]
  [TooltipAffectedBy(typeof (Settlement), "ImmigrationPolicy", null, null)]
  [TooltipAffectedBy(typeof (Settlement), "ImmigrationPolicy", "MarkedUpName", null)]
  [TooltipAffectedBy(typeof (Settlement), "Leader", "MarkedUpName", null)]
  [TooltipAffectedBy(typeof (Settlement), "Constitution", "MarkedUpName", null)]
  [TooltipAffectedBy(typeof (Settlement), "CachedData", true)]
  [TooltipAffectedBy(typeof (Settlement), "LeaderAndCitizensUpdatedEvent", null, null)]
  [TooltipAffectedBy(typeof (Settlement), "Taxes", true)]
  [TooltipAffectedBy(typeof (Settlement), "InfluenceSourceDeeds", null, null)]
  [TooltipAffectedBy(typeof (Settlement), "Parentage", "ParentSettlement", null)]
  [TooltipAffectedBy("FoundedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString SettlementTooltip(this Settlement settlement);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString SettlementClaimStakeComponentTooltip(
    this SettlementClaimStakeComponent claimStake);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ClaimStakeItemBaseTooltip(this SettlementClaimStakeItem stake);

  [TooltipAffectedBy(typeof (AnnexationRecord), true)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.SpecialPart1, TTFlags.None, null, new Type[] {})]
  public static LocString PlotsTooltip(this AnnexationRecord record);

  [TooltipAffectedBy(typeof (AnnexationRecord), true)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.SpecialPart2, TTFlags.None, null, new Type[] {})]
  public static LocString CultureTooltip(this AnnexationRecord record);

  [TooltipAffectedBy("Settlement", null, null)]
  [TooltipAffectedBy("Settlement", "MarkedUpName", null)]
  [TooltipAffectedBy("Settlement", "TypeAndName", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString SettlementFoundationTooltip(
    this SettlementFoundationComponent settlementFoundation);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 500, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString CitizenRemovalTooltip(this Settlement settlement);
}
