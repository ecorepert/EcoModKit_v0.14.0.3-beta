// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.DepositTerrainModule
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary>
/// DepositTerrainModule allows to create deposit using random spawn point with configurable spawn percent chance, depth range and blocks count range.
/// You can specify own weight for every direction (X, Y, Z) and variance for every direction (to add a bit of noise in generation).
/// It also may be setup to generate at least one deposit.
/// May be used instead of <see cref="T:Eco.WorldGenerator.StandardTerrainModule" /> to spawn less random deposits. Deposit spawns all blocks around a spawn point using set of direction weights.
/// It also ensures that all blocks in the deposit are connected.
/// </summary>
[TypeConverter(typeof (ExpandableObjectConverter))]
public class DepositTerrainModule : ITerrainModule
{
  /// <summary> If set to true then ensures at least one deposit will be spawn (if possible). </summary>
  public bool SpawnAtLeastOne { get; set; }

  /// <summary> Defines chance to start spawn from the position. For 0.01 chance it will be in average one deposit per 100 blocks. </summary>
  public float SpawnPercentChance { get; set; }

  [LocDescription("Defines depth range to start spawn in. It may go out of depth range while growing deposit though. You can use DepositDepthRange to control deposit bounds.")]
  public Eco.Shared.Math.Range DepthRange { get; set; }

  [LocDescription("Defines depth range to keep deposit within. It is still possible to go out of deposit depth range bounds, but it will have big penalty.")]
  public Eco.Shared.Math.Range DepositDepthRange { get; set; }

  /// <summary> Defines range for blocks count in deposit. </summary>
  public Eco.Shared.Math.Range BlocksCountRange { get; set; }

  /// <summary> Defines block type for deposit. </summary>
  public BlockType BlockType { get; set; }

  /// <summary> Weights for different directions. For higher weight it will prefer to move in this direction. </summary>
  public List<Vector3> DirectionWeights { get; set; }

  [LocDescription("May be used to specify weight variance. Every time when new block generated it's direction weight will be increased by random value from range [0; direction variance).")]
  public Vector3 WeightVariance { get; set; }

  public override string ToString();

  /// <inheritdoc cref="M:Eco.WorldGenerator.ITerrainModule.CollectSpawners(System.Collections.Generic.Queue{Eco.WorldGenerator.IBlocksSpawner},System.Collections.Generic.IDictionary{Eco.Shared.Math.Vector3i,System.Type})" />
  /// .
  void ITerrainModule.CollectSpawners(
    Queue<IBlocksSpawner> spawners,
    IDictionary<Vector3i, Type> spawnedPoints);

  /// <inheritdoc cref="M:Eco.WorldGenerator.ITerrainModule.CollectSpawners(System.Collections.Generic.Queue{Eco.WorldGenerator.IBlocksSpawner},System.Collections.Generic.IDictionary{Eco.Shared.Math.Vector3i,System.Type})" />
  /// .
  public void CollectSpawners(
    Queue<IBlocksSpawner> spawners,
    IDictionary<Vector3i, Type> spawnedPoints,
    Vector3i worldSize);

  public void Initialize(Random random);

  public void Clear();

  /// <summary> It won't actually spawn any block, but instead will remember spawn position and will use it in spawner later. </summary>
  public bool TrySpawnBlock(
    in TerrainGeneratorPosition pos,
    double height,
    int depth,
    Random random,
    Type parentBlockType,
    out Type blockType);

  bool ITerrainModule.TrySpawnBlock(
    in TerrainGeneratorPosition pos,
    double height,
    int depth,
    Random random,
    Type parentBlockType,
    out Type blockType);

  /// <summary>
  /// Implements <see cref="T:Eco.WorldGenerator.IBlocksSpawner" /> for Deposit Spawning.
  /// Deposit differs from random spawn because it spawns all blocks around spawn point using set of direction weights.
  /// It also ensures that all blocks in the deposit are connected.
  /// </summary>
  public class DepositSpawner : IBlocksSpawner
  {
    /// <inheritdoc cref="P:Eco.WorldGenerator.IBlocksSpawner.NumberToSpawn" />
    public int NumberToSpawn { get; }

    public Eco.Shared.Math.Range HeightRange { get; set; }

    public DepositSpawner(
      Vector3i worldSize,
      int numberToSpawn,
      Type blockType,
      Eco.Shared.Math.Range heightRange,
      Random random,
      Vector3 weights,
      Vector3 weightVariance);

    /// <summary>
    /// Tries to spawn block at specified point. It will add all out coming directions to candidates queue.
    /// For every direction it also will calculate priority - directions with lower priority value will be preferred.
    /// Priority calculated based on direction weights. Higher weight will result in lower priority value.
    /// Variance may randomly increase priority (by reducing priority value).
    /// For every direction it will use following formula:
    /// <code>
    /// directionPriority = currentBlockPriority + inverseDirectionWeight - random(0, inverseDirectionVariance)
    /// </code>
    /// For Y-direction it will check for world bounds and also will reduce priority if they're going out of height range.
    /// </summary>
    public bool TrySpawn(Vector3i point, IDictionary<Vector3i, Type> spawnedPoints, float priority = 0.0f);

    /// <summary> Tries to spawn next candidate using <see cref="M:Eco.WorldGenerator.DepositTerrainModule.DepositSpawner.TrySpawn(Eco.Shared.Math.Vector3i,System.Collections.Generic.IDictionary{Eco.Shared.Math.Vector3i,System.Type},System.Single)" /> method. </summary>
    public bool TrySpawnNext(IDictionary<Vector3i, Type> spawnedPoints);
  }

  private struct PositionWithDepth
  {
    public Vector3i Position;
    public int Depth;
  }
}
