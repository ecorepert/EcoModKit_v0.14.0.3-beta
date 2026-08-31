// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetObjAttachInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Networking;

[BsonAutoSerialize]
public class NetObjAttachInfo : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public int OwnerID;
  public int ParentID;
  public byte[] Hierarchy;
  public Vector3 LocalPosition;
  public Vector3 LocalEulerAngles;
  public Vector3 LocalScale;
  public string HitInfo;

  public void Copy(out NetObjAttachInfo netObjAttachInfoCopy);

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
