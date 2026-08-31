// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Pathfinding.Internal.PackedPathNodeExtensions
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Simulation.Pathfinding.Internal;

public static class PackedPathNodeExtensions
{
  public static bool IsJump(this PackedPathNode.Movability mov);

  public static PackedPathNode.Movability Opposite(this PackedPathNode.Movability mov);

  /// <summary>Returns true if the block counts as empty for purposes of pathing.</summary>
  public static bool IsOpen(this WorldPosition3i pos);

  public static bool IsPathable(this WorldPosition3i wpos);
}
