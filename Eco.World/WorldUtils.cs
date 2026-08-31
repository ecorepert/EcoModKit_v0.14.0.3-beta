// Decompiled with JetBrains decompiler
// Type: Eco.World.WorldUtils
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Math;
using System;
using System.Numerics;

#nullable disable
namespace Eco.World;

public static class WorldUtils
{
  public static Vector3i Wrap(this Vector3i worldPos);

  public static Vector3 Wrap(this Vector3 worldPos);

  public static bool IsInWorldBounds(this Vector3i worldPos);

  /// <summary> Check that a position is a valid position for an animal to path through. </summary>
  public static bool IsValidPathPos(this WorldPosition3i pos);

  public static bool IsValidPathPos(this Vector3i pos);

  /// <summary>Returns the position of the top empty block at the given x/z pos.</summary>
  public static Vector3i GetTopEmptyBlockPos(this Vector2i worldPos);

  /// <summary> Return true if the block pos is just above solid ground but is not itself solid. </summary>
  public static bool IsJustAboveGround(this WorldPosition3i pos);

  public static bool IsJustAboveGround(this Vector3i pos);

  /// <summary> Return true if the block pos is solid and above is not. </summary>
  public static bool IsTopGround(this WorldPosition3i pos);

  public static bool IsTopGround(this Vector3i pos);

  /// <summary> Description of a position based on what's going on in the world there. </summary>
  public static WorldUtils.PosDescription Describe(this WorldPosition3i pos);

  public static WorldUtils.PosDescription Describe(this Vector3i pos);

  public static void DoForNeighborChunks<T>(
    Vector3i chunkPos,
    Vector3i localPos,
    T context,
    Action<Vector3i, T> action);

  public enum PosDescription
  {
    Unknown,
    Underground,
    RiverBed,
    TopGround,
    JustAboveGround,
    HighInAir,
    DeepUnderwater,
    WaterSurface,
    JustAboveWater,
  }
}
