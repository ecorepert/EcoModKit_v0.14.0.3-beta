// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.BlockDepthRange
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.World.Blocks;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.WorldGenerator;

[TypeConverter(typeof (ExpandableObjectConverter))]
public class BlockDepthRange
{
  public float NoiseFrequency { get; set; }

  public int Min { get; set; }

  public int Max { get; set; }

  public BlockType BlockType { get; set; }

  public List<ITerrainModule> SubModules { get; set; }

  public override string ToString();
}
