// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ClaimStakes.OutpostClaimStakeObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Settlements.ClaimStakes.Internal;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Settlements.ClaimStakes;

/// <summary> claim stake objects can have a selectable parent town.</summary>
[Serialized]
[LocDescription("Place this to begin claiming property onto a deed. Does not require any settlement")]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
public class OutpostClaimStakeObject : ClaimStakeObjectBase
{
  public override LocString DisplayName { get; }
}
