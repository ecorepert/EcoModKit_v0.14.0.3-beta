// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PluginModulesComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Utils;
using Eco.Gameplay.Bonuses;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Modules;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using JetBrains.Annotations;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary> Component which allows to add Plugin Modules to a world object (like better efficiency, longer labor queue etc). </summary>
[Serialized]
[LocDescription("Set and view the upgrade modules for this workbench.")]
[HasIcon(null)]
public class PluginModulesComponent : 
  WorldObjectComponent,
  IInventoryWorldObjectComponent,
  IPermanentDestroyHandler,
  IHasBonuses,
  IHasEnvVars,
  IDynamicRoomTier,
  IPersistentData
{
  public readonly ThreadSafeAction OnChanged;

  /// <summary>Sum of <see cref="P:Eco.Gameplay.Modules.PluginModule.MaterialTierBump" /> across every installed module.</summary>
  public float MaterialTierBump { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  [PropReadOnly]
  public PluginModulesInventory? Inventory { get; }

  /// <summary> Cached information about allowed modules (tags) you can plug. Actual module items stored in inventory. </summary>
  [SyncToView(null, true)]
  public LocString AllowedModulesInfo { get; }

  /// <summary>Star cost per slot in slot order. Sourced from <see cref="M:Eco.Gameplay.Modules.ModuleTags.StarCostFor(System.String)" />.</summary>
  [SyncToView(null, true)]
  public List<int> SlotStarCosts { get; }

  /// <summary>Per-slot representative icon name in slot order (see <see cref="P:Eco.Gameplay.Modules.ModuleSlotDefinition.IconName" />); the client renders it semi-opaque inside empty slots.</summary>
  [SyncToView(null, true)]
  public List<string> SlotIcons { get; }

  /// <summary>Per-module summary with UILink header and indented <see cref="T:Eco.Gameplay.Bonuses.Bonus" /> descriptions. Pushed via <c>this.Changed(nameof(EffectsSummary))</c> from <see cref="F:Eco.Gameplay.Components.PluginModulesComponent.OnChanged" />.</summary>
  [SyncToView(null, true)]
  public LocString EffectsSummary { get; }

  /// <summary>False while a module-raised requirement (room tier, power) is unmet; installed modules apply no bonuses then.
  /// Synced so the client can mark the inactive slots visually.</summary>
  [SyncToView(null, true)]
  public bool ModulesActive { get; }

  /// <summary> Aggregates bonuses from all confirmed plugin modules. Empty while <see cref="P:Eco.Gameplay.Components.PluginModulesComponent.ModulesActive" /> is false. </summary>
  public IEnumerable<Bonus> Bonuses { get; }

  /// <summary>Room-check verdict for the module-raised requirements, pushed by <see cref="T:Eco.Gameplay.Components.RoomRequirementsComponent" /> on every room check.</summary>
  public void SetRoomRequirementsMet(bool met);

  [UsedImplicitly]
  public PluginModulesComponent();

  /// <summary>Returns the module installed in the slot keyed by the given slot tag name (e.g. <c>ModuleTags.Basic</c>), or null.</summary>
  public PluginModule? GetModule(string slotTagName);

  /// <summary>Always returns null -- slot identity comes from the item's slot tag, not the <see cref="T:Eco.Gameplay.Modules.ModuleTypes" /> axis. Retained as a no-op for callers in the legacy <c>Modify(ModuleModifiedValue)</c> pipeline.</summary>
  public PluginModule? GetModule(ModuleTypes types);

  Eco.Gameplay.Items.Inventory IInventoryWorldObjectComponent.Inventory { get; }

  [Interaction(InteractionTrigger.RightClick, "Put %SelectedNonTool% into module slot", InteractionModifier.None, new string[] {"SelectedNonTool", "CanPutModule"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void PutModule(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [EnvVar]
  [Notify]
  [DependsOnMember("Inventory")]
  public bool CanPutModule(User user);

  public override void Initialize();

  /// <summary>Once every component has initialized, raise the host's power to match its installed modules. Runs on load too, re-deriving the result so a saved table comes back at the right power type.</summary>
  public override void PostInitialize();

  /// <summary>Re-derives everything cached off the slot contents after they were written outside the normal install path
  /// (migrations, admin tooling). Those writes assign stacks directly, so <c>slot.OnChanged</c> never fires and the power cache,
  /// the room verdict and the client views keep describing the previous loadout.</summary>
  public void RefreshAfterExternalSlotWrite();

  /// <summary>Watches the grid verdict on the module-raised power: falls back to the base power the moment the grid can't supply
  /// the raised one (so the table keeps working un-upgraded, with module effects paused) and periodically retries the raise so a
  /// recovered grid restores the effects.</summary>
  public override void Tick();

  /// <summary>Modules ride with the <see cref="T:Eco.Gameplay.Items.WorldObjectItem" /> via <see cref="T:Eco.Gameplay.Items.IPersistentData" />; <see cref="T:Eco.Gameplay.Items.PermanentModuleRestriction" /> still blocks drag-removal while placed.</summary>
  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet playerInvChanges,
    Eco.Gameplay.Items.Inventory targetInventory,
    bool force);

  /// <summary>Snapshots slot contents on pickup; <see cref="M:Eco.Gameplay.Components.PluginModulesComponent.RestoreFromPersistentData" /> drains them back in <see cref="M:Eco.Gameplay.Components.PluginModulesComponent.Initialize" />.</summary>
  public object PersistentData { get; set; }
}
