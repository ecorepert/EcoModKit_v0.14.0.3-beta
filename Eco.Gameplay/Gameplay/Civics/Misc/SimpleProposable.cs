// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.SimpleProposable
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Placement;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics.Misc;

[RPCAuthMaxProposableState(ProposableState.Draft)]
[Browsable(false)]
public abstract class SimpleProposable : 
  SimpleEntry,
  IProposable,
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  IHostedObject,
  ILinkable,
  IHasTeleportOption,
  ILinkableParameterized<bool>,
  ICustomValidity,
  IValidity,
  ISuffixName,
  ISingleEditingUser,
  IPlayerUseTracking,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  ISettlementAssociated,
  IRPCAuthChecks
{
  [Serialized]
  protected bool requiresHost;

  public 
  #nullable disable
  ThreadSafeList<WeakReference> UsingPlayers { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [DontClone]
  [AdminEdtiableOnly]
  public ProposableState State { get; set; }

  [SyncToView(null, true)]
  [DependsOn("HostObject")]
  public Guid HostID { get; }

  [Serialized]
  public WorldObjectHandle HostObject { get; protected set; }

  [Serialized]
  [SyncToView(null, true)]
  [DontClone]
  public IProposable TargetToReplace { get; set; }

  [Serialized]
  public bool ScanPeriodically { get; set; }

  [Serialized]
  public double LastValidTime { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public bool Submitted { get; set; }

  [Serialized]
  public IProposable RevisionParent { get; set; }

  [Serialized]
  public Election Election { get; set; }

  [Serialized]
  public User RemovedBy { get; set; }

  [Serialized]
  public Election RemovalElection { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Settlement Settlement { get; set; }

  [SyncToView(null, true)]
  public User CurrentEditingUser { get; set; }

  public virtual bool RequiresHost { get; }

  public void SetRequiresHost(bool set);

  public virtual bool DescribedWithTable { get; }

  protected virtual bool RequiresSlot { get; }

  public virtual bool IsActive { get; }

  public virtual bool WasRemoved { get; }

  public virtual Result Valid();

  public virtual void DisableHostedObject();

  public virtual void AssignHostObject(WorldObject newHost);

  public virtual bool CanBeAssignedTo(IOrphanAssignment container);

  public override void Initialize();

  /// <summary>Callback before state change, we need it separate from OnStateChangedInternal to ensure when we set State any State subscription will deal with valid state.</summary>
  public virtual void OnBeforeStateChangeInternal(
    ProposableState newState,
    CivicsUtils.StateChangeDetailFlags flags);

  /// <summary>Callback when state changed.</summary>
  public virtual void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  public virtual void InitializeDraftProposable();

  public virtual Dictionary<IHasID, IHasID> GetPairsOfOldAndNewRevisions(IProposable old);

  public virtual void ApplyUpdatedProposable(IProposable old);

  bool IRPCAuthChecks.IsRPCAuthorized(
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);

  Settlement IHostedObject.HostingSettlement { get; }

  public virtual void OnCreate();

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public override void Destroyed();

  [RPC(RequiredAccess = AccessType.Admin)]
  public void SetState(ProposableState newState);

  bool IHostedObject.CanBeEdited { get; set; }

  [Serialized]
  int IHostedObject.ExpirationWarningsIssued { get; set; }
}
