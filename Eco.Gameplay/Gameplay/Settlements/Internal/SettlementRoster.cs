// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Internal.SettlementRoster
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.UI;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Settlements.Internal;

/// <summary>A list of settlements that can only be changed with mutual civic actions. Used for deciding parentage of settlements.</summary>
[Serialized]
public class SettlementRoster : 
  IController,
  IViewController,
  IHasUniversalID,
  IRoster,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [SyncToView(null, true)]
  [Serialized]
  public 
  #nullable disable
  ControllerHashSet<Settlement> Members { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public ControllerHashSet<Settlement> Applicants { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public ControllerHashSet<Settlement> Invited { get; set; }

  [SyncToView(null, true)]
  public LocString Title { get; }

  [DependsOnSubMember("Settlement", "Name")]
  [DependsOnSubMember("Settlement", "Creator")]
  [SyncToView(null, true)]
  public LocString Status();

  public void Clear();

  public void Initialize(
    Settlement settlement,
    Action<IEnumerable<Settlement>, IEnumerable<Settlement>> childrenChangedEvent);

  [RPC]
  public bool RejectApplication(User userApproving, Settlement deniedSettlement);

  [SyncToView(null, true)]
  public bool CanApprove(User user);

  [RPC]
  public void Approve(User userApproving, Settlement settlementApplicant);

  public Result Add(Settlement settlement, bool sendChangeEvent = true);

  public Result ChildSettlementAttemptApplyOrJoin(Settlement childSettlement);

  public Result InviteOrAccept(Settlement childSettlement);

  public bool RescindInvite(Settlement settlement);

  public bool ClearInvites();

  /// <param name="ignoreParents">
  /// If this is set to false then we will check whether the parent settlements allow child settlements to secede and if not, the specified settlement
  /// will instead be joing one of the parents as a direct child when it leaves its current parent.
  /// </param>
  public Result TryRemove(Settlement settlement, bool ignoreParents = false, bool triggerChangeEvent = true);

  [SyncToView(null, true)]
  public bool CanAdminAssign(Player player);

  [RPC]
  [VisibilityParam("CanAdminAssign")]
  public Task AdminAssign(Player player);

  public int MemberCount { get; }

  public void SubscribeRosterChange(Action onChanged);

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
