// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.InfluenceObjects;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements.ClaimStakes;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Voxel;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Settlements;

public static class SettlementUtils
{
  /// <summary>Returns the lowest settlement that is a parent of both left and right (does not include left and right themselves).</summary>
  public static 
  #nullable disable
  Settlement GetCommonAncestor(this Settlement left, IAnnexable right);

  /// <summary>
  /// Returns the set of leaders in a settlement, which is composed of:
  /// - Anyone holding an elected title
  /// - Anyone who created an active law
  /// - Anyone who has ownership access on the capital
  /// </summary>
  public static IEnumerable<User> Leaders(this Settlement settlement);

  /// <summary>Sends a mail to leaders of a settlement, and a chat to all citizens.</summary>
  public static void ChatToCitizensMailToLeaders(this Settlement settlement, LocString msg);

  public static SettlementType? ToSettlementType(this SettlementTypeIndicator_Hack hack);

  public static SettlementType? ToSettlementType(this SettlementType_Hack hack);

  /// <summary>See if there's an active annexation clock on this settlement preventing stuff.s</summary>
  public static Result CheckAnnexationTimer(Settlement settlement, LocString action);

  /// <summary>Return the settlement of the given type, examining parents if it's not our type.</summary>
  public static Settlement SelfOrParent(this Settlement settlement, SettlementType type);

  /// <summary>Return the passed settlement, then its parent, etc recursively.</summary>
  public static IEnumerable<Settlement> SelfAndParents(this Settlement settlement);

  /// <summary>We get all the parents of the specified settlement (we don't return the settlement itself).</summary>
  public static IEnumerable<Settlement> AllParents(this Settlement settlement);

  /// <summary>We get the top parent of this settlement or else we return the settlement itself.</summary>
  public static Settlement TopParent(this Settlement settlement);

  /// <summary>Return the settlement of the given type at the given position.</summary>
  public static Settlement GetSettlementAtPos(SettlementType type, Vector2i worldPos);

  public static Settlement GetSettlementAtPos(SettlementType type, PlotPos plotPos);

  /// <summary>Return the settlement of the lowest type (town before country before federation) at the given position.</summary>
  public static Settlement GetLowestLevelSettlementAtPos(Vector2i worldPos);

  public static Settlement GetLowestLevelSettlementAtPos(PlotPos plotPos);

  /// <summary>Iterators of the influence points at a given level of settlement..</summary>
  public static IEnumerable<Influence> InfluencesAtLevel(SettlementType type);

  /// <summary>Return the settlements currently influencing the given position, in order of the enum</summary>
  public static IEnumerable<Settlement> GetSettlementsAtPos(Vector3i? pos);

  /// <summary>Return the settlements currently influencing the given position, in order of the enum</summary>
  public static IEnumerable<Settlement> GetSettlementsAtPos(this WorldObject obj);

  /// <summary>Return the settlements currently influencing the given position, in order of the enum</summary>
  public static IEnumerable<Settlement> GetSettlementsAtPos(PlotPos plotPos);

  /// <summary>Returns true if the given settlement is contained as a child settlement of this one, or if it *is* this one.</summary>
  public static bool HasChildOrSelf(this Settlement settlement, Settlement child);

  /// <summary>Send a message to all citizens.</summary>
  public static void NotifyLoc(this Settlement settlement, FormattableString msg);

  public static void Notify(this Settlement settlement, LocString msg);

  /// <summary>Returns all the settlement types available.</summary>
  public static IEnumerable<SettlementType> AllTypes();

  /// <summary>Perform an action on all types of settlements.</summary>
  public static void ForAllTypes(Action<SettlementType> a);

  /// <summary>Iterates through all settlements in existance of the given type.</summary>
  public static IEnumerable<Settlement> SettlementsOfType(SettlementType type);

  /// <summary>Claim land in advance of placing a settlement foundation.</summary>
  public static void DoClaimForSettlement(
    GameActionPack pack,
    User user,
    Vector3i worldPos,
    SettlementType type,
    Item settlementItem);

  /// <summary>Return the town influencing the given location, or make a new headless one that covers this location.</summary>
  public static Settlement GetOrMakeTown(User user, Vector2i pos);

  /// <summary>Iterate through all children, and their children, etc, as well as the passed settlement itself.</summary>
  public static IEnumerable<Settlement> SelfAndAllChildrenSettlementsRecursive(
    this Settlement settlement);

  /// <summary>All children settlements of the given settlement.</summary>
  public static IEnumerable<Settlement> ChildrenRecurisve(this Settlement settlement);

  /// <summary>We check whether this settlement can secede and become independant or not.</summary>
  /// <param name="preventingSettlement">The lowest settlement that would prevent any seceding.</param>
  public static bool CanSecedeFromParents(
    this Settlement settlement,
    out Settlement preventingSettlement);

  /// <summary>This will just change an already placed stake from a settlement to another (related deed will not change influencing settlement).</summary>
  /// <returns>Returns whether the claim stake was replaced or not.</returns>
  public static bool ReplaceClaimStake(SettlementClaimStakeObject stake, Settlement newSettlement);

  /// <summary>We check whether the specified alias is allowed to own some properties inside this settlement or not.</summary>
  public static Result AllowOwnership(this Settlement settlement, IAlias alias);

  /// <summary>Check whether this settlement can interact with the specified deed or not (like performing laws on it).</summary>
  public static Result AllowDeedInteraction(this Settlement settlement, Deed deed);

  /// <summary>Destroy the foundation object, returning all non-related items to creator and a foundation item, return all papers and claim stakes to their sources and then permanently Destroy object with all related papers and stakes in all inventories.</summary>
  public static void DestroySettlement(this Settlement settlement, LocString reason);
}
