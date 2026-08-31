// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.RestrictionType
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>This helps in preparing a simple contextual error message for invalid inventory move (when all stacks produced a restriction).
/// See <see cref="M:Eco.Gameplay.Items.Inventory.TryGetBestRestrictionMessage(System.Collections.Generic.IEnumerable{Eco.Gameplay.Items.InventoryRestriction},Eco.Shared.Localization.LocString@)" />.</summary>
public enum RestrictionType
{
  /// <summary>When everything can be added to the inventory and the only limit is space (currently only serves Stockpile).</summary>
  Space,
  /// <summary>When only a specialized set of items can be added to the inventory (Fuel/Silo etc.).</summary>
  Specialized,
}
