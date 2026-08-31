// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.StrangeCloudGameplay.StrangeItemManagement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Shared.Serialization;
using Eco.Shared.StrangeCloudShared;
using Eco.Shared.View;
using PropertyChanged;
using StrangeCloud.Service.Client.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.StrangeCloudGameplay;

/// <summary>Class that tracks the items a given user has created in this world, when those items are dependent on strange cloud blueprints.</summary>
[Serialized]
public class StrangeItemManagement : IController, IViewController, IHasUniversalID
{
  [Serialized]
  [SyncToView(null, true)]
  public 
  #nullable disable
  ControllerDictionary<Type, int> TypeToCountCollected { get; set; }

  public IEnumerable<StrangeItemInWorld> ItemsForUser { get; }

  public void Initialize(StrangeUser user);

  /// <summary>Provides all the allowed items this player can place, along with how many they have created./</summary>
  public IEnumerable<(StrangeItemInWorld PaidItems, int CountCreated)> GetPaidAndCreated();

  /// <summary>See if we can make more of this item type.</summary>
  public Result CanMake(Recipe recipe, int amountToMake);

  /// <summary>See if we can make more of this item type.</summary>
  public Result CanMake(Item item, int amountToMake);

  /// <summary>Mark an item type as created in the given quantity. Negative amounts are repairs that refund lost uses, so they skip the craft check.</summary>
  public bool ManuallyIncrementCount(Item item, int amount);

  /// <summary>Called when a recipe is made so that it can increment the count if blueprints are required.</summary>
  public void WorkOrderStarted(WorkOrder workOrder);

  /// <summary>Refunds the strange items that were counted for the uncrafted part of this work order. Mirrors the per-product increment in <see cref="M:Eco.Gameplay.StrangeCloudGameplay.StrangeItemManagement.WorkOrderStarted(Eco.Gameplay.Items.WorkOrder)" />.</summary>
  public void WorkOrderCancelled(WorkOrder workOrder);

  public void StrangeUserUpdated(StrangeUser user);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
