// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Components.BiomeComponent
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Simulation.WorldLayers.Components;

/// <summary>
/// Used by <see cref="T:Eco.Simulation.WorldLayers.Pushers.BiomePusher" /> to set terrain blocks.
/// </summary>
[Localized(true, false, "", false)]
public class BiomeComponent : WorldLayerComponent
{
  [LocDescription("The top block of the biome.")]
  public Type TopBlock { get; set; }

  public override void Init();

  public override void PostLoad();

  public override void Tick();
}
