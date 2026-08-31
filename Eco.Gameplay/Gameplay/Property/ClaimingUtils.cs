// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.ClaimingUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.SharedTypes;
using Eco.Shared.Voxel;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Property;

public static class ClaimingUtils
{
  /// <summary>Check if the given plot pos neighbors any plot on this deed.</summary>
  public static bool PositionNeighborsDeed(this 
  #nullable disable
  Deed deed, PlotPos plotPos);

  /// <summary>Check whether we can remove that plot from this deed or not.</summary>
  public static Result CheckCanChangePlotsAndNotify(
    this Deed deed,
    User user,
    IEnumerable<PlotPos> newPlots,
    IEnumerable<PlotPos> removedPlots);

  /// <summary>We check whether by removing or adding the specified plots the deed stay contiguous or become split.</summary>
  public static bool CheckDeedIsContiguousAndNotify(
    this Deed deed,
    User user,
    List<PlotPos> toAdd = null,
    List<PlotPos> toRemove = null,
    LocString details = default (LocString));

  /// <summary>
  /// Gets all contiguous parts for deed after adding to it to Add plots and removing toRemove
  /// It's used to show dialog about changes (remove some deed will create N deeds by example) and to split deed to subdeeds if needed
  /// </summary>
  public static List<List<PlotPos>> GetContiguousPartsWithAlterations(
    this Deed deed,
    List<PlotPos> toAdd = null,
    List<PlotPos> toRemove = null);

  public static Task<Result> ClaimAsync(
    User actor,
    PlotPos? plotPos,
    InteractionModifier modifier,
    ItemStack claimStack,
    Deed forceDeed,
    bool usePlotCount);

  public static void ChangeWithDialog(
    Player player,
    IEnumerable<Deed> nearbyDeeds,
    PlotPos plotPos,
    ItemStack claimStack = null);

  /// <summary>If all the owners are abandoned then this deed is considered abandoned also.</summary>
  public static bool DeedOwnedByAbandonedPlayer(this Deed deed);
}
