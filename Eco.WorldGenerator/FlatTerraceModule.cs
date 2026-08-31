// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.FlatTerraceModule
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using SharpNoise.Modules;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary>
/// Creates a terrace like gradient (also called posterize) rounding to the nearest whole number.
/// <para>Google "terraces" or "posterize gradient" for a great visual example of what the result looks like.</para>
/// </summary>
internal class FlatTerraceModule : Module
{
  public int NumTerraces { get; set; }

  public Module Source { get; set; }

  public override double GetValue(double x, double y, double z);
}
