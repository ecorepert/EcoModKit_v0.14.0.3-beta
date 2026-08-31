// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.AdvancedCombustionEngineItem
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
/// <para>Server side item definition for the "AdvancedCombustionEngine" item.</para>
/// <para>More information about PartItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.PartItem.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[Serialized]
[LocDisplayName("Advanced Combustion Engine")]
[Eco.Gameplay.Items.Weight(1000)]
[RepairRequiresSkill(typeof (IndustrySkill), 0)]
[Ecopedia("Items", "Products", true, true, null)]
[SalvageCost(new object[] {typeof (IronScrap), 4f, typeof (CopperScrap), 1f, typeof (ElectronicScrap), 0.8f})]
[LocDescription("A more advanced version of the normal combustion engine that produces a greater output.")]
public class AdvancedCombustionEngineItem : PartItem
{
  public override 
  #nullable disable
  IDynamicValue SkilledRepairCost { get; }

  public override int FullRepairAmount { get; }

  public float ReduceMaxDurabilityByPercent { get; }

  public override IEnumerable<RepairingItem> RepairItems { get; }
}
