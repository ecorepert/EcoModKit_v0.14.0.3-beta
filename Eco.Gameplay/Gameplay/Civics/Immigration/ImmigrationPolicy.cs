// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Immigration.ImmigrationPolicy
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Civics.Immigration;

[RelatedFeature("UseSettlementSystem", true)]
[Serialized]
[LocDescription("A set of rules for how immigrants may become citizens of a settlement.")]
[Ecopedia(null, "Election Processes", false, true, null)]
[Tag("CanBeInConstitution")]
[ExactlyOnePerHost]
public class ImmigrationPolicy : 
  SimpleProposable,
  IProvidesContext,
  IController,
  IViewController,
  IHasUniversalID,
  ICustomValidity,
  IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Citizens can submit settlement citizenship applications if enabled. If disabled, citizenship is only attainable through invitation.")]
  public bool AllowApplicants { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("When new Citizens are permitted, settlement requirements must be met to apply. Enabling 'Allow New People To Instantly Join' allows immediate joining for new Citizens.")]
  [AllowNullInView]
  public 
  #nullable disable
  GameValue<bool> RequirementsForNewCitizens { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Citizens possessing the authority to approve citizenship applications. If vacant, applications are automatically approved.")]
  [AllowNullInView]
  public IAlias Approver { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Citizens failing to meet ongoing requirements are granted time for compliance. Failure to meet requirements post-deadline results in citizenship revocation.")]
  [AllowNullInView]
  public float HoursFailingRequirementsBeforeRemovedAsCitizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("A feature determining whether brand new Citizens can spawn in the settlement. If allowed, they instantly become citizens of the settlement they spawn in.")]
  [AllowNullInView]
  public bool AllowBrandNewPeopleToInstantlyJoin { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("A feature deciding whether Citizens can start new children settlements within the current settlement.")]
  [AllowNullInView]
  public GameValue<bool> RequirementsForNewChildSettlement { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Restrict Citizens, Titles, and Demographics not affiliated with this settlement from owning any property within its influence sphere.")]
  public bool AllowForeignPropertyOwnership { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The designated heir who inherits all properties abandoned by departing citizens.")]
  [VisibilityParam("ShowPropertyHeir")]
  public IAlias PropertyHeirWhenCitizensLeave { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If unchecked, child settlements are prohibited from seceding or joining settlements not classified as children of the current settlement.")]
  [VisibilityParam("ShowAllowChildSettlementsToSecede")]
  public bool AllowChildSettlementsToSecede { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("When set, member settlements have unrestricted authority to annex other members without limitations.")]
  public bool ChildrenSettlementsMayAnnexEachOther { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Enabling this feature allows players to become direct citizens of the settlement.")]
  [VisibilityParam("ShowCanHaveDirectCitizens")]
  public bool CanHaveDirectCitizens { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Enables Citizens to instantly join the settlement upon placing their homesteads inside its influence. If enabled, the 'Can Have Direct Citizens' must also be enabled.")]
  public bool AllowBecomeCitizenUponHomesteadPlacement { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Enabling this feature will set the settlement spawn point to the town foundation instead of the immigration desk.")]
  public bool UseFoundationAsSpawn { get; set; }

  [SyncToView(null, true)]
  [DependsOn("AllowBrandNewPeopleToInstantlyJoin", new string[] {"AllowBecomeCitizenUponHomesteadPlacement", "CanHaveDirectCitizens"})]
  public bool CanJoinSettlemenUponHomesteadPlacement { get; }

  public override void Initialize();

  public override void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  public override bool RequiresHost { get; }

  /// <summary>We check whether the specified user can create a child settlement inside the current one or not (we check both this settlement and all its parents).</summary>
  public Result CheckCanCreateChildSettlement(User user);

  /// <summary>We check whether the specified user can become a citizen of this settlement or not (we check both this settlement and all its parents).</summary>
  public Result CheckCanJoinAsCitizen(User user, bool joinAsDirectCitizen);

  public Task<bool> CanLeaveSettlement(User user);

  /// <summary>We check whether the specified user can take his properties with him when leaving this settlement (If he doesn't own any, this will return a success).</summary>
  public Result CanLeaveWithProperties(User user, out List<Deed> deedsInSettlement);

  public override Result Valid();

  /// <summary>Define the position a new player will spawn at if they join this settlement instantly.</summary>
  public Vector3i SpawnPoint { get; }
}
