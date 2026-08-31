// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ElectronicsSkill
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
[Serialized]
[LocDisplayName("Electronics")]
[LocDescription("Electronics improves the recipes for many advanced materials needed for advanced technology. Levels up by crafting related recipes.")]
[Ecopedia("Professions", "Engineer", true, true, null)]
[RequiresSkill(typeof (EngineerSkill), 0)]
[Tag("Engineer Specialty")]
[Eco.Gameplay.Items.Tier(4f, true)]
[Tag("Specialty")]
[Tag("Teachable")]
public class ElectronicsSkill : Skill
{
  public static MultiplicativeStrategy MultiplicativeStrategy;
  public static AdditiveStrategy AdditiveStrategy;

  public override void OnLevelUp(User user);

  public override MultiplicativeStrategy MultiStrategy { get; }

  public override AdditiveStrategy AddStrategy { get; }

  public override int MaxLevel { get; }

  public override int Tier { get; }

  public override int SpecialtyCost { get; }
}
