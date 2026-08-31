// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.WorkParty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Economy;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Economy.Common;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
[Ecopedia(null, "Work Parties", false, true, null)]
public class WorkParty : 
  Workable,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  IValidity,
  IDescribable,
  IProvidesContext,
  IHasUserAggregatedAmount
{
  [Eco.Core.Controller.Notify]
  public static 
  #nullable disable
  ThreadSafeAction<WorkParty> LaborerChangedEvent { get; }

  [Eco.Core.Controller.Notify]
  public static ThreadSafeAction<WorkParty> WorkDescriptionChangedEvent { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The list of laborers signed up for the project, and text descriptions of what their role is.  Each role can also have a skill requirement or other restriction.")]
  public ControllerList<Laborer> Laborers { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The list of work that is to be performed for this work party.")]
  public ControllerList<Eco.Gameplay.Economy.WorkParties.Work> Work { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Details on how payments will be made for this work party.")]
  [AllowEmpty]
  public ControllerList<Eco.Gameplay.Economy.WorkParties.Payment> Payment { get; set; }

  [SyncToView(null, true)]
  [DependsOn("GeneralRequirementsBool")]
  public string GeneralRequirements { get; }

  [Serialized]
  public GameValue<bool> GeneralRequirementsBool { get; set; }

  [Serialized]
  public override ContainedWorkables HostContainer { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public bool ExpandRoles { get; set; }

  [SyncToView(null, true)]
  public float PercentDone { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  [DependsOnMember("State")]
  [DependsOnMember("Work")]
  [DependsOnMember("Laborers")]
  [DependsOnSubMember("Laborers", "Citizen")]
  [SyncToView(null, true)]
  public override LocString Description();

  [DependsOnMember("Work")]
  [DependsOnMember("Payment")]
  [SyncToView(null, true)]
  public LocString ShortWorkDesc();

  [SyncToView(null, true)]
  [DependsOnController("Work", true)]
  public Vector3i Position { get; }

  public override User Owner { get; }

  public override string UIName { get; }

  [SyncToView(null, true)]
  public string HostObjectName { get; }

  public override bool ShowLocationTooltip { get; }

  internal void UpdateHostName();

  public void Notify(LocString text);

  public override void Initialize();

  [RPC]
  public void SetGeneralRequirements(Player player);

  [RPC]
  public void AddPayment(Player player);

  [RPC]
  public void EditPayment(Player player, int index);

  internal void OnWorkPerformed(
    User user,
    Eco.Gameplay.Economy.WorkParties.Work work,
    AddToWorkOrderAction addAction,
    float percentDelta,
    float laborAdded = 0.0f);

  public override void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  public Result Post(User user);

  [RPC]
  [RPCAuthMaxProposableState(ProposableState.Active)]
  public Task Leave(Player player);

  public Task<Result> Leave(User user, bool forced = false);

  [RPC]
  [RPCAuthMaxProposableState(ProposableState.Active)]
  public void Join(Player player, Laborer laborer);

  public Result Join(User user, Laborer laborer);

  public void WorkOrderDestroyed(WorkOrder order);

  [RPC]
  public void SetWorkOrders(Player player, List<WorkOrder> workOrders);

  public void SetWorkOrders(User user, List<WorkOrder> workOrders, bool quiet);

  public TWork GetWork<TWork>(WorkOrder order) where TWork : WorkOrderWork;

  [RPC]
  [RPCAuthMaxProposableState(ProposableState.Active)]
  public Task<bool> Cancel(Player player);

  public void ForceCancel();

  public LocString StateDesc();

  public override IEnumerable<User> RelevantUsers();

  public IEnumerable<User> Users();

  public bool ContainsUser(User user);

  public void ActionPerformed(GameAction action);

  public bool ShouldOverrideAuth(GameAction action);

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  internal bool HasLaborer(User user);

  /// <summary> Handles aggregate payments for PayAsYouGo feature, User is the laborer reference and weighted percent delta is the change in his contribution to the work party. </summary>
  /// <inheritdoc cref="M:Eco.Gameplay.Civics.Economy.IHasUserAggregatedAmount.OnUserAggregateAmountDue(Eco.Gameplay.Players.User,System.Single)" />
  public void OnUserAggregateAmountDue(User user, float weightedPercentDelta);
}
