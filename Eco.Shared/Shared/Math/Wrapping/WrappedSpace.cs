// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Wrapping.WrappedSpace
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math.Wrapping;

/// <summary><see cref="T:Eco.Shared.Math.Wrapping.WrappedSpace" /> is a struct which holds information about wrapped space size and provides tools for wrapped space calculations.</summary>
public readonly struct WrappedSpace
{
  public readonly Vector2i SizeXZ;
  public readonly int SizeY;
  private readonly int halfSizeX;
  private readonly int halfSizeZ;

  public int SizeX { get; }

  public int SizeZ { get; }

  public WrappedSpace(Vector3i size);

  /// <summary>
  /// Calculates wrapped difference between <paramref name="a" /> and <paramref name="b" />.
  /// I.e. for world size (100, 100, 80):
  /// - (10, 10, 10).WrappedDelta(20, 20, 20) -&gt; (-10, -10, -10)
  /// - (10, 10, 10).WrappedDelta(60, 20, 60) -&gt; (-50, -10, -30)
  /// - (10, 10, 10).WrappedDelta(60, 20, 60) -&gt; (-50, -10, -50)
  /// </summary>
  public Vector3i WrappedDifference<T>(T a, T b) where T : IWrappedPosition3<int>;

  /// <summary>Calculates wrapped distance (squared) between <paramref name="a" /> and <paramref name="b" />.</summary>
  public int WrappedXZDistanceSq<T>(T a, T b) where T : IWrappedPosition3<int>;

  /// <summary>Calculates wrapped distance (squared) between <paramref name="one" /> and <paramref name="other" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float WrappedXZDistanceSq(Vector2 one, Vector2 other);

  /// <summary>Calculates wrapped distance between <paramref name="a" /> and <paramref name="b" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float WrappedXZDistance<T>(T a, T b) where T : IWrappedPosition3<int>;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int WrapX(int x);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int WrapZ(int z);
}
