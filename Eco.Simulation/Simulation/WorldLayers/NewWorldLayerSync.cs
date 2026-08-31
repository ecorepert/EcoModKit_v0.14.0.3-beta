// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.NewWorldLayerSync
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers;

public class NewWorldLayerSync : AutoSingleton<NewWorldLayerSync>
{
  public List<IWorldLayerInteraction> Interactions { get; }

  public IEnumerable<IWorldLayerRelationship> AllRelationships { get; }

  public static void AddPuller(IWorldLayerPuller puller);

  public static void AddInteraction(IWorldLayerInteraction interaction);

  public static void AddPusher(IWorldLayerPusher pusher);

  public static void PostWorldGenInit();

  public static bool ReInitLayer(string layerName);

  public static bool SetLayer(string layerName, float min, float max = float.NaN);

  /// <summary> Callback for the server statup. Pullers run in parallel: each writes only its own output layer.</summary>
  public static void OnServerStart();

  public static void Pull();

  public static void Tick();

  public static void Push();

  private class InteractionInfo
  {
  }
}
