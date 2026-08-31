// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ClaimStakes.Internal.ClaimStakeObjectBase
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Placement;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Settlements.ClaimStakes.Internal;

/// <summary>The object that claims a plot and allows the claiming of more plots (using a deed map) based on the number
/// of claim-papers that are attached.  Plots must be contiguous to the claim stake.</summary>
[Serialized]
[RequireComponent(typeof (PlotsComponent), null)]
[RequireComponent(typeof (PropertyAuthComponent), null)]
public abstract class ClaimStakeObjectBase : 
  WorldObject,
  IClaimStakeObject,
  IMoveableWithinDeedAndInfluence,
  IMoveableWithRestrictions
{
  public override bool AllowResidentAccessIfCreator { get; }

  public bool IgnoreSettlementTypeOnClaimPapers { get; set; }
}
