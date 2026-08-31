// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ClothingSlotBonusRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Prevents removing clothing that grants inventory slots if the resulting shrink would fail (extra slots contain items).
/// Reserves 1 slot when the destination is the affected inventory (the clothing item itself will occupy a slot after the move).
/// Can be temporarily bypassed via <see cref="P:Eco.Gameplay.Items.ClothingSlotBonusRestriction.Bypass" /> when the caller has already validated (e.g. TryEquipItem with CanSwapClothing).</summary>
public class ClothingSlotBonusRestriction : InventoryRestriction
{
  public bool Bypass { get; set; }

  public override LocString Message { get; }

  public override RestrictionDescriptor Describe();

  public override int MaxPickup(RestrictionCheckData checkData, Item item, int totalMoved);
}
