// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LeatherHideItem
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

/// <summary>
/// <para>Server side item definition for the "LeatherHide" item.</para>
/// <para>More information about Item objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.Item.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[Serialized]
[LocDisplayName("Leather Hide")]
[Eco.Gameplay.Items.Weight(250)]
[Tag("Currency")]
[Currency(10000)]
[Ecopedia("Items", "Products", true, true, null)]
[SalvageCost(new object[] {typeof (BioResidue), 0.1f})]
[Tag("Animal Skin")]
[LocDescription("A thick hide.")]
public class LeatherHideItem : Item
{
}
