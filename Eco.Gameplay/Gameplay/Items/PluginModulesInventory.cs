// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.PluginModulesInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Modules;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>A plugin-modules inventory composed of one size-1 sub-inventory per slot the owning table exposes (see <see cref="M:Eco.Gameplay.Modules.ModuleSlotRegistry.SlotsForTable(System.Type)" />).</summary>
/// <remarks>Slots are keyed by slot tag name and restricted by <see cref="T:Eco.Gameplay.Items.ModuleSlotRestriction" /> to items carrying that tag. Restrictions on this parent
/// (e.g. work-order guard) flow to children via <see cref="P:Eco.Gameplay.Items.Inventory.Restrictions" />. The dictionary is not synced: the client renders slots from the flattened
/// parent <see cref="P:Eco.Gameplay.Items.Inventory.Stacks" /> plus the component's SlotStarCosts, so slot count and identity stay fully server-driven.</remarks>
[Serialized]
public class PluginModulesInventory : Inventory
{
  /// <summary>The slot definitions this inventory exposes, in canonical slot order.</summary>
  public IReadOnlyList<ModuleSlotDefinition> SlotDefinitions { get; }

  /// <summary>The exposed slot leaves in canonical slot order. Before <see cref="M:Eco.Gameplay.Items.PluginModulesInventory.AttachToTable(System.Collections.Generic.IReadOnlyList{Eco.Gameplay.Modules.ModuleSlotDefinition},Eco.Gameplay.Items.AuthorizationInventory.AuthorizationFlags,Eco.Shared.Items.AccessType)" /> runs (mid-deserialize) this falls back to
  /// every serialized slot in registry order so base inventory plumbing sees a stable set.</summary>
  public IEnumerable<AuthorizationInventory> Slots { get; }

  protected override IEnumerable<Inventory> SubInventories { get; }

  public override bool NeedsAuth { get; }

  /// <summary>Resolves this inventory against the owning table's slot set: creates missing slot sub-inventories (fresh placement, or a slot
  /// added to an existing save), wires restrictions on every exposed slot, and reports orphaned entries whose slot is no longer registered.</summary>
  public void AttachToTable(
    IReadOnlyList<ModuleSlotDefinition> slots,
    AuthorizationInventory.AuthorizationFlags authFlags,
    AccessType authLevel);

  /// <summary>Returns the sub-inventory keyed by the given slot tag name, or null if this table doesn't expose that slot.</summary>
  public AuthorizationInventory? GetSlot(string slotTagName);

  /// <summary>Picks the first exposed slot whose tag the item carries, or null if no slot accepts it. Used by <c>PutModule</c> to route an item to the correct slot from its tag.</summary>
  public AuthorizationInventory? FindMatchingSlot(Item item);

  /// <summary>Every serialized slot entry, exposed or hidden. Persistence snapshots iterate this so orphaned modules ride along on pickup too.</summary>
  public IEnumerable<KeyValuePair<string, AuthorizationInventory>> AllSlotsByTag { get; }

  /// <summary>System-level slot access for persistence restore: the slot for the tag, created as a hidden entry when this table doesn't expose it, so modules survive slot-set changes.</summary>
  internal AuthorizationInventory GetOrCreateSlotEntry(string slotTagName);
}
