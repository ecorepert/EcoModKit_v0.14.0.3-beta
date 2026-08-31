// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.WrappedPosition3
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math.Geometry;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

/// <summary> Represents a <see cref="T:Eco.Shared.Math.WrappedWorldPosition3" /> variant in which y limitiations isn't applied, this is meant for objects movements around the world which isn't limited by y block bounds. </summary>
public readonly struct WrappedPosition3 : IPosition3<float>
{
  public float X { get; }

  public float Y { get; }

  public float Z { get; }

  /// <summary> Makes new <see cref="T:Eco.Shared.Math.WrappedPosition3" /> from unwrapped <paramref name="x" />, <paramref name="y" /> and <paramref name="z" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedPosition3 Create(float x, float y, float z);

  public static explicit operator WrappedPosition3(Vector3i pos);

  public static implicit operator WrappedPosition3(WrappedWorldPosition3 pos);

  public static implicit operator WrappedPosition3(Vector3 pos);

  public static explicit operator Vector3(WrappedPosition3 pos);

  public bool Equals(WrappedPosition3 other);

  public override bool Equals(object obj);

  public static bool operator ==(WrappedPosition3 left, WrappedPosition3 right);

  public static bool operator !=(WrappedPosition3 left, WrappedPosition3 right);

  public override int GetHashCode();

  public override string ToString();
}
