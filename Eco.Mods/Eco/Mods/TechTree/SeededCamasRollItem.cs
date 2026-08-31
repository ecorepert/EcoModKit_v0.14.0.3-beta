// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SeededCamasRollItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>
/// Server side food item definition for the "SeededCamasRoll" item.
/// This object inherits the FoodItem base class to allow for consumption mechanics.
/// </para>
/// <para>More information about FoodItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.FoodItem.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[Serialized]
[LocDisplayName("Seeded Camas Roll")]
[Eco.Gameplay.Items.Weight(300)]
[Ecopedia("Food", "Cooking", true, true, null)]
[SalvageCost(new object[] {typeof (FoodScrap), 2f})]
[LocDescription("Seeds sprinkled on a roll made from rice, fiddleheads and camas paste.")]
public class SeededCamasRollItem : FoodItem
{
  /// <summary>The amount of calories awarded for eating the food item.</summary>
  public override float Calories { get; }

  /// <summary>The nutritional value of the food item.</summary>
  public override Nutrients Nutrition { get; }

  /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
  public override float BaseShelfLife { get; }
}
