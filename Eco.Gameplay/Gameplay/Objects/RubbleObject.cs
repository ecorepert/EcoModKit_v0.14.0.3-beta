// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.RubbleObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Concurrent;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Objects;

/// <summary> Represents rubble object. These objects are physicly simulated some time and frozen after that. It's done for optimization reasons so rubbles not gonna be simulated forever. </summary>
[Serialized]
[ChatCommandHandler]
public abstract class RubbleObject : 
  IEcoObject,
  INetObject,
  INetObjectPosition,
  IPositionAndBounds,
  IFreezable,
  IPickupable,
  IHasInteractions
{
  public const int MaxAmountPerBlock = 4;

  public NetworkChannel UpdateChannel { get; }

  public virtual Vector3 SpawnOffset { get; }

  /// <summary>This flag should be set when rubble is picking up to prevent concurrent picking same rubble. If you can't set this flag then usually you just need to skip the rubble.</summary>
  public ref ConcurrentFlag PickingUp { get; }

  [Serialized]
  public Vector3 Position { get; set; }

  [Serialized]
  public Eco.Shared.Math.Quaternion Rotation { get; set; }

  public float GroundDistance { get; set; }

  public Rect Bounds { get; }

  public 
  #nullable disable
  Type[] SubRubbleTypes { get; }

  public bool IsBreakable { get; }

  public NetPhysicsEntity NetEntity { get; }

  public static bool BecomesRubble(Type type);

  public void Destroy();

  /// <summary>Client physics may find rubble irrecoverably buried in terrain (spawn desyncs, explosions). Destroys it for every client,
  /// but only when the server agrees it is buried, so a client can't use this to delete arbitrary rubble.</summary>
  [RPC]
  public void DestroyStuck();

  /// <summary> Breaks the chunk of rubble into pieces </summary>
  /// <returns> List of the rubble pieces </returns>
  public List<RubbleObject> Breakup(Player player);

  public static bool TrySpawnFromBlock(
    Player player,
    Type blockType,
    Vector3 position,
    int forced = -1);

  /// <summary> Returns random rubble type from block's meta info if it exists. </summary>
  public static Type GetRandomRubble(Type blockType);

  /// <summary> Not inteneded to be invoked directly, use atomic actions or public `Try-` accessors. </summary>
  internal static void Spawn(Player player, ref Vector3 position, Type[] rubbleTypes);

  [CITest(false)]
  [ChatSubCommand("Land", "Rains rubble around the player.", ChatAuthorizationLevel.Admin)]
  public static void SpawnRubble(User user, string blockTypeName = "Granite", int rubble = 32 /*0x20*/);

  [CITest(false)]
  [ChatSubCommand("Land", "Clears rubble around the player.", ChatAuthorizationLevel.Admin)]
  public static void ClearRubble(User user, float radius = 10f);

  public abstract Task<bool> Pickup(
    Player player,
    InteractionTarget target,
    Inventory targetInv,
    INetObject toolUsed);

  public int ID { get; }

  public bool Active { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

  public double NetObjectCreationRealtime { get; set; }

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveInitialState(BSONObject bsonObj);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdate(BSONObject bsonObj);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);
}
