// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.IBlocksSpawner
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary> Interface which implemented by custom blocks spawners which invoked after main terrain generation finished. </summary>
public interface IBlocksSpawner
{
  /// <summary> Number of blocks left to be created by the spawner. May be used for progress tracking. </summary>
  int NumberToSpawn { get; }

  /// <summary> Tries to spawn next block. If returns <c>false</c> then it won't spawn anymore blocks. </summary>
  bool TrySpawnNext(IDictionary<Vector3i, Type> spawnedPoints);
}
