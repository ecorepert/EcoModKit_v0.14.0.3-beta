// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.ContractBoardComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Components;
using Eco.Gameplay.Economy.Common;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Economy.WorkParties;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Economy;

[Serialized]
[RequireComponent(typeof (MinimapComponent), null)]
[HasIcon(null)]
[Tag("Economy")]
[Ecopedia(null, null, false, true, null)]
public class ContractBoardComponent : 
  TrackPlacementComponent,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  internal const int MaxContracts = 18;
  internal const int MaxDistanceFromBoard = 8;

  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public 
  #nullable disable
  IEnumerable<Contract> Contracts { get; }

  [SyncToView(null, true)]
  public IEnumerable<WorkParty> WorkParties { get; }

  public IEnumerable<Workable> Workables { get; }

  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public ContainedWorkables ContainedWorkables { get; set; }

  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  [Serialized]
  protected override object Data { get; set; }

  protected override IEnumerable<IProposable> TrackedObjects { get; }

  public override void Initialize();

  protected override void InitializePersistentData();

  public override void Destroy();

  public void UpdateContractList();

  public void UpdateWorkPartyList();

  public void DebugAddWorkable(User user, Workable workable);

  public Contract DebugAddContract(User user, string name);

  [RPC]
  public Task AddWorkParty(Player player);

  public void AddExistingWorkParty(WorkParty party);

  public void AddExistingContract(Contract contract);

  public void RemoveContract(Contract contract);

  [RPC]
  public Task AddContract(Player player);

  /// <summary> Checks if there are stashed entries and suggests to post them on this board. </summary>
  /// <returns> False if there are no stashed entries or if the player declined the suggestion. </returns>
  public Task<bool> TryGetFromStash(Player player, bool checkContracts = false, bool checkParties = false);

  public override void ForceAdd(IProposable entry);
}
