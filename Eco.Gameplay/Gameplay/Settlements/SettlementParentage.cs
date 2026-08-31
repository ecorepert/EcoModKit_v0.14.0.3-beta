// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementParentage
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements.Internal;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>Class that determines the parent settlement for another settlement.</summary>
[Serialized]
public class SettlementParentage : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Notify]
  public 
  #nullable disable
  ThreadSafeAction<IEnumerable<Settlement>, IEnumerable<Settlement>> ChildrenChangedDetailedEvent { get; set; }

  [Notify]
  public ThreadSafeAction ChildrenChangedEvent { get; set; }

  [Notify]
  public ThreadSafeAction ParentChangedEvent { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public SettlementRoster ChildrenSettlementRoster { get; }

  [SyncToView(null, true)]
  public Settlement ParentSettlement { get; }

  public IReadOnlySet<Settlement> ChildrenSettlements { get; }

  public Settlement Settlement { get; }

  public LocString SettlementTypeName { get; }

  public LocString ParentTypeName { get; }

  public LocString ChildTypeName { get; }

  public IReadOnlySet<Settlement> Members { get; }

  public IReadOnlySet<Settlement> Applicants { get; }

  public IReadOnlySet<Settlement> Invited { get; }

  public Result ChildSettlementAttemptApplyOrJoin(Settlement childSettlement);

  public Result InviteOrAccept(Settlement settlement);

  public Result TryRemove(Settlement settlement);

  public bool RescindInvite(Settlement settlement);

  public bool RejectApplication(User userApproving, Settlement deniedSettlement);

  public bool ClearInvites();

  /// <summary>Add a child to our roster, taking care to remove it from the old one if it has one.</summary>
  public Result AddChild(Settlement target);

  public void Initialize(WorldObject host, Settlement settlement);

  /// <summary>Returns true if A is parent of B or vice versa (or A == B).</summary>
  public bool IsRelated(Settlement set);

  /// <summary>True if ourself or any parent up the hierarchy matches the given settlement.</summary>
  public bool HasAncestor(Settlement potentialAncestor);

  /// <summary>Return enumerable of this settlement, then each parent in order.</summary>
  public IEnumerable<Settlement> Lineage();

  /// <summary>Describe the parents of this settlement and this settlement itself in a single string.  Can do via commas or new lines.</summary>
  public LocString LineageName(bool commas);

  public SettlementRoster GetChildrenSettlementRosterForSyncingOnly();

  public void ClearChildrenSettlements();

  public void Destroy();

  /// <summary>Returns this settlement if the type matches us, otherwise if its a higher type it passes it
  /// too our parent to check.  If its lower type, it return null.</summary>
  public Settlement GetSettlementAtHigherLevel(SettlementType type);

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }
}
