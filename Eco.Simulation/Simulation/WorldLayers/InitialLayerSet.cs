// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.InitialLayerSet
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Simulation.WorldLayers.Layers;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers;

public static class InitialLayerSet
{
  public const float TemperatureRandomness = 0.7f;

  public static void CreateLayerSettings();

  public static IEnumerable<WorldLayer> Layers { get; }

  public static void InitLayers(bool preserveWorld);

  public static bool TryAddLayer(string name, WorldLayerSettings settings);

  public static WorldLayerSettings GetOrCreateLayerSettings(
    string name,
    Func<string, WorldLayerSettings> settingsCreator);

  public static void AddOrReplaceLayer(string name, WorldLayerSettings settings);
}
