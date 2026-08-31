// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.Contract
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Economy.Common;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Placement;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[Ecopedia(null, "Contracts", false, true, null)]
public class Contract : 
  Workable,
  IClauseList,
  ILinkableParameterized<bool>,
  ILinkable,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  IHostedObject,
  INamed,
  IHasTeleportOption,
  IHasSerializableID
{
  public static 
  #nullable disable
  ThreadSafeAction<object, PropertyChangedEventArgs> ContractPropertyChangedEvent;
  public static ThreadSafeAction<User, Contract> ContractCompletedEvent;
  [Serialized]
  public bool CompletedSuccessfully;

  [SyncToView(null, true)]
  [Serialized]
  public int BaseContractID { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string Client { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string Contractor { get; }

  [SyncToView(null, true)]
  [DependsOn("Contractor")]
  public string ContractorDisplay { get; }

  [SyncToView(null, true)]
  [DependsOn("Client")]
  public string ClientDisplay { get; }

  [SyncToView(null, true)]
  public string Payment { get; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<ContractClause> Clauses { get; }

  [Serialized]
  [SyncToView(null, true)]
  public bool AutoAccept { get; }

  [Serialized]
  [SyncToView(null, true)]
  public double EndTime { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float Hours { get; }

  [Serialized]
  [SyncToView(null, true)]
  public int Repetitions { get; set; }

  [Serialized]
  public override ContainedWorkables HostContainer { get; set; }

  [SyncToView(null, true)]
  public bool AuthorizedToAccept(Player player);

  public ContractBoardComponent Board { get; }

  public override bool ShowLocationTooltip { get; }

  public string HoursDescription { get; }

  public IClientControlledContainer ClientControlledContainer { get; }

  public ThreadSafeAction OnStateChanged { get; }

  public ThreadSafeAction OnClauseChange { get; }

  public User ContractorUser { get; }

  public User ClientUser { get; }

  public override User Owner { get; }

  public override string UIName { get; }

  public override Result Valid();

  [RPC]
  public void SetHours(float hours);

  [RPC]
  public void SetAutoAccept(bool set);

  public Result PostJob(User user);

  public void SetupEmpty(User client, WorldObject parent);

  public virtual bool ShouldOverrideAuth(GameAction action);

  /// <summary> Checks if the given action have any implications and applied changes towards this contract, this to avoid applying same changes if multiple contracts are listening to the same action.</summary>
  public bool ActionPerformed(GameAction action);

  public string PaymentAmount();

  public string DepositAmount();

  public string CurrencyName();

  public string CurrencyLink();

  public Result DeleteContract(User user);

  public Result AcceptJob(User user);

  protected Result CanAcceptInternal(User user);

  public void RemoveFromBoard();

  public Result JobFinished(User user);

  public bool DisplayOnBoard { get; }

  public Result MarkJobFailedForced(User user);

  [RPC]
  public override void Open(Player player);

  public override void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  /// <summary>We set the parent contract of the specified clause.</summary>
  public void SetParentContract(INetObject player, object clause);

  public override void Initialize();

  public override void SetupDefault(User user);

  [DependsOnMember("ContractDescription")]
  [SyncToView(null, true)]
  public override LocString Description();

  public void UpdateDescription();

  /// <summary> Returns all the users that are involved in this contract -- the client and the contractor, if they're not null. </summary>
  public override IEnumerable<User> RelevantUsers();

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public override LocString UILinkContent();

  public override LocString UILinkContent(bool param);
}
