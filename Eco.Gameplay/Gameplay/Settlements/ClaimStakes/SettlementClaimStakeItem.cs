// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ClaimStakes.SettlementClaimStakeItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements.ClaimStakes.Internal;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Settlements.ClaimStakes;

/// <summary>A settlement claim stake item is different than a homestead one in that it is locked to a given settlement permanently.
/// Also will make the store match them to the required settlement in the config options, so you can buy/sell and maintain the settlement associated.</summary>
[RelatedFeature("UseSettlementSystem", true)]
[RequiresSettlement]
[Serialized]
public abstract class SettlementClaimStakeItem : 
  ClaimStakeItemBase,
  ISettlementAssociated,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public override Type WorldObjectType { get; }

  /// <summary>The settlement that generaed the claim stake</summary>
  [Serialized]
  [SyncToView(null, true)]
  public Settlement Settlement { get; set; }

  public abstract SettlementType SettlementType { get; }

  public override void OnSelected(Player player);

  public override void OnPreWorldObjectPlaced(WorldObject placedObject);

  public override void OnPickup(WorldObject placedObject);

  public override bool IsStackable { get; }

  public override int StackingHash { get; }

  public override bool RepresentsItem(Item other);

  public override bool CanStack(Item other);

  public override int RepresentativeHash();

  public override void Destroy(int quantity = 1);

  public override Item Clone();

  public override bool CanClaim(Player player, Vector3i worldPos);

  protected override LocString DeedName(User user);
}
