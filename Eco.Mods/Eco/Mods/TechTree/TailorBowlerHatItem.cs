// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TailorBowlerHatItem
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
/// <para>
/// Server side item definition for the "TailorBowlerHat" clothing item.
/// </para>
/// <para>More information about ClothingItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.ClothingItem.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[Serialized]
[LocDisplayName("Tailor Bowler Hat")]
[LocDescription("A stylish bowler hat made of tighly spun fur felt.")]
[Eco.Gameplay.Items.Weight(100)]
[SalvageCost(new object[] {typeof (BioResidue), 0.8f, typeof (Textiles), 0.4f})]
[Tag("Clothes")]
[Ecopedia("Items", "Clothing", true, true, null)]
public class TailorBowlerHatItem : ClothingItem
{
  /// <summary>Slot this clothing type belongs to</summary>
  public override string Slot { get; }

  public override bool Starter { get; }
}
