// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetEntity
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Networking;

public class NetEntity : INetObject, INetObjectPosition, IPositionAndBounds, IVersionedNetObject
{
  protected NetObject NetObj { get; set; }

  public NetworkChannel UpdateChannel { get; }

  public int ID { get; }

  public bool Active { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

  public double NetObjectCreationRealtime { get; set; }

  public ulong UpdateVersion { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

  /// <summary>Bumps <see cref="P:Eco.Shared.Networking.NetEntity.UpdateVersion" /> so the next GetObjectUpdates pass for each viewer will re-evaluate IsUpdated for this object. Call from any mutator that changes data clients need to receive.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  protected void BumpUpdateVersion();

  Vector3 IPositionAndBounds.Position { get; }

  public Vector3 Position { [MethodImpl(MethodImplOptions.AggressiveInlining)] protected get; set; }

  public Rect Bounds { get; }

  public Eco.Shared.Math.Quaternion Rotation { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; set; }

  public string Type { get; }

  public NetEntity(string type);

  public NetEntity(string type, INetObject controller);

  public void SetActiveAndCreate();

  public virtual bool IsRelevant(INetObjectViewer viewer);

  public virtual bool IsNotRelevant(INetObjectViewer viewer);

  public virtual void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public virtual void ReceiveInitialState(BSONObject bsonObj);

  public virtual void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public virtual bool IsUpdated(INetObjectViewer viewer);

  public virtual void ReceiveUpdate(BSONObject bsonObj);

  public virtual void Destroy();
}
