// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PineappleItem
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
/// Server side food item definition for the "Pineapple" item.
/// This object inherits the FoodItem base class to allow for consumption mechanics.
/// </para>
/// <para>More information about FoodItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.FoodItem.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[Serialized]
[LocDisplayName("Pineapple")]
[Eco.Gameplay.Items.Weight(125)]
[Eco.Gameplay.Items.Yield(typeof (PineappleItem), typeof (GatheringSkill), new float[] {1f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 2f})]
[Crop]
[Tag("Crop")]
[Tag("Harvestable")]
[Tag("Fruit")]
[Tag("Raw Food")]
[Ecopedia("Food", "Produce", true, true, null)]
[SalvageCost(new object[] {typeof (FoodScrap), 0.1f})]
[LocDescription("Nice fresh Pineapple.")]
public class PineappleItem : FoodItem
{
  /// <summary>The amount of calories awarded for eating the food item.</summary>
  public override float Calories { get; }

  /// <summary>The nutritional value of the food item.</summary>
  public override Nutrients Nutrition { get; }

  /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
  public override float BaseShelfLife { get; }
}
