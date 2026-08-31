// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ClaimStakes.HomesteadClaimStakeItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements.ClaimStakes.Internal;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Numerics;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Settlements.ClaimStakes;

/// <summary>A claim stake allows claiming plots contiguous with the stake.  A homestead claim stake allows choosing which town settlement parents you.</summary>
[Serialized]
[RelatedFeature("UseSettlementSystem", true)]
[LocDisplayName("Homestead Claim Stake")]
[LocDescription("Starts a homestead for a given citizen. Each citizen can have a single homestead, allowing them to claim property in an area.")]
public class HomesteadClaimStakeItem : ClaimStakeItemBase
{
  public override 
  #nullable disable
  Type WorldObjectType { get; }

  [Serialized]
  [Notify]
  public User User { get; set; }

  public override Item Clone();

  public override int StackingHash { get; }

  public override bool CanStack(Item other);

  public override void OnSelected(Player player);

  public override Task<bool> CanPlaceObject(Player player, Vector3 worldPos, Eco.Shared.Math.Quaternion rotation);

  public override bool CanClaim(Player player, Vector3i worldPos);

  public override Task PlacingObject(
    GameActionPack pack,
    Player player,
    ItemStack containingStack,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rotation);

  public static GameActionPack DoClaimForHomestead(
    GameActionPack pack,
    User user,
    Vector3i worldPos);

  protected override LocString DeedName(User user);

  public override void OnPickup(WorldObject placedObject);
}
