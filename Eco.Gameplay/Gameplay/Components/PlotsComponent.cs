// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PlotsComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Settlements.Components;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary> Allows claiming connected plots to where the parent is placed. Adding claim papers will charge
/// it up. The deed map lets you make the claims.</summary>
[Serialized]
[LocDisplayName("Plots")]
[CreateComponentTabLoc(null, false)]
[HasIcon(null)]
[LocDescription("Provides a tool for claiming property around this object.  By adding claim papers from Settlements, you can increase the number of plots you can claim.")]
public class PlotsComponent : 
  InteractableStorage,
  INotifyPropertyChanged,
  IPickupConfirmationComponent,
  IClaimStakeComponent
{
  public readonly ThreadSafeAction OnChanged;
  public Func<int>? GetModdedBaseClaims;
  public int AllowedSlots;

  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  [PropReadOnly]
  public AuthorizationInventory? ClaimPapersInventory { get; }

  [Serialized]
  [SyncToView(null, true)]
  public double OverburdenedPlotsValidityTime { get; set; }

  [SyncToView(null, true)]
  public override string IconName { get; }

  [SyncToView(null, true)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public LocString Description { get; }

  public bool DestroyDeedWithObject { get; set; }

  [Serialized]
  public bool ResizeDeedWhenNecessary { get; set; }

  public override Inventory Inventory { get; }

  public override void Initialize();

  public LocString GetComponentPickupConfirmation();

  /// <summary>Counts how many base claims, based on whether this stake is from a homestead or settlement.</summary>
  public int BaseClaims();

  public override void Destroy();

  /// <summary>This will take care of randomly removing plots from this deed until the number of claimed plots become equal to the number allowed plots.</summary>
  public bool TryResolveOverburdened(bool force);

  public void UpdateDescription();

  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet playerInvChanges,
    Inventory targetInventory,
    bool force);

  Settlement? IClaimStakeComponent.OwningSettlement { get; }

  void IClaimStakeComponent.DeedChanged();

  /// <summary>Move items back to the owner, unless theyre abandoned, in which case we return them to the settlement that created them.
  /// Accepts a settlement that it limits to (null for all). Returns a description of where they were sent to.</summary>
  public (LocString MoveDesc, int NumMoved) ReturnPapers(
    Settlement? onlyForSettlement,
    Type? limitToType = null);

  private delegate int MaxClaimPickupDelegate(int totalMoved);

  private class CheckClaimedPlots : InventoryRestriction
  {
    public Deed? ParentDeed { get; init; }

    public PlotsComponent.MaxClaimPickupDelegate? MaxClaimPickup { get; init; }

    public override LocString Message { get; }

    public override int MaxPickup(RestrictionCheckData checkData, Item item, int totalMoved);
  }

  /// <summary>We use this to only allow claim papers that are compatible with the parent deed to be added to the inventory</summary>
  private class CheckPaperIsAllowed : InventoryRestriction
  {
    public Deed? ParentDeed { get; init; }

    public override LocString Message { get; }

    public override int MaxAccepted(Item item);
  }
}
