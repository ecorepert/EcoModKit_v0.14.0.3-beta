// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.BufferPollutionUtils
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Simulation.WorldLayers.Layers;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Simulation.WorldLayers;

public static class BufferPollutionUtils
{
  public static string BufferLayerName(GroundPollutionType type);

  public static string PendingLayerName(GroundPollutionType type);

  public static void AddBufferPollution(Vector2i worldPos, GroundPollutionType type, float amount);

  public static void AddDecontamination(Vector2i worldPos, GroundPollutionType type, float amount);

  public static float ReadBufferValue(Vector2i worldPos, GroundPollutionType type);

  public static float ReadPendingValue(Vector2i worldPos, GroundPollutionType type);

  public static WorldLayer BufferLayer(GroundPollutionType type);

  public static WorldLayer PendingLayer(GroundPollutionType type);

  public static void RefreshGroundPollution();
}
