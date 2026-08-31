// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.WorldLayerUtils
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Shared.States;
using System;

#nullable disable
namespace Eco.Simulation.WorldLayers;

/// <summary>Contains a set of utility methods for WorldLayers.</summary>
public static class WorldLayerUtils
{
  /// <summary>Returns whether the given position is in a given biome.</summary>
  /// <param name="margin">optional, describes how much overlap the position needs to have with the biome to be considered in the biome.</param>
  public static bool IsInBiome(this Vector2i worldpos, BiomeType biome, float margin = 0.0f);

  public static bool IsInDeepOcean(this Vector2i worldpos);

  public static bool IsInOcean(this Vector2i worldpos);

  /// <summary>Ocean test for bulk queries: resolves the biome layers once instead of paying an enum-name and layer lookup per call like <see cref="M:Eco.Simulation.WorldLayers.WorldLayerUtils.IsInOcean(Eco.Shared.Math.Vector2i)" />.</summary>
  public static Func<Vector2i, bool> InOceanTest();

  /// <summary>Return a position with Y above sea level if this is under it or at it.</summary>
  public static Vector3i CapAboveSeaLevel(this Vector3i pos);
}
