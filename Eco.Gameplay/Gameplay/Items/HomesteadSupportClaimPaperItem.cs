// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.HomesteadSupportClaimPaperItem
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
[LocDisplayName("Homestead Support Claim Paper")]
[Eco.Gameplay.Items.Weight(100)]
[Tag("Currency")]
[Currency(10000)]
[Ecopedia("Items", "Tools", true, true, null)]
[LocDescription("Papers that can support homesteads outside of a settlement. Trade with lone homesteaders for their goods and services.")]
[Eco.Gameplay.Items.MaxStackSize(500)]
public class HomesteadSupportClaimPaperItem : ClaimPaperItemBase
{
  protected override void Deduct(int quantity);

  public override Result CanBeAddedToStake(WorldObject claimStake, Deed parentDeed);

  public override Result CanBeCountedForStakePlots(WorldObject claimStake, Deed parentDeed);
}
