// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.BasicUpgradeLvl3Item
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Bonuses;
using Eco.Gameplay.Modules;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
[Serialized]
[LocDisplayName("Basic Upgrade 3")]
[LocDescription("This is a deprecated item that will be removed in a future update.")]
[Eco.Gameplay.Items.Weight(1)]
[Ecopedia("", "", true, true, null)]
[Tag("Upgrade")]
public class BasicUpgradeLvl3Item : EfficiencyModule
{
  public override LocString DisplayNamePlural { get; }

  public override IEnumerable<Bonus> Bonuses { get; }
}
