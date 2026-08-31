// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.Crater
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Math;
using SharpNoise.Modules;
using System;

#nullable disable
namespace Eco.WorldGenerator;

public class Crater
{
  public Vector2 Center;
  public int Radius;
  public int Depth;
  public float NoiseWeight;
  public Perlin Noise;

  public Crater(Vector2 center, int radius, Random randomizer, WorldSettings settings);

  public float RadialNoise(float angle);
}
