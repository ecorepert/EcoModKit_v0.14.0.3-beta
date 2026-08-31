// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Organisms.TreeEntity
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.GameActions;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Simulation;
using Eco.Simulation.Agents;
using Eco.Simulation.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Mods.Organisms;

[Serialized]
public class TreeEntity : Tree, IHasInteractions
{
  public override bool UpRooted { get; }

  public override float SaplingGrowthPercent { get; }

  public double LastUpdateTime { get; }

  [Serialized]
  public int ChopperUserID { get; protected set; }

  public override IEnumerable<Vector3> TrunkPositions { get; }

  public override bool Ripe { get; }

  public override bool GrowthBlocked { get; }

  public override float GrowthPercent { get; set; }

  public INetObjectViewer Controller { get; }

  [Interaction(InteractionTrigger.InteractKey, null, InteractionModifier.None, new string[] {"canPickup", "id"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void PickUp(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public TreeEntity(TreeSpecies species, WorldPosition3i position, PlantPack plantPack);

  protected TreeEntity();

  public override void Initialize();

  [RPC]
  public void DestroyLeaf(Player player, int leafID);

  [RPC]
  public void DestroyBranch(Player player, int branchID);

  [RPC]
  public void TrySliceTrunkStrict(Player player, float slicePoint, bool ensurePickable = false);

  [RPC]
  public void CheckVehicleHarvestDebris(Player player, Vector3i position);

  [RPC]
  public void CollideWithTerrain(Player player, Vector3i position);

  /// <summary> Fells a tree instantly using a vehicle (Scorpion). Called by the client when the Scorpion grabs a standing tree.
  /// Deals enough damage to fell it in one hit, going through the law system via <see cref="T:Eco.Gameplay.GameActions.GameActionPack" />.
  /// After felling, the client drives the processing sequence: <see cref="M:Eco.Mods.Organisms.TreeEntity.TryStartProcessingTree(Eco.Gameplay.Players.Player,System.Boolean)" /> to begin cutting,
  /// then <see cref="M:Eco.Mods.Organisms.TreeEntity.TryVehiclePickup(Eco.Gameplay.Players.Player,System.String)" /> for each trunk piece to store logs in the vehicle's inventory. </summary>
  [RPC]
  public void HarvestTreeWithVehicle(Player player);

  /// <summary> Picks up a trunk piece and stores it in the vehicle's inventory. Called by the client for two distinct flows:
  /// <list type="bullet">
  ///   <item><b>Scorpion (VehicleTreeHarvestComponent only, no VehicleToolComponent):</b> The Scorpion grabs the tree, processes it
  ///     internally, and calls this RPC automatically for each trunk piece as it is cut. Trunk pieces are moved by the Scorpion during
  ///     processing, so their world position becomes invalid — we only check <see cref="F:Eco.Mods.Organisms.TrunkPiece.Collected" />, not
  ///     <see cref="P:Eco.Mods.Organisms.TrunkPiece.IsValid" />. No size limit: the Scorpion can pick up any trunk size. Uses direct
  ///     <see cref="M:Eco.Gameplay.Items.Inventory.TryAddItemsNonUnique(System.Type,System.Int32,Eco.Gameplay.Players.User)" /> to its <see cref="T:Eco.Gameplay.Components.Storage.PublicStorageComponent" />.</item>
  ///   <item><b>Scoop on SkidSteer/Excavator/SteamTractor (VehicleToolComponent):</b> The Steam Tractor tree cutter fells and cuts
  ///     the tree but drops all trunk pieces on the ground. A vehicle with a scoop attachment then picks them up one by one via this
  ///     RPC. The Steam Tractor has both VehicleTreeHarvestComponent and VehicleToolComponent — the presence of VehicleToolComponent
  ///     routes it through this scoop path. Enforces <see cref="F:Eco.Mods.Organisms.TreeEntity.MaxTrunkPickupSize" /> (pieces must be sliced small enough first) and
  ///     goes through <see cref="T:Eco.Gameplay.GameActions.GameActionPack" /> for law/auth validation. Stores into <see cref="P:Eco.Gameplay.Components.VehicleToolComponent.ToolInventory" />.</item>
  /// </list>
  /// Note: The Steam Tractor tree cutter itself does NOT call this RPC — it only fells/slices the tree via
  /// <see cref="M:Eco.Mods.Organisms.TreeEntity.TryStartProcessingTree(Eco.Gameplay.Players.Player,System.Boolean)" /> and <see cref="M:Eco.Mods.Organisms.TreeEntity.TrySliceTrunkStrict(Eco.Gameplay.Players.Player,System.Single,System.Boolean)" />. Pickup is left to the scoop. </summary>
  [RPC]
  public void TryVehiclePickup(Player player, string trunkIDString);

  [RPC]
  public void TryStartProcessingTree(Player player, bool checkStorage);

  [RPC]
  public void FreezeTrunk(Player player, Guid trunkID, bool freeze);

  public override void FellTree(INetObject killer);

  public GameActionPack TryApplyDamage(
    GameActionPack pack,
    INetObject damager,
    float amount,
    InteractionTarget target,
    Item tool,
    out float damageReceived,
    Type damageDealer = null,
    float experienceMultiplier = 1f);

  /// <summary>Try to destroy stump by applying full damage.</summary>
  public bool TryDestroyStump(Player damager, Item tool);

  public override void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public override void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public override void ReceiveUpdate(BSONObject bsonObj);

  public override bool IsRelevant(INetObjectViewer viewer);

  public override bool IsNotRelevant(INetObjectViewer viewer);

  public bool SetPhysicsController(INetObjectViewer owner);

  /// <summary> Check if we need to send the update to client based on update time. </summary>
  public override bool IsUpdated(INetObjectViewer viewer);

  public override void Destroy();
}
