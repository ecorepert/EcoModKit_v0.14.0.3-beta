// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.InteractionQueryInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Items;

[BsonAutoSerialize]
public class InteractionQueryInfo : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  /// <summary> Target object, if set. </summary>
  public INetObject TargetObject { get; set; }

  /// <summary> If TargetObject is set, the position the ray interacted with the object. </summary>
  public Vector3? HitPosition { get; set; }

  /// <summary> Custom parameters. </summary>
  public BSONObject Parameters { get; set; }

  /// <summary> The targeted blocks position, if TargetObject is not set. </summary>
  public Vector3i? BlockPosition { get; set; }

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
