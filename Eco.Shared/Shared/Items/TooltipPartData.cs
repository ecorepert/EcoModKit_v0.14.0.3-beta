// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TooltipPartData
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Items;

/// <summary>Represents tooltip part with its content for specific instance.</summary>
/// <remarks>Origin used to generate content should be inferred from context.</remarks>
[BsonAutoSerialize]
public struct TooltipPartData : 
  IBsonSerialize,
  IBsonSerializable,
  IBsonDeserializable,
  IEquatable<TooltipPartData>
{
  public int PartId;
  public int InstanceId;
  public LocString Content;

  public TooltipPartData(int partId, int instanceId, LocString content);

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();

  [CompilerGenerated]
  public override readonly string ToString();

  [CompilerGenerated]
  public static bool operator !=(TooltipPartData left, TooltipPartData right);

  [CompilerGenerated]
  public static bool operator ==(TooltipPartData left, TooltipPartData right);

  [CompilerGenerated]
  public override readonly int GetHashCode();

  [CompilerGenerated]
  public override readonly bool Equals(object obj);

  [CompilerGenerated]
  public readonly bool Equals(TooltipPartData other);
}
