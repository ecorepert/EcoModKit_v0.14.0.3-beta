// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.StorageComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components.Storage;

[Serialized]
[Tag("Storage Container")]
[Priority(0)]
public abstract class StorageComponent : 
  WorldObjectComponent,
  IInventoryWorldObjectComponent,
  IPermanentDestroyHandler,
  ICanOverrideAuth,
  IHasEnvVars
{
  [SyncToView(null, true)]
  public abstract 
  #nullable disable
  Inventory Inventory { get; }

  [SyncToView(null, true)]
  public override string IconName { get; }

  [SyncToView(null, true)]
  public bool HiddenFromUI { get; set; }

  public IEnumerable<Inventory> Inventories { get; }

  public override void Initialize();

  public override void PostInitialize();

  public override void Destroy();

  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet playerInvChanges,
    Inventory targetInventory,
    bool force);

  public Item FindItemCantContain(IEnumerable<ItemStack> stacks);

  public LazyResult ShouldOverrideAuth(IAlias alias, IOwned property, GameAction action);

  /// <summary>Consolidate this storage inventory (includes A-Z sorting by name). </summary>
  [RPC]
  public void ConsolidateInventory(User user);
}
