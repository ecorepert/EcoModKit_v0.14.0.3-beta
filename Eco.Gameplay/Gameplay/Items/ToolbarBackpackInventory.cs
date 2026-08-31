// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ToolbarBackpackInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Represents the player's combined toolbar and backpack inventories.</summary>
[Serialized]
public class ToolbarBackpackInventory : Inventory
{
  public const int DefaultWeightLimit = 30000;
  public const int DefaultBackpackSlots = 16 /*0x10*/;
  public static ThreadSafeAction<User, ToolbarBackpackInventory> ToolbarBackpackInventoryChangedEvent;
  public WeightRestriction WeightRestriction;

  [Serialized]
  [SyncToView(null, true)]
  public ToolbarInventory Toolbar { get; }

  [Serialized]
  [SyncToView(null, true)]
  public LimitedInventory Backpack { get; }

  protected override IEnumerable<Inventory> SubInventories { get; }

  public ToolbarBackpackInventory(bool newInventory = true);

  public void SetWeightLimit(int weightLimit);

  public bool SetBackpackSlots(int slotCount);

  /// <summary>Force-sets backpack slot count, evicting items from doomed stacks to toolbar overflow or void storage.</summary>
  public void ForceSetBackpackSlots(int slotCount, User user);

  protected override void Initialize();

  public void SetUser(User user);

  public WeightComponent WeightComponent { get; }
}
