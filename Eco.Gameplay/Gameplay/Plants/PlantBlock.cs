// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Plants.PlantBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Shared.Math;
using Eco.Shared.Pools.Collections;
using Eco.Shared.Serialization;
using Eco.Simulation.Agents;
using Eco.World;
using Eco.World.Blocks;
using Eco.World.Blocks.Features;

#nullable disable
namespace Eco.Gameplay.Plants;

[Serialized]
[Transient]
[Tag("NonPlant", Unset = true)]
[NonSharedBlock]
public abstract class PlantBlock : Block, ITickableBlock, IExtraBlockData, IDestroyAwareBlock
{
  public bool Asleep { get; set; }

  public static Plant GetPlant(WrappedWorldPosition3i worldPosition);

  public byte GetExtra(Vector3i worldPosition);

  public void Tick(
    Vector3i worldPosition,
    PersistentChunk chunk,
    PoolableListWrapper<BlockChange> blockChanges);

  public void Destroyed(Vector3i worldPosition, Block replacement);
}
