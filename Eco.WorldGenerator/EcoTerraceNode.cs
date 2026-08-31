// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.EcoTerraceNode
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using SharpNoise.Modules;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary>Similar to the terrace module, except with additional control over the quadratic power (res^pow). Holds the VoronoiModule in WorldGenerator.eco. Also see <see cref="T:Eco.WorldGenerator.FlatTerraceModule" /></summary>
internal class EcoTerraceNode : Module
{
  public Module Source { get; set; }

  /// <summary>Scales the final result exponentially.</summary>
  public float Power { get; set; }

  public int TerracePoints { get; set; }

  /// <summary>
  /// Returns the cell result of the terrace at the x, y, z (position).
  /// <para>Uses the cached control points and a quadratic curve to calculate where the x, y, z cell would be in the 3D terrace.</para>
  /// </summary>
  public override double GetValue(double x, double y, double z);
}
