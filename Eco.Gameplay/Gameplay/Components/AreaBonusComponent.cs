// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.AreaBonusComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Bonuses;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary> Component that emits bonuses to nearby crafting tables — within <see cref="P:Eco.Gameplay.Components.AreaBonusComponent.Radius" />, or throughout a settlement's
/// influence when <see cref="P:Eco.Gameplay.Components.AreaBonusComponent.Scope" /> is <see cref="F:Eco.Gameplay.Components.AreaBonusScope.SettlementInfluence" /> (the settlement layer is selected by
/// the owner on the parent's <see cref="T:Eco.Gameplay.Components.JurisdictionComponent" />, same as courts).
/// The owner may dedicate the building to a <see cref="P:Eco.Gameplay.Components.AreaBonusComponent.Profession" /> (bonuses using <see cref="T:Eco.Gameplay.Bonuses.ProfessionCause" /> follow it), and
/// designers can gate activation behind star investment (<see cref="M:Eco.Gameplay.Components.AreaBonusComponent.RequireStarInvestment(System.Int32)" />) and a configurable minimum of
/// citizens holding the dedicated profession.
/// Discovered by <see cref="M:Eco.Gameplay.Bonuses.BonusContext.Sources" /> — yields this component directly
/// (not the parent WorldObject) so only area-specific bonuses apply, not plugin module bonuses.
/// Implements <see cref="T:Eco.Gameplay.Bonuses.IHasBonuses" /> as a leaf source — bonuses are defined at setup time. </summary>
[Serialized]
[CreateComponentTabLoc("Benefit", true)]
[HasIcon(null)]
public class AreaBonusComponent : 
  WorldObjectComponent,
  IHasBonuses,
  IHasEditableProperties,
  INotifyPropertyChanged,
  IPersistentData
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public override 
  #nullable disable
  string IconName { get; }

  /// <summary> Benefit summary shown at the top of the Benefit tab: bonuses, scope, star progress and activation state. </summary>
  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringTitle")]
  public LocString Title { get; set; }

  /// <summary> Maximum range (in blocks) at which this component's bonuses apply. Only used with <see cref="F:Eco.Gameplay.Components.AreaBonusScope.Radius" />. </summary>
  [Serialized]
  public float Radius { get; }

  /// <summary> How this component's application area is determined. Set at configure time by design data. </summary>
  [Serialized]
  public AreaBonusScope Scope { get; }

  public object PersistentData { get; set; }

  /// <summary> The profession this building is dedicated to. Selected by the owner; bonuses using <see cref="T:Eco.Gameplay.Bonuses.ProfessionCause" /> follow it.
  /// Declared as <see cref="T:Eco.Gameplay.Skills.Skill" /> (not Type) so the client property editor resolves the skill registrar for its selection popup. </summary>
  [Eco.Shared.Networking.Eco(true)]
  [RequiredTag("Profession")]
  [AllowEmpty]
  [LocDescription("The profession this building's bonuses apply to.")]
  public Skill Profession { get; set; }

  /// <summary> Stars players invested into this building so far. Activation requires <see cref="P:Eco.Gameplay.Components.AreaBonusComponent.RequiredStars" />. </summary>
  [SyncToView(null, true)]
  public int InvestedStars { get; }

  /// <summary> Stars required before this building's bonuses activate. Designer-set at configure time; 0 = no star requirement. </summary>
  [SyncToView(null, true)]
  public int RequiredStars { get; }

  /// <summary> Bonuses emitted by this area effect building. Populated during setup. </summary>
  public List<Bonus> BonusList { get; }

  /// <inheritdoc />
  public IEnumerable<Bonus> Bonuses { get; }

  public AreaBonusComponent();

  public AreaBonusComponent(float radius);

  public void Initialize(float radius);

  public void InitializeSettlementScoped();

  public void RequireStarInvestment(int quantity);

  public override void PostInitialize();

  /// <summary> Benefit summary used by the Benefit tab and tooltips: bonuses, scope, dedication, star progress and activation state. </summary>
  public LocString DescribeBenefits();

  /// <summary> True when all activation requirements are met and this component's bonuses apply. </summary>
  public bool IsActive { get; }

  [SyncToView(null, true)]
  public bool StarsRequirementMet { get; }

  [SyncToView(null, true)]
  public bool ShowInvestButton();

  /// <summary> Invest one star into the building to help activate it. </summary>
  [RPC(AccessType.ConsumerAccess)]
  [Autogen]
  [VisibilityParam("ShowInvestButton")]
  [UITypeName("BigButton")]
  [Description("Invest a star to help activate this building's benefits.")]
  public void InvestStar(Player player);

  /// <summary> Discover all <see cref="T:Eco.Gameplay.Components.AreaBonusComponent" />s affecting the context position: radius-scoped components nearby,
  /// plus settlement-scoped components assigned (via <see cref="T:Eco.Gameplay.Components.JurisdictionComponent" />) to any settlement influencing the position.
  /// Inactive components (missing stars or profession citizens) are skipped.
  /// Currently requires <paramref name="contextWorldObject" /> to be non-null. Excludes the context's own WorldObject to avoid double-sourcing. </summary>
  public static IEnumerable<AreaBonusComponent> DiscoverAffecting(
    WorldObject contextWorldObject,
    User contextSource);
}
