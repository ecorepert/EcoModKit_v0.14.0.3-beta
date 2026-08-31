// Decompiled with JetBrains decompiler
// Type: Eco.World.AtmosphereObject
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.World;

public abstract class AtmosphereObject : INetObject, INetObjectPriority
{
  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void SetDestroyedAtmosphere(float percent, float time = 120f);

  public float Priority { get; }

  public bool Active { get; }

  public int ID { get; }

  public double NetObjectCreationRealtime { get; set; }

  public void Destroy();

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public void ReceiveInitialState(BSONObject bsonObj);

  public void ReceiveUpdate(BSONObject bsonObj);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);
}
