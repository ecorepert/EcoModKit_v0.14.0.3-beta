// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.VehicleToolComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Category("Hidden")]
[Serialized]
[NoIcon]
public class VehicleToolComponent : InteractableStorage, INetObject
{
  public Action<INetObject> ScoopEvent;
  public static ThreadSafeAction<User, int> OnBlockDug;

  public override WorldObjectComponentClientAvailability Availability { get; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public SelectionInventory ToolInventory { get; set; }

  [Serialized]
  public float[] ToolAngles { get; }

  [SyncToView(null, true)]
  public int OverrideStackSize { get; set; }

  [SyncToView(null, true)]
  public bool ToolControlOnMount { get; set; }

  public bool Minable { get; set; }

  public bool Diggable { get; set; }

  public VehicleToolItem ToolItem { get; }

  public void Initialize(
    int numSlots,
    int maxWeight,
    float joulesPerDigBlock,
    float joulesPerMineBlock,
    float joulesPerBuildBlock = 0.0f,
    bool toolOnMount = false,
    params InventoryRestriction[] restrictions);

  [RPC]
  public void Scoop(List<int> targetObjects);

  [RPC]
  public void Dump(Player player, Vector3i pos);

  [RPC]
  public void WorldObjectInteract(Player player, INetObject obj, InteractionTrigger method);

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdate(BSONObject bsonObj);

  public void ReceiveInitialState(BSONObject bsonObj);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public override Inventory Inventory { get; }
}
