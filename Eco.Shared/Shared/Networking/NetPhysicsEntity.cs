// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetPhysicsEntity
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Networking;

public class NetPhysicsEntity : NetEntity
{
  public bool PositionChecksEnabled;

  public INetObjectViewer Controller { get; }

  public double LastReceivedUpdateTime { get; }

  public Vector3 Velocity { get; set; }

  public bool CanTeleport { get; }

  public static event Action<string, NetPhysicsEntity, NetObject> UpdatePositionFail;

  public NetPhysicsEntity(string type);

  public NetPhysicsEntity(string type, INetObject controller);

  public override void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public override bool IsRelevant(INetObjectViewer viewer);

  public override bool IsNotRelevant(INetObjectViewer viewer);

  public override bool IsUpdated(INetObjectViewer viewer);

  public override void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public override void ReceiveUpdate(BSONObject bsonObj);

  public bool SetPhysicsController(INetObjectViewer owner, Func<bool> canTeleportCheck = null);

  /// <summary>Counts the stored pose as freshly received so <see cref="M:Eco.Shared.Networking.NetPhysicsEntity.IsUpdated(Eco.Shared.Networking.INetObjectViewer)" /> resends it to every viewer. For server initiated pose writes.</summary>
  public void MarkPoseUpdated();
}
