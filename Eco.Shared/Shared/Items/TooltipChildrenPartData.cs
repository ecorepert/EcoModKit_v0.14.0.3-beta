// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TooltipChildrenPartData
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Items;

/// <summary>Represents tooltip children part with contained children for specific instance.</summary>
/// <remarks>Origin used to get children should be inferred from context.</remarks>
[BsonAutoSerialize]
public struct TooltipChildrenPartData : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public int PartId;
  public int InstanceId;
  public List<int> ChildrenIDs;
  public List<UniversalIdDetails> ChildrenControllers;

  public TooltipChildrenPartData(
    int partId,
    int instanceId,
    List<int> childrenIDs,
    List<UniversalIdDetails> childrenControllers);

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
