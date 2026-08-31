// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.VehicleComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (MountComponent), null)]
[RequireComponent(typeof (MinimapComponent), null)]
[RequireComponent(typeof (StatusComponent), null)]
[HasIcon(null)]
[Tag("Vehicles")]
[Tag("Mountable")]
[Ecopedia(null, "Vehicle Component", false, true, null)]
public class VehicleComponent : 
  WorldObjectComponent,
  INetObject,
  IOperatingWorldObjectComponent,
  IInventoryContext
{
  public double ReducePartDurabilityPerHourOfUse;
  public 
  #nullable disable
  ThreadSafeAction VehicleMovedEvent;

  [SyncToView(null, true)]
  [AutoRPC]
  public bool Honk { get; set; }

  [SyncToView(null, true)]
  [AutoRPC]
  public bool Lights { get; set; }

  public ToolbarInventory InventoryContext { get; set; }

  public BuilderInventory BuilderInventoryContext { get; set; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  public Player Driver { get; set; }

  [SyncToView(null, true)]
  public float MaxSpeed { get; }

  [SyncToView(null, true)]
  public string ControlHints { get; set; }

  /// <summary> This property set if Vehicle has fuel supply and it is out of energy. </summary>
  [SyncToView(null, true)]
  public bool OutOfFuel { get; set; }

  [SyncToView(null, true)]
  public bool IsDrivenUnderwater { get; }

  [SyncToView(null, true)]
  public bool IsSinking { get; }

  [SyncToView(null, true)]
  public bool RequiresCalories { get; }

  [SyncToView(null, true)]
  public bool Drivable { get; }

  public bool Operating { get; }

  public virtual LocString DecayDescription { get; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  public MountComponent Mounts { get; }

  public LocString FailDriveMsg { get; set; }

  public INetObject Carrier { get; set; }

  public bool IsMoving { get; }

  /// <summary>True if the vehicle's block position changed within the last <paramref name="seconds" />. A sustained-stillness check that, unlike the instantaneous <see cref="P:Eco.Gameplay.Components.VehicleComponent.IsMoving" />, isn't fooled by a momentary speed dip (e.g. spamming an action mid-drive).</summary>
  public bool MovedWithin(double seconds);

  public override bool Enabled { get; }

  public void SetAdditionalDrivableCheck(Func<bool> func);

  public void Initialize(
    float maxSpeed,
    float efficiencyMultiplier,
    int seats = 1,
    string controlHints = null,
    bool isDrivenUnderwater = false);

  public bool TestDrivable();

  public override void Initialize();

  public void HumanPowered(float caloriesPerSec);

  public override void Tick();

  [RPC(AccessType.ConsumerAccess)]
  public void LockCarried(INetObject net);

  [RPC(AccessType.ConsumerAccess)]
  public void UnlockCarried();

  internal void Dismount(int playerID);

  /// <summary>This RPC asks the server to recompute the vehicle's sinking status. The position is derived server-side
  /// from <see cref="P:Eco.Gameplay.Objects.WorldObject.Position3i" /> on the parent — previously this took a client-supplied position which let
  /// a cheater claim the vehicle was underwater and force-dismount everyone on board. Do nothing if vehicle is able to
  /// move underwater.</summary>
  [RPC(AccessType.None)]
  public void TrySetSinking();

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdate(BSONObject bsonObj);

  [Interaction(InteractionTrigger.InteractKey, "Mount", InteractionModifier.None, new string[] {"Mount"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, InteractionFlags.BlocksOtherInteraction, null, false, new string[] {})]
  [Interaction(InteractionTrigger.InteractKey, "Drive", InteractionModifier.None, new string[] {"Drive"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, InteractionFlags.BlocksOtherInteraction, null, false, new string[] {})]
  [Interaction(InteractionTrigger.InteractKey, "Pull", InteractionModifier.None, new string[] {"Pull"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, InteractionFlags.BlocksOtherInteraction, null, false, new string[] {})]
  [Interaction(InteractionTrigger.InteractKey, "Push", InteractionModifier.None, new string[] {"Push"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, InteractionFlags.BlocksOtherInteraction, null, false, new string[] {})]
  [Interaction(InteractionTrigger.InteractKey, "Steer", InteractionModifier.None, new string[] {"Steer"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, InteractionFlags.BlocksOtherInteraction, null, false, new string[] {})]
  [Interaction(InteractionTrigger.InteractKey, "Paddle", InteractionModifier.None, new string[] {"Paddle"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, InteractionFlags.BlocksOtherInteraction, null, false, new string[] {})]
  public void MountInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  [Interaction(InteractionTrigger.InteractKey, "Sit", InteractionModifier.None, new string[] {"Sit"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.None, (InteractionFlags) 0, null, false, new string[] {})]
  public void MountAtInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  public void ReceiveInitialState(BSONObject bsonObj);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);
}
