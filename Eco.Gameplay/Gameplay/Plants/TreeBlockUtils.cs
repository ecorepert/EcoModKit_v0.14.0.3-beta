// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Plants.TreeBlockUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Plants;

/// <summary>Heals tree occupancy blocks whose owning tree no longer exists. Tree blocks are transient (wiped on load), so a tree that dies
/// without clearing its blocks leaves invisible occupied voxels that would otherwise stay unbuildable until the next server restart.</summary>
public static class TreeBlockUtils
{
  /// <inheritdoc cref="M:Eco.Gameplay.Plants.TreeBlockUtils.TryHealOrphanedTreeBlock(Eco.Shared.Math.WrappedWorldPosition3i)" />
  public static bool TryHealOrphanedTreeBlock(Vector3i position);

  /// <summary>If the block at <paramref name="position" /> is a tree block with no living plant anywhere in its column, deletes it and returns true.
  /// Trees register at the base of their block column, so walk down through consecutive tree blocks looking for the owner.</summary>
  public static bool TryHealOrphanedTreeBlock(WrappedWorldPosition3i position);
}
