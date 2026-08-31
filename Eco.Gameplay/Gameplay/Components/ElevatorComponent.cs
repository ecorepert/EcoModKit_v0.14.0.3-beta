// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ElevatorComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[Tag("Elevator")]
[NoIcon]
[RequireComponent(typeof (VehicleCarrierComponent), null)]
public class ElevatorComponent : WorldObjectComponent, INetObjectPriority, INetObject
{
  public ThreadSafeAction BeforeDestroy;
  public float DurabilityCostPerUse;

  public float Priority { get; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  [AutoRPC]
  public bool IsCarryingVehicles { get; set; }

  public override void OnCreate();

  public override void Destroy();

  public override void Initialize();

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  /// <summary>Update cage's position, velocity and state.</summary>
  public void ReceiveUpdate(BSONObject bsonObj);

  [Interaction(InteractionTrigger.InteractKey, "Up", InteractionModifier.None, new string[] {"Up"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void MoveUp(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.InteractKey, "Down", InteractionModifier.None, new string[] {"Down"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void MoveDown(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.InteractKey, "Stop", InteractionModifier.None, new string[] {"Stop"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void Stop(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  public void ReceiveInitialState(BSONObject bsonObj);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public enum State
  {
    Stopped,
    MovingUp,
    MovingDown,
  }
}
