// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.TerrainModule
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.WorldGenerator;

[TypeConverter(typeof (ExpandableObjectConverter))]
public sealed class TerrainModule : ITerrainModule
{
  public 
  #nullable disable
  string Name { get; set; }

  public List<ITerrainModule> Modules { get; set; }

  /// <inheritdoc cref="M:Eco.WorldGenerator.ITerrainModule.CollectSpawners(System.Collections.Generic.Queue{Eco.WorldGenerator.IBlocksSpawner},System.Collections.Generic.IDictionary{Eco.Shared.Math.Vector3i,System.Type})" />
  /// .
  void ITerrainModule.CollectSpawners(
    Queue<IBlocksSpawner> spawners,
    IDictionary<Vector3i, Type> spawnedPoints);

  /// <inheritdoc cref="M:Eco.WorldGenerator.ITerrainModule.CollectSpawners(System.Collections.Generic.Queue{Eco.WorldGenerator.IBlocksSpawner},System.Collections.Generic.IDictionary{Eco.Shared.Math.Vector3i,System.Type})" />
  /// .
  public bool TrySpawnBlock(
    in TerrainGeneratorPosition pos,
    double height,
    int depth,
    Random random,
    Type parentBlockType,
    out Type blockType);

  public void Initialize(Random randomizer);

  public void Clear();

  public override string ToString();

  bool ITerrainModule.TrySpawnBlock(
    in TerrainGeneratorPosition pos,
    double height,
    int depth,
    Random random,
    Type parentBlockType,
    out Type blockType);
}
