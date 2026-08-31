// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ClaimStakes.Internal.ClaimStakeItemBase
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System.Numerics;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Settlements.ClaimStakes.Internal;

/// <summary>Defines common features for attempting to place claim stakes.</summary>
[Serialized]
[Tag("PlaceableOnUnownedLand")]
public abstract class ClaimStakeItemBase : WorldObjectItem
{
  public override void OnDeselected(Player player);

  public override Task<bool> CanPlaceObject(Player player, Vector3 worldPos, Eco.Shared.Math.Quaternion rotation);

  public override Task PlacingObject(
    GameActionPack pack,
    Player player,
    ItemStack containingStack,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rotation);

  public virtual bool CanClaim(Player player, Vector3i worldPos);

  protected bool CanClaim(Player player, Vector3i worldPos, bool checkInfluence);

  protected abstract LocString DeedName(User user);

  protected override OccupancyContext GetOccupancyContext { get; }
}
