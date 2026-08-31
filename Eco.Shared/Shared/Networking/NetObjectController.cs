// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetObjectController
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Networking;

public abstract class NetObjectController : INetObject
{
  protected readonly NetObject NetObject;

  public int ID { get; }

  public NetworkChannel UpdateChannel { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  protected virtual string Type { get; }

  public virtual void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public virtual void ReceiveInitialState(BSONObject bsonObj);

  public virtual void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public virtual void ReceiveUpdate(BSONObject bsonObj);

  public virtual bool IsRelevant(INetObjectViewer viewer);

  public virtual bool IsNotRelevant(INetObjectViewer viewer);

  public virtual bool IsUpdated(INetObjectViewer viewer);
}
