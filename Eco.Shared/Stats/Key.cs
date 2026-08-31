// Decompiled with JetBrains decompiler
// Type: Eco.Stats.Key
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Stats;

[Serialized]
[BsonAutoSerialize]
public class Key : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  [Serialized]
  public Unit Unit;
  [Serialized]
  public string Value;
  public string UnitDisplayName;
  public string DisplayName;

  public Key();

  public Key(BSONObject bson);

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
