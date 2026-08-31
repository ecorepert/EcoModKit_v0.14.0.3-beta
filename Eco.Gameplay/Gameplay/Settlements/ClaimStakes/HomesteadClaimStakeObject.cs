// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ClaimStakes.HomesteadClaimStakeObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Settlements.ClaimStakes.Internal;
using Eco.Gameplay.Settlements.Components;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Settlements.ClaimStakes;

/// <summary>homestead claim stake objects can have a selectable parent town.</summary>
[RequireComponent(typeof (HomesteadFoundationComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[Serialized]
public class HomesteadClaimStakeObject : ClaimStakeObjectBase
{
  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }

  protected override void Initialize();
}
