// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Species.PlantSpeciesInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Species;

[BsonAutoSerialize]
public class PlantSpeciesInfo : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public int TypeID;
  public int ResourceItemTypeID;
  public string Name;
  public string DisplayName;

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
