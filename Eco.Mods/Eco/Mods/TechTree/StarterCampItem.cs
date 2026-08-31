// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.StarterCampItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Numerics;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Starter Camp")]
[LocDescription("A combination of a small tent and a tiny stockpile.")]
[Tag("PlaceableOnUnownedLand")]
[MustBeGridAligned]
public class StarterCampItem : WorldObjectItem<
#nullable disable
StarterCampObject>
{
  protected override OccupancyContext GetOccupancyContext { get; }

  public override Task PlacingObject(
    GameActionPack pack,
    Player player,
    ItemStack containingStack,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rotation);

  public override bool ShouldCreate { get; }

  public override Task<bool> CanPlaceObject(Player player, Vector3 worldPos, Eco.Shared.Math.Quaternion rotation);

  public override void OnSelected(Player player);

  public override void OnDeselected(Player player);
}
