// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.CivicsUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Placement;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Services;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.Misc;

public static class CivicsUtils
{
  public static 
  #nullable disable
  ThreadSafeAction<IProposable> ProposableStateChangedEvent;

  public static LocString RevisionAddendum { get; }

  public static LocString ArchiveAddendum { get; }

  public static Result ShouldStopCaptiolChangingAction(
    Type action,
    string propName,
    LawSection section);

  public static Result ShouldStopBasicElectionVoting(
    Type action,
    string propName,
    LawSection section);

  public static void RemoveInvalidProposables(IRegistrar reg);

  /// <summary>Send a message to all 'associated users', that is the creator, owners, and accessors on the deed.</summary>
  public static void SendMessage(this IHostedObject obj, LocString l, NotificationStyle style);

  /// <summary>Returns the creator, owners, and accessors on the deed.</summary>
  public static IEnumerable<User> AssociatedUsers(this IHostedObject obj);

  public static bool TryDestroyProposable(this IProposable proposable, Player player);

  public static LocString GetDistrictDescription(WorldPosition2i pos);

  public static LocString[,] GetPropertyTables(this IProposableContainer container);

  public static bool Active(this IProposable proposable);

  public static T GetOrCreateActiveElement<T>(Func<T, bool> test, Settlement settlement) where T : IProposable;

  public static void UpdateNameSuffix(this IProposable proposable, bool allowRename = false);

  public static bool SetProposedState(
    this IProposable proposable,
    ProposableState newState,
    bool doScan = true,
    bool notify = true,
    CivicsUtils.StateChangeDetailFlags flags = CivicsUtils.StateChangeDetailFlags.None);

  /// <summary>
  /// This is used to check whether we can assign an orphan proposable to a container or not.
  /// Usually all classes that implement the IProposable interface have the same check that's why we just call this function when implementing IHostedObject.CanBeAssignedTo.
  /// </summary>
  public static bool CanBeAssignedToContainer(this IProposable prop, IOrphanAssignment container);

  /// <summary>Open for read-only viewing (No need for a specific access type, everybody should be able to view a proposable).</summary>
  [RPC(AccessType.None)]
  public static void Open(this IProposable prop, Player player);

  public static Election ConstitutionElectionDraft(Settlement settlement);

  /// <summary>
  /// Meant to be called when a <see cref="T:Eco.Gameplay.Civics.Misc.SimpleProposable" /> Object which contains a list of CivicArticles has changed it's state
  /// i.e. a Constitution. This function changes the states of those child CivicArticles as well as update the parent
  /// (if there is none) and HostObject. <paramref name="state" /> may differ from <paramref name="proposable" /> state in case
  /// if we call this function *right before* parent state change.
  /// </summary>
  public static void UpdateChildArticleStates(
    this IEnumerable<CivicArticle> list,
    IProposable proposable,
    ProposableState state);

  /// <summary> Returns objects that are currently hosted on this world object. </summary>
  public static IEnumerable<IProposable> GetHostedProposables(
    IEnumerable<Type> types,
    WorldObject obj);

  public static IEnumerable<IProposable> GetHostedProposables(Type type, WorldObject obj);

  public static IEnumerable<T> All<T>(Settlement settlement, bool includeChildrenSettlement = false) where T : IProposable;

  /// <summary>Return active and valid if settlement is founded (or null), also includes draft and proposed and ignores vailidity if not founded.</summary>
  public static IEnumerable<T> AllApplicable<T>(
    Settlement settlement,
    bool includeChildrenSettlement = false)
    where T : IProposable, ICachesValidity;

  public static IEnumerable<T> AllActiveAndValid<T>(
    Settlement settlement,
    bool includeChildrenSettlement = false)
    where T : IProposable, ICachesValidity;

  public static IEnumerable<T> AllActiveDraftAndProposed<T>(
    Settlement settlement,
    bool includeChildrenSettlement = false)
    where T : IProposable;

  public static IEnumerable<T> AllDrafts<T>(Settlement settlement, bool includeChildrenSettlement = false) where T : IProposable;

  public static IEnumerable<T> AllActive<T>(Settlement settlement, bool includeChildrenSettlement = false) where T : IProposable;

  public static IEnumerable<T> AllActiveAndProposed<T>(
    Settlement settlement,
    bool includeChildrenSettlement = false)
    where T : IProposable;

  public static IEnumerable<T> AllInactive<T>(Settlement settlement, bool includeChildrenSettlement = false) where T : IProposable;

  public static IEnumerable<T> AllOld<T>(Settlement settlement, bool includeChildrenSettlement = false) where T : IProposable;

  public static IEnumerable<T> AllInState<T>(
    ProposableState state,
    Settlement settlement,
    bool includeChildrenSettlement = false)
    where T : IProposable;

  public enum StateChangeDetailFlags
  {
    None,
    Swap,
  }
}
