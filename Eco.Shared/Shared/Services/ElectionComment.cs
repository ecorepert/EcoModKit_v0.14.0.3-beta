// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.ElectionComment
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Stats;
using System;

#nullable disable
namespace Eco.Shared.Services;

/// <summary>A custom tailored comment for use in elections web interface (ElectionController). Gets stored in Election.</summary>
[BsonAutoSerialize]
[Serialized]
public class ElectionComment : ICloneable, IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  [Serialized]
  public double TimeSeconds { get; set; }

  [Serialized]
  public string Username { get; set; }

  [Serialized]
  public string Text { get; set; }

  [Serialized]
  public Graph Graph { get; set; }

  [Serialized]
  public Map Map { get; set; }

  public ElectionComment();

  public ElectionComment(string text);

  public object Clone();

  public override bool Equals(object other);

  public override int GetHashCode();

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
