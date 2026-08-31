// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.NylonTrawlerNetItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side item definition for the "NylonTrawlerNet" item.</para>
/// <para>More information about VehicleToolItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.VehicleToolItem.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[Serialized]
[LocDisplayName("Nylon Trawler Net")]
[Eco.Gameplay.Items.Weight(5000)]
[RepairRequiresSkill(typeof (HuntingSkill), 0)]
[System.ComponentModel.Category("Tool")]
[Ecopedia("Items", "Tools", true, true, null)]
[SalvageCost(new object[] {typeof (Textiles), 1f, typeof (ChemicalWaste), 0.2f})]
[Tag("Tool")]
[LocDescription("A sturdy basic combination of lines making a mesh used for catching fish on a larger scale.")]
public class NylonTrawlerNetItem : VehicleToolItem
{
  public override float OriginalMaxDurability { get; }

  public override 
  #nullable disable
  IDynamicValue SkilledRepairCost { get; }

  public override int FullRepairAmount { get; }

  public override IEnumerable<RepairingItem> RepairItems { get; }
}
