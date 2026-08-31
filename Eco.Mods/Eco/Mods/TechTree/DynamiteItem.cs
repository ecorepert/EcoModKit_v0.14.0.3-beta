// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.DynamiteItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Dynamite")]
[LocDescription("A distinctly different approach to mining, light the fuse and stand back!\n\n(Explosives convert blocks into their crushed variants.)")]
[Ecopedia("Crafted Objects", "Specialty", true, true, null)]
[Eco.Gameplay.Items.Weight(100)]
[SalvageCost(new object[] {typeof (BioResidue), 0.2f, typeof (ChemicalWaste), 0.4f})]
public class DynamiteItem : WorldObjectItem<DynamiteObject>
{
}
