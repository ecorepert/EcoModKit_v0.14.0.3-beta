// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Pathfinding.Internal.PackedPathNode
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#nullable enable
namespace Eco.Simulation.Pathfinding.Internal;

/// <summary>Stores the types of transitions to all 8 neighbors</summary>
[Serialized]
[StructLayout(LayoutKind.Sequential, Size = 2)]
public struct PackedPathNode
{
  private uint packed;
  private static readonly uint NorthBitMask;
  private static readonly uint NorthEastMask;
  private static readonly uint EastBitMask;
  private static readonly uint SouthEastMask;
  private static readonly uint SouthBitMask;
  private static readonly uint SouthWestMask;
  private static readonly uint WestBitMask;
  private static readonly uint NorthWestMask;
  private static readonly uint BlockTypeMask;
  private static readonly 
  #nullable disable
  uint[] AllDirMaskes;
  private static readonly (int X, int Z)[] AllDirs;
  private static readonly bool[] NotBlockedMovabilities;

  public PackedPathNode.Movability DirMovability(HorzDir dir);

  public void SetDirMovability(HorzDir dir, PackedPathNode.Movability value);

  public PackedPathNode.PathBlockType BlockType { get; }

  /// <summary>Create a packed node, querying the world around it to determine the movabilities in each direction.</summary>
  /// <param name="pos"></param>
  public PackedPathNode(WorldPosition3i pos);

  public int FillMovableDirections(WorldPosition3i centerPos, Span<WorldPosition3i> values);

  public int FillMovableDirections(
    WorldPosition3i centerPos,
    Span<WorldPosition3i> values,
    bool[] acceptableTransitions);

  public int FillMovableDirectionsAndPos(
    WorldPosition3i centerPos,
    Span<(WorldPosition3i Pos, PackedPathNode.Movability Mov, HorzDir Dir)> values,
    bool[] acceptableTransitions = null);

  /// <summary>Traverse in the given direction, if possible and return the position and movability.</summary>
  public (WorldPosition3i Pos, PackedPathNode.Movability Mov) GetPosForDir(
    WorldPosition3i pos,
    HorzDir dir);

  public PackedPathNode.Movability North { get; }

  public PackedPathNode.Movability NorthEast { get; }

  public PackedPathNode.Movability East { get; }

  public PackedPathNode.Movability SouthEast { get; }

  public PackedPathNode.Movability South { get; }

  public PackedPathNode.Movability SouthWest { get; }

  public PackedPathNode.Movability West { get; }

  public PackedPathNode.Movability NorthWest { get; }

  public PackedPathNode(uint value);

  public static implicit operator uint(PackedPathNode wrapper);

  public static implicit operator PackedPathNode(uint value);

  public override string ToString();

  public bool IsFlat();

  /// <summary>Returns number of transitions that aren't walk. 0 means totally flat, 8 means least possible flat.</summary>
  public int Flatness();

  /// <summary>Returns all valid neighbors for this node at the given position.</summary>
  public IEnumerable<WorldPosition3i> GetNeighbors(WorldPosition3i pos);

  public enum Movability
  {
    Walk,
    Blocked,
    SmallJumpUp,
    SmallJumpDown,
    BigJumpUp,
    BigJumpDown,
    DoubleJumpUp,
    DoubleJumpDown,
  }

  public enum PathBlockType
  {
    Solid,
    Water,
  }
}
