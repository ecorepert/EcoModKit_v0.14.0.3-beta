// Decompiled with JetBrains decompiler
// Type: Eco.Stats.Graph
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Stats;

[Serialized]
[BsonAutoSerialize]
public class Graph : ICloneable, IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public Graph();

  public Graph(IEnumerable<Key> statKeys, double startDay, double endDay);

  [Serialized]
  public Key[] Keys { get; set; }

  [Serialized]
  public double TimeMin { get; set; }

  [Serialized]
  public double TimeMax { get; set; }

  public object Clone();

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
