// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.PickupableBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.SharedTypes;
using Eco.World.Blocks;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Objects;

[Tag("Pickupable")]
public abstract class PickupableBlock : Block, IPickupable
{
  public virtual float CaloriesToPickUp { get; }

  public Task<bool> Pickup(
    Player player,
    InteractionTarget target,
    Inventory targetInv,
    INetObject toolUsed);
}
