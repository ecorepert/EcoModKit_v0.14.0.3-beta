// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Explosions.ExplosionUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Explosions;

public static class ExplosionUtils
{
  /// <summary>Moves a block from one cell to another. For <see cref="T:Eco.Gameplay.Blocks.FractionalBlock" />s (MixedGarbage and friends), recreates a
  /// transient <see cref="T:Eco.Gameplay.Blocks.FractionalBlockItem" /> carrying the source block's <c>InternalRepartition</c> so the destination block
  /// is constructed via its <c>(FractionalBlockItem)</c> ctor and keeps the composition. Non-fractional blocks fall back to the
  /// plain type-only path.</summary>
  public static void MoveBlockPreservingFractional(
    WrappedWorldPosition3i from,
    WrappedWorldPosition3i to);

  /// <summary> Starts N cycles on block fall logic. Its iterative and result greatly depends on number of iterations. Returns the final positions of the input set after all fall iterations - useful for post-processing (ex: merging garbage stacks).</summary>
  public static IReadOnlyList<Vector3i> EmitBlockFall(
    IEnumerable<Vector3i> positions,
    BlockFallConfig config);

  public static IEnumerable<Vector3i> GetFallNeighbors(Vector3i pos);
}
