// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.HeliconiaSeedPackItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>
/// Server side seed pack item definition for the "HeliconiaSeed Pack" item.
/// This object inherits the SeedPackItem base class to allow for planting/consumption mechanics.
/// </para>
/// <para>This item is currently hidden from the player. It is either an internal use item or not ready for public release. Removing the hidden tag is not recommended.</para>
/// <para>More information about SeedPackItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.SeedPackItem.html</para>
/// </summary>
[Serialized]
[LocDisplayName("Heliconia Seed Pack")]
[System.ComponentModel.Category("Hidden")]
[Eco.Gameplay.Items.Weight(50)]
[LocDescription("Plant to grow heliconia.")]
public class HeliconiaSeedPackItem : SeedPackItem
{
  /// <summary>The name of the plant species this seed pack is responsible for</summary>
  public override LocString SpeciesName { get; }
}
