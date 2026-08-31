// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.RepairComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[Priority(-2)]
[RequireComponent(typeof (CreditComponent), null)]
[RequireComponent(typeof (StatusComponent), null)]
[HasIcon(null)]
[Ecopedia(null, null, false, true, null)]
public class RepairComponent : 
  WorldObjectComponent,
  IInventoryWorldObjectComponent,
  IPermanentDestroyHandler
{
  /// <summary>Set this to determine a multiplier based on skills/talents/etc for the max durability reduction during repair.</summary>
  public 
  #nullable disable
  IDynamicValue MaxDurabilityPenaltyMultiplier;

  [Serialized]
  [SyncToView(null, true)]
  public LimitedInventory ToRepair { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public LimitedInventory RepairMaterial { get; set; }

  public Inventory Inventory { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public bool CanRepair(Player player);

  [SyncToView(null, true)]
  public LocString RepairPreview(Player player);

  [SyncToView(null, true)]
  public LocString PenaltyDetails(Player player);

  public override void Initialize();

  public override void Destroy();

  [RPC]
  public void Repair(Player player, BankAccount account);

  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet invChanges,
    Inventory targetInventory,
    bool force);

  /// <summary>Result of a repair preview calculation.</summary>
  private class RepairPreviewResult : IEquatable<RepairComponent.RepairPreviewResult>
  {
    /// <summary>Result of a repair preview calculation.</summary>
    public RepairPreviewResult(
      float NewDurability,
      float NewIntegrity,
      float PenaltyPercent,
      int Cost);

    [CompilerGenerated]
    protected virtual 
    #nullable enable
    Type EqualityContract { get; }

    public float NewDurability { get; init; }

    public float NewIntegrity { get; init; }

    public float PenaltyPercent { get; init; }

    public int Cost { get; init; }

    [CompilerGenerated]
    public override string ToString();

    [CompilerGenerated]
    protected virtual bool PrintMembers(StringBuilder builder);

    [CompilerGenerated]
    public static bool operator !=(
      RepairComponent.RepairPreviewResult? left,
      RepairComponent.RepairPreviewResult? right);

    [CompilerGenerated]
    public static bool operator ==(
      RepairComponent.RepairPreviewResult? left,
      RepairComponent.RepairPreviewResult? right);

    [CompilerGenerated]
    public override int GetHashCode();

    [CompilerGenerated]
    public override bool Equals(object? obj);

    [CompilerGenerated]
    public virtual bool Equals(RepairComponent.RepairPreviewResult? other);

    [CompilerGenerated]
    public virtual RepairComponent.RepairPreviewResult \u003CClone\u003E\u0024();

    [CompilerGenerated]
    protected RepairPreviewResult(RepairComponent.RepairPreviewResult original);

    [CompilerGenerated]
    public void Deconstruct(
      out float NewDurability,
      out float NewIntegrity,
      out float PenaltyPercent,
      out int Cost);
  }
}
