// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.CivicObjectComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Placement;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[CreateComponentTabLoc("Civics", false)]
[HasIcon(null)]
[Ecopedia(null, null, false, true, null)]
[Priority(-200)]
[RequireComponent(typeof (JurisdictionComponent), null)]
public class CivicObjectComponent : 
  WorldObjectComponent,
  INotifyPropertyChanged,
  IController,
  IViewController,
  IHasUniversalID,
  IOrphanAssignment,
  ISettlementAssociated,
  IPickupConfirmationComponent,
  IHostsObjects
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public override 
  #nullable disable
  string ComponentPrefabName { get; }

  [SyncToView(null, true)]
  public override LocString ComponentTabName { get; }

  [SyncToView(null, true)]
  public LocString CivicPowers(Player player);

  [SyncToView(null, true)]
  public LocString CivicTitle { get; }

  [SyncToView(null, true)]
  public bool CanEdit(Player player);

  [SyncToView(null, true)]
  public LocString ObjectListTitle { get; set; }

  [SyncToView(null, true)]
  public virtual Type ObjectType { get; set; }

  [Serialized]
  public int MaxCount { get; set; }

  [SyncToView(null, true)]
  public ProposablePair[] CachedHostedObjects { get; }

  bool IOrphanAssignment.QueueAssignOrphans { get; set; }

  [SyncToView(null, true)]
  public Settlement Settlement { get; set; }

  public void Setup(Type objectType, int slotCount);

  public override void Initialize();

  void IHostsObjects.UpdateHostedStatus();

  public override bool Enabled { get; }

  public override void OnCreate();

  public int UsedSlots { get; }

  /// <summary>We make disable all proposables, meaning we make all the active ones as drafts again, we remove the draft ones and delete all elections currently in progress for them.</summary>
  public void DisableProposables();

  public override void Destroy();

  public void TriggerHostedObjectUpdate();

  [RPC]
  public void CopyFrom(
    Player player,
    IProposable editingTarget,
    IProposable copyFrom,
    IProposable removeOld);

  public IProposable MakeNew(User user, IProposable editingTarget, IProposable copyFrom);

  [RPC]
  public void Edit(Player player, IProposable original, IProposable draft);

  public void ApplyEdit(User user, IProposable proposable);

  [RPC]
  public Task Remove(Player player, IProposable target);

  public IProposable ForceMakeNewDraft(IProposable prop);

  public IProposable ForceMakeNewActive(IProposable prop);

  public LocString GetComponentPickupConfirmation();

  [DoNotNotify]
  ref int IHasUniversalID.ControllerID { get; }
}
