// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.PlotPos
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Voxel;

[Serialized]
public struct PlotPos : IEquatable<PlotPos>
{
  public static readonly PlotPos Invalid;

  [Serialized]
  public readonly int X { get; }

  [Serialized]
  public readonly int Y { get; }

  public override string ToString();

  public Vector2i CornerWorldPos { get; }

  public Vector2i CenterWorldPos { get; }

  /// <summary>Convert the plot pos to a regular Vector2i, without doing any kind of coordinate transformation from plot space to world space.</summary>
  public Vector2i RawXY { get; }

  /// <summary>Convert the plot pos to a regular Vector3i, with y=0, without doing any kind of coordinate transformation from plot space to world space.</summary>
  public Vector3i RawX_Z { get; }

  public PlotPos(int x, int y);

  public bool Valid { get; }

  public float WrappedDistance(Vector2i pos);

  public Vector3i X_Z(int newy = 0);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public PlotPos AddAndWrap(Vector2i b);

  public static PlotPos operator +(PlotPos a, PlotPos b);

  public static PlotPos operator -(PlotPos a, PlotPos b);

  public static PlotPos operator *(PlotPos a, PlotPos b);

  public static PlotPos operator /(PlotPos a, PlotPos b);

  public bool Equals(PlotPos other);

  public override bool Equals(object obj);

  public static bool operator ==(PlotPos left, PlotPos right);

  public static bool operator !=(PlotPos left, PlotPos right);

  public override int GetHashCode();
}
