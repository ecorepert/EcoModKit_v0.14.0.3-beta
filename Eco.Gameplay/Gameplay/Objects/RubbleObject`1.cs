// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.RubbleObject`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Objects;

[Serialized]
public abstract class RubbleObject<TItemType> : RubbleObject, IRepresentsItem where TItemType : Item
{
  public Type RepresentedItemType { get; }

  public override Task<bool> Pickup(
    Player player,
    InteractionTarget target,
    Inventory targetInv,
    INetObject toolUsed);
}
