// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.GarbageInventoryBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.World.Blocks;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Objects;

[Tag("Pickupable")]
public abstract class GarbageInventoryBlock : Block, IPickupable, IDestroyAwareBlock
{
  public float InteractDistance { get; }

  protected GarbageInventoryBlock();

  protected GarbageInventoryBlock(DecayingInventory inventory);

  [Serialized]
  public Vector3i Position { get; protected set; }

  [SyncToView(null, true)]
  public Inventory Inventory { get; }

  public IEnumerable<Inventory> Inventories { get; }

  public Task<bool> Pickup(
    Player player,
    InteractionTarget target,
    Inventory targetInv,
    INetObject toolUsed);

  public void Destroyed(Vector3i worldPosition, Block replacement);
}
