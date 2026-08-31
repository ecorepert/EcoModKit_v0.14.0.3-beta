// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.TerrainGeneratorPosition
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Math;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary> Structure for passing generator position between generator classes. It is optimized for non-copy passing. </summary>
public readonly ref struct TerrainGeneratorPosition
{
  public readonly int WorldX;
  public readonly int WorldY;
  public readonly int WorldZ;
  public readonly double RelativeX;
  public readonly double RelativeY;
  public readonly double RelativeZ;

  public TerrainGeneratorPosition(
    Vector3i worldPos,
    double relativeX,
    double relativeY,
    double relativeZ);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Vector3i GetWorldPos();
}
