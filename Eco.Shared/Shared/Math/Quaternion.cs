// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Quaternion
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Math;

[TypeConverter(typeof (ValueTypeTypeConverter))]
public struct Quaternion
{
  public float x;
  public float y;
  public float z;
  public float w;
  public static Quaternion Identity;

  [JsonIgnore]
  public float X { get; set; }

  [JsonIgnore]
  public float Y { get; set; }

  [JsonIgnore]
  public float Z { get; set; }

  [JsonIgnore]
  public float W { get; set; }

  public Vector3 Left { get; }

  public Vector3 Right { get; }

  public Vector3 Up { get; }

  public Vector3 Down { get; }

  public Vector3 Forward { get; }

  public Vector3 Back { get; }

  public Quaternion(float x, float y, float z, float w);

  public Quaternion(Quaternion q);

  public static bool operator ==(Quaternion a, Quaternion b);

  public static bool operator !=(Quaternion a, Quaternion b);

  public override int GetHashCode();

  public override bool Equals(object other);

  public static Quaternion operator +(Quaternion q1, Quaternion q2);

  public static Quaternion operator -(Quaternion q1, Quaternion q2);

  public static Quaternion operator *(Quaternion q, float f);

  public static Quaternion operator *(Quaternion q1, Quaternion q2);

  public static Quaternion operator /(Quaternion v, float f);

  public override string ToString();

  public Quaternion Conjugate { get; }

  public float YawDeg { get; }

  public static bool IsNAN(Quaternion q);

  public static bool IsInfinity(Quaternion q);

  public static bool IsValid(Quaternion q);

  public static Quaternion ToQuaternion(Vector3 vector);

  public Vector3 RotateVector(Vector3 vector);

  public Vector3i BottomLeftXZ(Vector3i center, Vector3i size);

  public float RotationAroundAxis(Vector3 axis);

  public static Quaternion LookRotation(Vector3 forward);

  public static Quaternion LookRotation(Vector3 forward, Vector3 up);
}
