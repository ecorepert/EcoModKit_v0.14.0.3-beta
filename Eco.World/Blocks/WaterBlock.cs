// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.WaterBlock
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Items;
using Eco.Shared.Math;
using Eco.Shared.Pools.Collections;
using Eco.Shared.Serialization;
using Eco.World.Blocks.Features;

#nullable enable
namespace Eco.World.Blocks;

/// <summary>
/// Water block that is that top level of a body of water, usually exposed to air and can flow sideways and down.
/// </summary>
[Tag("Liquid")]
[Serialized]
[UnderWater]
public class WaterBlock : Block, IWaterBlock, ITickableBlock, IExtraBlockData, IDestroyAwareBlock
{
  public const float WaterLoss = 0.1f;
  public const float MaxWater = 1f;

  [Serialized]
  public float Water { get; set; }

  [Serialized]
  public bool PipeSupplied { get; set; }

  public bool Asleep { get; set; }

  public WaterBlock(float water, bool pipeSupplied = false);

  public WaterBlock(float water);

  public WaterBlock();

  /// <inheritdoc cref="M:Eco.World.Blocks.Features.IExtraBlockData.GetExtra(Eco.Shared.Math.Vector3i)" />
  public byte GetExtra(Vector3i worldPosition);

  public void Tick(
    Vector3i worldPosition,
    PersistentChunk chunk,
    PoolableListWrapper<BlockChange> blockChanges);

  public void Destroyed(Vector3i worldPosition, Block replacement);
}
