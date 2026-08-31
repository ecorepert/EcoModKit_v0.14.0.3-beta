// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.IStartupWorldLayerPuller
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Simulation.WorldLayers;

/// <summary> Interface extending <see cref="T:Eco.Simulation.WorldLayers.IWorldLayerPuller" /> with ApplyStartupValue which pulls startup value based on current world state. </summary>
public interface IStartupWorldLayerPuller : IWorldLayerPuller, IWorldLayerRelationship
{
  float GetStartupValue(Vector2i layerPos, WorldArea area);
}
