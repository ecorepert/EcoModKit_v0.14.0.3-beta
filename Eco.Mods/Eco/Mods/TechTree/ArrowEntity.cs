// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ArrowEntity
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Interactions;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Numerics;

#nullable disable
namespace Eco.Mods.TechTree;

public class ArrowEntity : NetEntity, IDetectHarvest
{
  public NetObjAttachInfo Attached;

  public BowItem BowItem { get; set; }

  public float Damage { get; set; }

  public INetObjectViewer Controller { get; set; }

  public Vector3 Velocity { get; set; }

  [RPC]
  public override void Destroy();

  [RPC]
  public void Hit(NetObjAttachInfo hitAttachInfo, Vector3 position, string location);

  [RPC]
  public void HitStatic(Vector3 position, Eco.Shared.Math.Quaternion rotation);

  public override bool IsRelevant(INetObjectViewer viewer);

  public override bool IsNotRelevant(INetObjectViewer viewer);

  public override void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public override void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void OnHarvest(Player player);
}
