// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Range
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

[Serialized]
[TypeConverter(typeof (ValueTypeTypeConverter))]
[BsonAutoSerialize]
[Serializable]
public struct Range : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public static readonly Range Invalid;
  public static readonly Range Zero;
  public static readonly Range Unlimited;
  [Serialized]
  public float min;
  [Serialized]
  public float max;

  [JsonIgnore]
  public float Min { get; set; }

  [JsonIgnore]
  public float Max { get; set; }

  public Range(float min, float max);

  public float Mid { get; }

  public float Diff { get; }

  public float RandValExc { get; }

  public int RandIntInc { get; }

  public bool IsValid { get; }

  public float GetRandVal(Random random);

  public int GetRandInt(Random random);

  public float GetIncrement(int count);

  public bool InRangeInc(float val);

  public bool InRangeInc(double val);

  public bool InRangeExc(float val);

  public float Interpolate(float val);

  public float PercentThrough(float val);

  public float PercentThroughQuadratic(float val);

  public float Clamp(float val);

  public Range ExpandFor(float val);

  public Range ClampRange(int min, int max);

  public Range[] Subtract(Range subtract);

  public bool Overlaps(Range range);

  public Range Merge(Range range);

  public static bool operator ==(Range r1, Range r2);

  public static bool operator !=(Range r1, Range r2);

  public override int GetHashCode();

  public override bool Equals(object obj);

  public void Grow(float val);

  public void GrowPercent(float percent);

  public float PercentInMiddle(float val);

  public float IdealRange(float val, float idealRange);

  public string SimpleString { get; }

  /// Return whether a value is in the range, based on a normal random distribution
  public bool InRangeNormalDist(float val);

  public bool InRangeLinearDist(float val);

  public float Distance(float val);

  public static Range MakeInclusive(float val1, float val2);

  public static bool WithinExclusive(float value, float min, float max);

  public static bool WithinExclusive(double value, double min, double max);

  public override string ToString();

  public void ForEach(Action<int> func);

  /// <summary> Make sure the range is &gt;= 0 </summary>
  public void Clamp0();

  public static Range operator *(Range r, float v);

  public static Range operator /(Range r, float v);

  /// <summary> Roumd min down, and max up. </summary>
  public void RoundToInt();

  /// <summary> Roumd min down to the nearest multiple of 'val', and max up. </summary>
  public void RoundToMultiple(float val);

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
