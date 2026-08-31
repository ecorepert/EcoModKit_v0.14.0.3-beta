// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Restricts an inventory from accepting or applying an operation</summary>
public abstract class InventoryRestriction
{
  /// <summary>Localized message shown to the user when the restriction checks do not pass.</summary>
  public abstract LocString Message { get; }

  /// <summary>Custom handler for defining restriction max accepted rules.</summary>
  /// <returns>The max amount of items that can be accepted. Otherwise -1 for default behavior.</returns>
  public virtual int MaxAccepted(Item item);

  public virtual int MaxAccepted(Item item, int quantity);

  /// <summary>Custom handler for defining restriction pickup rules.</summary>
  /// <returns>The max amount that can be picked up. Otherwise -1 for default behavior.</returns>
  public virtual int MaxPickup(RestrictionCheckData checkData, Item item, int totalMoved);

  /// <inheritdoc cref="M:Eco.Gameplay.Items.InventoryRestriction.MaxAccepted(Eco.Gameplay.Items.Item)" />
  public virtual int MaxAccepted(RestrictionCheckData checkData, Item item);

  public virtual int MaxAccepted(RestrictionCheckData checkData, Item item, int quantity);

  /// <summary>How to present this restriction to the player, and how the client may evaluate it. Return null for restrictions that
  /// don't decide item eligibility (room, weight, rights, permanence) so they stay out of the inventory summary entirely.
  /// The default covers mods and one-off rules: the player sees "Custom" with the full message behind it.</summary>
  public virtual RestrictionDescriptor Describe();

  /// <summary>The priority of the restriction. Used to find the most important restriction (<see cref="M:Eco.Gameplay.Items.Inventory.CheckRestrictions(Eco.Gameplay.Items.Inventory.RestrictionCheckType,Eco.Gameplay.Items.Item,System.Int32,System.Func{Eco.Gameplay.Items.InventoryRestriction,System.Int32,System.Int32},Eco.Gameplay.Items.InventoryRestriction@)" />)
  /// from all of the applied restrictions for a given inventory stack.</summary>
  public virtual int Priority { get; }

  /// <summary>See <see cref="T:Eco.Gameplay.Items.RestrictionType" /></summary>
  public virtual RestrictionType Type { get; }
}
