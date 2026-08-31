// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.InteractableStorage
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.SharedTypes;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components.Storage;

/// <summary>Defines interactions that storages which should have put/take available can use.</summary>
public abstract class InteractableStorage : StorageComponent
{
  public override void Initialize();

  [Interaction(InteractionTrigger.LeftClick, "Take %CanTake%", InteractionModifier.None, new string[] {"CanTake"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  [Interaction(InteractionTrigger.LeftClick, "Take All", InteractionModifier.Shift, new string[] {"CanTake", "CanTakeAll"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void TakeItem(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  /// <summary>2 interactions to separate put with a tool in hand and without, so tool has an animation and hand doesnt. the one with more restrictions (in this case extra requiredEnvVar:HoldingTool, should always be first.</summary>
  [Interaction(InteractionTrigger.RightClick, "Put %SelectedNonTool%", InteractionModifier.None, new string[] {"SelectedNonTool", "CanPut", "HoldingTool"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  [Interaction(InteractionTrigger.RightClick, "Put %SelectedNonTool%", InteractionModifier.None, new string[] {"SelectedNonTool", "CanPut"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void PutItem(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.Stacking, "Quick stash", InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void PutAllSame(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [EnvVar]
  [Notify]
  public bool HoldingTool(User user);

  [EnvVar]
  [Notify]
  [DependsOnMember("Inventory")]
  public Item CanTake(User user);

  [Notify]
  [EnvVar]
  public bool CanTakeAll { get; }

  [EnvVar]
  [Notify]
  [DependsOnMember("Inventory")]
  public bool CanPut(User user);

  public void Take(User user, InteractionTarget target, bool takeAll = false);

  /// <summary>Get items available to user in this inventory</summary>
  /// <param name="restrictionsPassed">possible restrictions of other inventories</param>
  public List<Item> GetItemsUserCanTake(
    WorldObject worldObject,
    User user,
    Item carriedItem,
    Item selectedItem,
    bool tryTakeAll = false,
    Func<ItemStack, Item, bool> restrictionsPassed = null);
}
