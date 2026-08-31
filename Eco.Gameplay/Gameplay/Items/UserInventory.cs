// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.UserInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public class UserInventory : Inventory, IInventoryContext
{
  public const int DefaultCarriedSlots = 1;
  public static ThreadSafeAction<User, BuilderInventory> CarriedStackChangedEvent;
  public string WelcomeMessageInventoryChanges;

  [Serialized]
  [SyncToView(null, true)]
  public BuilderInventory Carried { get; }

  [Serialized]
  [SyncToView(null, true)]
  public TrashInventory Trash { get; }

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public ToolbarBackpackInventory ToolbarBackpack { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ClothingInventory Clothing { get; }

  [SyncToView(null, true)]
  public DynamicInventory Actionbar { get; }

  public ToolbarInventory Toolbar { get; }

  public LimitedInventory Backpack { get; }

  public override IEnumerable<ItemStack> ManipulatableStacks { get; }

  protected override IEnumerable<Inventory> SubInventories { get; }

  public User User { get; set; }

  public ToolbarInventory InventoryContext { get; set; }

  public BuilderInventory BuilderInventoryContext { get; set; }

  public override bool IsLeafInventory { get; }

  public UserInventory(bool newInventory = true);

  protected override void Initialize();

  public void SetUser(User user);

  public void InitializeActionBar();

  public void Validate();

  public void SetWeightLimit(int weightLimit);

  public bool SetCarriedSlots(int slotCount);

  /// <summary>Force-sets carried slot count, evicting items from doomed stacks to void storage.</summary>
  public void ForceSetCarriedSlots(int slotCount);

  public Item CarriedItem { get; }
}
