// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.ITerrainModule
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.WorldGenerator;

[TypeConverter(typeof (ExpandableObjectConverter))]
public interface ITerrainModule
{
  /// <summary> Collects additional blocks spawners after initial module generation finished. Block spawners then may generate additional blocks using own custom algorithm (like <see cref="T:Eco.WorldGenerator.DepositTerrainModule.DepositSpawner" />). </summary>
  /// <param name="spawners">Current queue of spawners (new spawners should be added to end of the queue).</param>
  /// <param name="spawnedPoints">Already spawned points (to prevent concurrency between spawners). </param>
  void CollectSpawners(Queue<IBlocksSpawner> spawners, IDictionary<Vector3i, Type> spawnedPoints);

  /// <summary> Tries to spawn block at specific terrain position. In case of success it returns <paramref name="blockType" /> in output parameter. </summary>
  bool TrySpawnBlock(
    in TerrainGeneratorPosition pos,
    double height,
    int depth,
    Random random,
    Type parentBlockType,
    out Type blockType);

  void Initialize(Random randomizer);

  void Clear();
}
