// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LureEntity
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Numerics;

#nullable disable
namespace Eco.Mods.TechTree;

public class LureEntity : NetEntity
{
  public Vector3 CastForce;

  public INetObjectViewer Controller { get; set; }

  [RPC]
  public override void Destroy();

  public override void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public override void ReceiveUpdate(BSONObject bsonObj);

  public override bool IsUpdated(INetObjectViewer viewer);

  public override void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void FishCaught(int fishId);
}
