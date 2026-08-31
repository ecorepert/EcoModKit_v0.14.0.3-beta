// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.FriendlyScarecrowItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Friendly Scarecrow")]
[LocDescription("Keeps animals away, but not in a scary way. (WIP)")]
[Ecopedia("Housing Objects", "Outdoor", true, true, null)]
[Tag("Housing")]
[Eco.Gameplay.Items.Weight(2000)]
[SalvageCost(new object[] {typeof (BioResidue), 1f})]
public class FriendlyScarecrowItem : WorldObjectItem<FriendlyScarecrowObject>
{
  public static readonly HomeFurnishingValue homeValue;

  protected override OccupancyContext GetOccupancyContext { get; }

  public override HomeFurnishingValue HomeValue { get; }
}
