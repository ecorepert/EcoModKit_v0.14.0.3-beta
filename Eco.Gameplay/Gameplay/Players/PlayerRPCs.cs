// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.PlayerRPCs
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Shared.Gameplay;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Players;

public static class PlayerRPCs
{
  public static void SetPropertyClaimingMode(
    this Player player,
    PropertyClaimStyle claimStyle,
    WorldRange? occupancy = null,
    SettlementType? settlementType = null,
    Settlement settlement = null,
    Deed deed = null,
    string overrideTitle = null,
    string overrideSubtitle = null);

  public static void StopPropertyClaimingMode(this Player player);

  /// <summary>Opens client-side placement of another copy of an object already in the world, limited to a radius around it.
  /// The player positions the ghost themselves and the client confirms it back through the object's own RPC.</summary>
  public static void StartPlacingAnother(
    this Player player,
    WorldObject copyOf,
    float maxDistance,
    LocString helpText);

  public static Task<EditableOverlay> EditMap(this Player player, MapEditRequest mapEditRequest);

  /// <summary> Send Only to the Player's own client.</summary>
  public static void ClientRPC(this Player player, string method, params object[] args);

  /// <summary> Send Only to the Player's own client.</summary>
  public static void ClientRPC(
    this Player player,
    string method,
    Action callback,
    params object[] args);
}
