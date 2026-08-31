// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.VoronoiModule
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using SharpNoise.Modules;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary>
/// Creates a voronoi map using the <see cref="T:Eco.WorldGenerator.VoronoiWorldGeneratorConfig" /> settings.
/// <para>Google "voronoi" for a great visual example of what the result looks like.</para>
/// </summary>
internal class VoronoiModule : Module
{
  public VoronoiWorldGeneratorConfig Config { get; set; }

  public int OutputIndex { get; set; }

  public VoronoiModule(VoronoiWorldGeneratorConfig config, int outputIndex);

  /// <summary>
  /// Returns the cell result of the voronoi map at the x, y, z (position).
  /// <para>Uses <see cref="P:Eco.WorldGenerator.VoronoiModule.OutputIndex" /> to pick which map to sample from. (3D Space)</para>
  /// </summary>
  public override double GetValue(double x, double y, double z);
}
