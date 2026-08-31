// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.DrillItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Drill")]
[LocDescription("A useful tool for prospecting blocks.")]
[Eco.Gameplay.Items.Weight(0)]
[Ecopedia("Items", "Tools", false, true, null)]
[System.ComponentModel.Category("Hidden")]
public abstract class DrillItem : ToolItem
{
  public const float BlockHardnessModifier = 0.5f;

  public override ItemHandOrigin HandOrigin { get; }

  public override bool CanBeUsedWithEmotes { get; }

  public virtual float ProspectSpeed { get; }

  public virtual int DrillDepth { get; }

  public override IDynamicValue CaloriesBurn { get; }

  public override IDynamicValue Tier { get; }

  public override IDynamicValue SkilledRepairCost { get; }

  public override int FullRepairAmount { get; }

  public override int MaxTake { get; }

  [RPC]
  public ProspectData GetProspectData(Player player, Vector3i rawDirection, Vector3i startingPos);
}
