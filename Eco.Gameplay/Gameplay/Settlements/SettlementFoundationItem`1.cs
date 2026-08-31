// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementFoundationItem`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements.Components;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using System.Numerics;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>Base class for items that claim a settlement. Contains functions for defining how property can be claimed
/// without overlapping with existing settlements or other plots.  Manages the display of that available land on the client.</summary>
[RequireComponent(typeof (SettlementClaimStakeComponent), null)]
[Tag("Settlement")]
[Tag("PlaceableOnUnownedLand")]
public abstract class SettlementFoundationItem<T> : WorldObjectItem<
#nullable disable
T> where T : WorldObject
{
  protected abstract SettlementType SettlementType { get; }

  public override void OnSelected(Player player);

  public override void OnDeselected(Player player);

  public override Task<bool> CanPlaceObject(Player player, Vector3 worldPos, Eco.Shared.Math.Quaternion rotation);

  public override Task PlacingObject(
    GameActionPack pack,
    Player player,
    ItemStack containingStack,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary>
  /// This will check whether this item can be moved by the specified player to the specified position or not.
  /// If moving the settlement foundation to the specified position would lead to some citizen or children changes, a confirmation popup will be shown up to the player.
  /// </summary>
  public override Task<bool> CanMove(
    Player player,
    Vector3i pos,
    Eco.Shared.Math.Quaternion rotation,
    INetObject woNetObject);
}
