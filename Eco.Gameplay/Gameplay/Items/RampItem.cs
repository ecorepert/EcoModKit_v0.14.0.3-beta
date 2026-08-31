// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.RampItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Items;

[Carried]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Tag("PlaceableOnUnownedLand")]
public abstract class RampItem : WorldObjectItem
{
  public override bool ShouldCreate { get; }

  public abstract Dictionary<Vector3i, Type[]> BlockTypes { get; }

  public override Task PlacingObject(
    GameActionPack pack,
    Player player,
    ItemStack containingStack,
    Vector3 position,
    Eco.Shared.Math.Quaternion rotation);

  public override Type[] GetBlockTypesForDirection(Vector3i direction);

  public static void RampPickupOverride(
    Player player,
    Vector3i blockPosition,
    Ramp ramp,
    Block rampBlock,
    Inventory addToInventory,
    GameActionPack pack);

  /// <summary> Destroys a ramp </summary>
  public static void DestroyRampBlocks(Vector3i blockPosition, Ramp ramp, Block rampBlock);
}
