// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.BlockOccupancy
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using System;

#nullable enable
namespace Eco.Gameplay.Occupancy;

/// <summary>Represents an occupancy position in a world object. Used to check if a block is available relative to the world object position. They are mainly used in WorldOccupancyAutogen.cs to declare each occupancy from a WorldObject </summary>
public struct BlockOccupancy
{
  public Vector3i Offset;
  public Type BlockType;
  public Quaternion Rotation;
  public BlockOccupancyType OccupancyType;

  public BlockOccupancy(Vector3i offset);

  public BlockOccupancy(Vector3i offset, Type blockType);

  public BlockOccupancy(
    Vector3i offset,
    Type blockType,
    Quaternion rotation,
    BlockOccupancyType occupancyType = BlockOccupancyType.None);

  public static implicit operator Ray(BlockOccupancy occ);
}
