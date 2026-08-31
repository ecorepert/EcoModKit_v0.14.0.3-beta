// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ModularVehicleComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.States;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (VehicleComponent), null)]
[CreateComponentTabLoc("Modules", false)]
[HasIcon("ModulesComponent")]
[LocDescription("View and set the attachment to this vehicle.")]
public class ModularVehicleComponent : 
  WorldObjectComponent,
  IInventoryWorldObjectComponent,
  IPermanentDestroyHandler,
  ISyncRotationValue,
  IController,
  IViewController,
  IHasUniversalID,
  IModularVehicleState,
  IHasEnvVars,
  IDeclaresMayHaveComponents
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public override 
  #nullable disable
  string IconName { get; }

  [Serialized]
  [SyncToView(null, true)]
  public AuthorizationInventory Segments { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public AuthorizationInventory Attachments { get; set; }

  [SyncToView(null, true)]
  public string AttachmentTypesString { get; }

  [SyncToView(null, true)]
  public string SegmentTypesString { get; }

  [SyncToView(null, true)]
  public bool ActiveToolUsesControl { get; }

  [SyncToView(null, true)]
  public LocString ActiveToolControlLabel { get; }

  [SyncToView(null, true)]
  public bool ActiveToolShownOnToolbar { get; }

  [SyncToView(null, true)]
  public ModularVehicleToolState State { get; set; }

  [SyncToView(null, true)]
  public Quaternion Rotation { get; set; }

  [RPC]
  public void SetRotation(Quaternion value);

  [RPC]
  public void SetState(ModularVehicleToolState value);

  public Inventory Inventory { get; }

  public VehicleToolItem VehicleToolItem { get; }

  /// <summary>True when the installed attachment has depleted durability. Tool operation paths check this so a broken module stops working.</summary>
  public bool IsToolBroken { get; }

  /// <summary>If the installed attachment is broken, toast the driver and return true so the caller aborts the operation. For the tool paths that bypass the
  /// SetState toggle (scoop dig, tree cutter) — uses a temporary (non-stacking) toast so a continuous path like digging doesn't spam. Returns false when not broken.</summary>
  public bool ToolBrokenNotify(User user);

  [Interaction(InteractionTrigger.RightClick, "Put %SelectedNonTool% as attachment", InteractionModifier.None, new string[] {"SelectedNonTool", "CanPutAttachment"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, Priority = 1f)]
  public void PutAttachment(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  [EnvVar]
  [Notify]
  [DependsOnMember("Attachments")]
  public bool CanPutAttachment(User user);

  /// <summary>Returns the slotted module item of the given type, if any (used by WorldObject.InteractOnModule to route module-interaction RPCs).</summary>
  public Item FindSlottedModule(Type itemType);

  /// <summary>Removes the given module from its slot into the player's inventory. The Attachments ComponentSourceRestriction blocks this if an installed component reports it isn't ready to be uninstalled (e.g. non-empty storage).</summary>
  public void DetachModule(VehicleToolItem item, Player player);

  public void Initialize(
    int segmentSlots,
    int attachmentSlots,
    Type[] segmentTypes,
    Type[] attachTypes);

  public override void Destroy();

  public void OnVehicleMoved();

  public void UpdateVehicleToolItem();

  public override void Tick();

  public IEnumerable<(Type Type, string Name)> ExpectedComponents { get; }

  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet playerInvChanges,
    Inventory targetInventory,
    bool force);
}
