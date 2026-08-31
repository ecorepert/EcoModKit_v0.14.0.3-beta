// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Wrapping.WrappedWorldPositionExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math.Geometry;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math.Wrapping;

/// <summary> Extension methods for wrapped world positions. </summary>
public static class WrappedWorldPositionExtensions
{
  /// <summary>
  /// Calculates wrapped difference between <paramref name="a" /> and <paramref name="b" />.
  /// I.e. for world size (100, 100, 80):
  /// - (10, 10, 10).WrappedDelta(20, 20, 20) -&gt; (-10, -10, -10)
  /// - (10, 10, 10).WrappedDelta(60, 20, 60) -&gt; (-50, -10, -30)
  /// - (10, 10, 10).WrappedDelta(60, 20, 60) -&gt; (-50, -10, -50)
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i WrappedDifference<T>(this 
  #nullable disable
  T a, T b) where T : IWrappedPosition3<int>;

  /// <inheritdoc cref="M:Eco.Shared.Math.Wrapping.WrappedSpace.WrappedXZDistanceSq``1(``0,``0)" />
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int WrappedDistanceSq<T>(this T a, T b) where T : IWrappedPosition3<int>;

  /// <summary>Returns enumerable of XZ rays in wrapped space.</summary>
  public static Ray[] XZWrappedNeighborsRay<TPosition>(this TPosition position) where TPosition : IWrappedPosition3<int>;

  /// <summary>Returns enumerable of positions from current <paramref name="position" /> to <paramref name="other" /> with provided <paramref name="dir" />. Be aware if <paramref name="dir" /> is wrong then position may never be reached!</summary>
  public static IEnumerable<TPosition> StepToInc<TPosition>(
    this TPosition position,
    TPosition other,
    Direction dir)
    where TPosition : IWrappedPosition3WithUnboundedY<int>, IPosition3Factory<TPosition, int>, IEquatable<TPosition>;

  public static TPosition Add<TPosition>(this TPosition position, Direction dir, int count) where TPosition : IWrappedPosition3WithUnboundedY<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition IncrementX<TPosition>(this TPosition position) where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition DecrementX<TPosition>(this TPosition position) where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition IncrementY<TPosition>(this TPosition position) where TPosition : IWrappedPosition3WithUnboundedY<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition DecrementY<TPosition>(this TPosition position) where TPosition : IWrappedPosition3WithUnboundedY<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition IncrementZ<TPosition>(this TPosition position) where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition DecrementZ<TPosition>(this TPosition position) where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryIncrementY<TPosition>(this TPosition position, out TPosition newPosition) where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryDecrementY<TPosition>(this TPosition position, out TPosition newPosition) where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition AddX<TPosition>(this TPosition position, int dx) where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition AddY<TPosition>(this TPosition position, int dy) where TPosition : IWrappedPosition3WithUnboundedY<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryAddY<TPosition>(this TPosition position, int dy, out TPosition newPosition) where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition AddZ<TPosition>(this TPosition position, int dz) where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition Add<TPosition>(this TPosition position, Vector3i delta) where TPosition : IWrappedPosition3WithUnboundedY<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static TPosition Add<TPosition>(this TPosition position, int dx, int dy, int dz) where TPosition : IWrappedPosition3WithUnboundedY<int>, IPosition3Factory<TPosition, int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryAdd<TPosition>(
    this TPosition position,
    int dx,
    int dy,
    int dz,
    out TPosition newPosition)
    where TPosition : IWrappedPosition3<int>, IPosition3Factory<TPosition, int>;
}
