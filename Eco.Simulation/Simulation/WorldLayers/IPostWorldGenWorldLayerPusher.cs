// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.IPostWorldGenWorldLayerPusher
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Simulation.WorldLayers;

/// <summary>
/// Interface for pushers who aware about post world gen (after all interactions initialized, but before Tick).
/// If pusher may modify layer values (like Plant Spawner which checks actually available spawn blocks and also ensures to not spawn plants over capacity) then you may need
/// to have this callback so interaction during Tick phase will use adjusted values (i.e. for consumed capacity calculation).
/// </summary>
public interface IPostWorldGenWorldLayerPusher : IWorldLayerPusher, IWorldLayerRelationship
{
  /// <summary> Method which invoked after all interaction initialized, but before <see cref="M:Eco.Simulation.WorldLayers.NewWorldLayerSync.Tick" /> on PostWorldGen stage. </summary>
  void PostWorldGenPush(
    WorldArea area,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues,
    int length);
}
