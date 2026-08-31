// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.Fertile
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

#nullable disable
namespace Eco.World.Blocks;

/// <summary>Can support plant-life.</summary>
public sealed class Fertile : BlockAttribute
{
  /// <summary>
  /// Coefficient of fertility for this block (0.0-1.0). In example for desert biome blocks
  /// it will have lesser fertility per block to prevent to make it best place for plant growth.
  /// </summary>
  public float Fertility;
}
