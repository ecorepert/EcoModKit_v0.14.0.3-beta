// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.WrappedPosition3i
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math.Geometry;
using Eco.Shared.Math.Wrapping;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

/// <summary> Represents a <see cref="T:Eco.Shared.Math.WrappedWorldPosition3i" /> variant in which y limitiations isn't applied, this is meant for objects movements around the world which isn't limited by y block bounds. </summary>
public readonly struct WrappedPosition3i : 
  IWrappedPosition3WithUnboundedY<int>,
  IWrappedPosition3<int>,
  IPosition3<int>,
  IPosition3Factory<WrappedPosition3i, int>,
  IEquatable<WrappedPosition3i>
{
  public readonly ref readonly WrappedSpace Space { get; }

  public int X { get; }

  public int Y { get; }

  public int Z { get; }

  /// <summary> Makes new <see cref="T:Eco.Shared.Math.WrappedPosition3i" /> from unwrapped <paramref name="x" />, <paramref name="y" /> and <paramref name="z" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedPosition3i Create(int x, int y, int z);

  /// <summary> Makes new <see cref="T:Eco.Shared.Math.WrappedPosition3i" /> from unwrapped <paramref name="x" />, <paramref name="y" /> and <paramref name="z" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedPosition3i Create(float x, float y, float z);

  /// <summary>Tries to pack <see cref="T:Eco.Shared.Math.WrappedPosition3i" /> as <see cref="T:Eco.Shared.Math.WorldPosition3i" />. May fail if <see cref="P:Eco.Shared.Math.WrappedPosition3i.Y" /> is out of world grid bounds.</summary>
  public bool TryPack(out WorldPosition3i packed);

  public static implicit operator WrappedPosition3i(Vector3i pos);

  public static implicit operator WrappedPosition3i(WrappedWorldPosition3i pos);

  public static explicit operator Vector3i(WrappedPosition3i pos);

  public static explicit operator WorldPosition3i(WrappedPosition3i pos);

  public static explicit operator WrappedPosition3i(WorldPosition3i pos);

  public static explicit operator WrappedPosition3i(Vector3 pos);

  public static explicit operator Vector3(WrappedPosition3i pos);

  public bool Equals(WrappedPosition3i other);

  public bool Equals(WorldPosition3i other);

  public override bool Equals(object obj);

  public static bool operator ==(WrappedPosition3i left, WrappedPosition3i right);

  public static bool operator !=(WrappedPosition3i left, WrappedPosition3i right);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedPosition3i operator +(WrappedPosition3i left, WrappedPosition3i right);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedPosition3i operator -(WrappedPosition3i left, WrappedPosition3i right);

  public override int GetHashCode();

  public override string ToString();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  WrappedPosition3i IPosition3Factory<WrappedPosition3i, int>.WithComponentsUnchecked(
    int x,
    int y,
    int z);
}
