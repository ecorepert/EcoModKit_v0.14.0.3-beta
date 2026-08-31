// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.RPCInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary><see cref="T:Eco.Shared.Networking.RPCInfo" /> contains identifying information for RPC method. The method may be called by name or by Id (usually faster and may be only way to call overloaded RPC methods). This info shared with client.</summary>
[BsonAutoSerialize]
public class RPCInfo : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public int Id;
  public string Key;

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
