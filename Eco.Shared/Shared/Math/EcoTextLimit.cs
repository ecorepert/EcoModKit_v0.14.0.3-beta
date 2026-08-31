// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.EcoTextLimit
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Math;

/// <summary>
/// EcoTextLimit allows for limiting text length in Eco with respect to whether or not the text contains tags. Max is used for text without tags, while MaxWithTags is used for text with tags.
/// </summary>
[TypeConverter(typeof (ValueTypeTypeConverter))]
[BsonAutoSerialize]
[Serializable]
public struct EcoTextLimit : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public static readonly EcoTextLimit Invalid;
  public static readonly EcoTextLimit Zero;
  public static readonly EcoTextLimit Unlimited;
  [JsonIgnore]
  [Serialized]
  public int Min;
  [JsonIgnore]
  [Serialized]
  public int Max;
  [JsonIgnore]
  [Serialized]
  public int MaxWithTags;

  public EcoTextLimit(int min, int max, int maxWithTags);

  public static bool operator ==(EcoTextLimit r1, EcoTextLimit r2);

  public static bool operator !=(EcoTextLimit r1, EcoTextLimit r2);

  public override int GetHashCode();

  public override bool Equals(object obj);

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
