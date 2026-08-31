// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.TerrainGenerator
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using System;

#nullable disable
namespace Eco.WorldGenerator;

public class TerrainGenerator
{
  public TerrainGenerator(WorldSettings settings);

  /// <summary> Spawns blocks using <see cref="T:Eco.WorldGenerator.IBlocksSpawner" /> collection. Should be called after <see cref="M:Eco.WorldGenerator.TerrainGenerator.Generate(System.Int32,System.Int32)" />. </summary>
  public void SpawnBlocks(Action<float> progressPercentageCallback);

  public void Generate(int chunkPosX, int chunkPosZ);
}
