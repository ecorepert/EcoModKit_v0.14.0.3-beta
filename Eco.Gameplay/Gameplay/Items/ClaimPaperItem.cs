// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ClaimPaperItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[Eco.Gameplay.Items.Weight(4)]
[Tag("Currency")]
[Currency(10000)]
[Ecopedia("Items", "Tools", true, true, null)]
[LocDescription("Add to a Claim Stake to increase the number of plots you can claim on it.")]
[Eco.Gameplay.Items.MaxStackSize(500)]
public class ClaimPaperItem : ClaimPaperItemBase
{
  protected override void Deduct(int quantity);

  /// <summary>Check whether these papers can be added to the specified claim stake or not.</summary>
  public override Result CanBeAddedToStake(WorldObject claimStake, Deed parentDeed);

  /// <summary>We check whether these papers can be counted toward the maximum of allowed plots of the specified claim stake or not.</summary>
  public override Result CanBeCountedForStakePlots(WorldObject claimStake, Deed parentDeed);
}
