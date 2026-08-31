// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ClaimStakes.SettlementClaimStakeObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Settlements.ClaimStakes.Internal;
using Eco.Gameplay.Settlements.Components;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Settlements.ClaimStakes;

/// <summary>Settlement claim stake objects are linked to a single settlement.</summary>
[RequireComponent(typeof (SettlementClaimStakeComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RelatedFeature("UseSettlementSystem", true)]
[RequiresSettlement]
[Serialized]
public abstract class SettlementClaimStakeObject : ClaimStakeObjectBase
{
  [Serialized]
  public Settlement Settlement;

  public abstract SettlementType SettlementType { get; }

  public override LocString DisplayName { get; }

  public void SetSettlement(Settlement settlement);

  protected override void Initialize();
}
