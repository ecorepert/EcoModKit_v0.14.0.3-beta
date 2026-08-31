// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.FoodItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// All food items that are new start with a durability of 100%, when creating the item an ImmutableCountdown is created, what this does is take the time from when the item was created until it becomes spoiled.
///             It should be clarified that every time the item changes state, a new counter is generated with the new parameters, that is, if the item changes storage or the item's durability changes for some reason, the total time is calculated and the remaining time as well. (taking into account the time that has already passed), and another ImmutableCountdown is created.
///             There may be the occasion that there is a storage that preserves the food indefinitely, such as the square pot at the time of writing this comment.
///             In this case, the immutable countdown can generate buggs with infinite time, therefore a paused counter is created, and the decomposition would not occur.
///             If the Shelf life changes (gets in a storage that preserves food), the times change relative to each other, meaning that the total shelf life is increased by a multiplier and also the time remaining for the same multiplier.
///             therefore the quality will not be improved, it will simply take longer to get spoiled.
///             <summary> Food Items are items that spoil over time, See DurabilityItems.md </summary>
[Serialized]
[Eco.Gameplay.Items.Compostable]
[ItemGroup("Food")]
[Tag("Food")]
[Tag("CanBeOnSurface")]
public abstract class FoodItem : 
  SpoilageItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID,
  IPlaceableItem
{
  public override bool CanBeHeld { get; }

  public abstract Nutrients Nutrition { get; }

  [SyncToView(null, true)]
  public abstract float Calories { get; }

  public Type WorldObjectType { get; }

  public override int GetQualityGroup();

  /// <summary>
  /// RPC that is called by client when its time to actually remove food item from inventory an eat it
  /// </summary>
  [RPC]
  public virtual string Consume(Player player);

  /// <summary> On food item right click - we point toolbar override slot with this item stack of food. for client so it knows what item will be used
  /// Also we immediately call consume (so item will be eaten with calories and removed from inventory)</summary>
  public override string OnUsed(Player player, ItemStack itemStack);

  /// <summary> Tiny action to consume food from when it placed on surfaces as object </summary>
  public bool EatFromSurface(Player player, WorldObject table);
}
