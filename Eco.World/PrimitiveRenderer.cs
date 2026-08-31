// Decompiled with JetBrains decompiler
// Type: Eco.World.PrimitiveRenderer
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.World;

public class PrimitiveRenderer : INetObject
{
  public static PrimitiveRenderer Obj { get; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public void ReceiveInitialState(BSONObject bsonObj);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdate(BSONObject bsonObj);
}
