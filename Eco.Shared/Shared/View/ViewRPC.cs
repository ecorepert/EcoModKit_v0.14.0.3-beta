// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ViewRPC
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.View;

[BsonAutoSerialize]
public struct ViewRPC : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public string RPCName;
  public string DisplayName;
  public string VisibilityParam;
  public string EnabledParam;
  public string Description;
  public ViewRPC.RPCFlags Flags;

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();

  [System.Flags]
  public enum RPCFlags
  {
    AcceptsModifier = 1,
  }
}
