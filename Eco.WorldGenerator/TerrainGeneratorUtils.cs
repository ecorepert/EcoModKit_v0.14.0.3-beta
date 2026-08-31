// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.TerrainGeneratorUtils
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.WorldGenerator;

public static class TerrainGeneratorUtils
{
  /// <summary> Creates <see cref="T:System.Random" /> scoped to chunk column (all chunks with same x and z coordinates). </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Random CreateChunkColumnRandom(int seed, int columnX, int columnZ);
}
