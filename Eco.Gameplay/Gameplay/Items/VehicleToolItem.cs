// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.VehicleToolItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Components;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[System.ComponentModel.Category("Hidden")]
[Eco.Gameplay.Items.MaxStackSize(1)]
public abstract class VehicleToolItem : RepairableItem, IWorldObjectComponentSource, IHasInteractions
{
  public override IDynamicValue SkilledRepairCost { get; }

  public virtual IEnumerable<ComponentInstallation> ComponentsToInstall { get; }

  /// <summary>True while this module wants the vehicle's tool control (the Q toggle) active; modules that operate a tool override this.</summary>
  public virtual bool UsesToolControl { get; }

  /// <summary>Optional control-hint label for this module's tool control; left unset, the vehicle's default label is shown.</summary>
  public virtual LocString ToolControlLabel { get; }

  /// <summary>Passenger seats this module adds to its host vehicle while slotted — appended on attach, removed on detach. The vehicle's base seat count stays untouched.</summary>
  public virtual int AddedSeats { get; }

  /// <summary>Whether this module's storage shows on the vehicle toolbar while driving. Modules whose storage is bulk cargo (e.g. flatbeds) override to false to keep the driving HUD clean.</summary>
  public virtual bool ShownOnToolbar { get; }

  [Interaction(InteractionTrigger.RightClick, "Detach", InteractionModifier.None, null, 0.0f, -1f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void Detach(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  public void BlockInteraction(
    IModularVehicleState module,
    WrappedWorldPosition3i pos,
    Quaternion rot,
    VehicleComponent vehicle,
    Inventory inv = null);

  public virtual void ApplyBlockInteraction(
    WrappedWorldPosition3i pos,
    Quaternion rot,
    VehicleComponent vehicle,
    Inventory inv = null);
}
