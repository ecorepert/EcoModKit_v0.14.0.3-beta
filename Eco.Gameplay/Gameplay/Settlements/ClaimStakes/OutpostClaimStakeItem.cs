// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ClaimStakes.OutpostClaimStakeItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements.ClaimStakes.Internal;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Settlements.ClaimStakes;

/// <summary>A claim stake allows claiming plots contiguous with the stake.  This version is for non-settlement usages.</summary>
[Serialized]
[LocDescription("Place this to start a new claim outside of any settlement.")]
public class OutpostClaimStakeItem : ClaimStakeItemBase
{
  public override Type WorldObjectType { get; }

  public override void OnSelected(Player player);

  protected override LocString DeedName(User user);
}
