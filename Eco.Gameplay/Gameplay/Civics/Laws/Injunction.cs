// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.Injunction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Constitutional;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.Laws;

[RelatedFeature("UseSettlementSystem", true)]
[OnlySettlementsWithChildren]
[Serialized]
[LocDescription("Blocks laws in lesser courts.")]
[Ecopedia(null, "Laws", false, true, null)]
[Tag("CanBeInConstitution")]
public class Injunction : 
  SimpleProposable,
  ICustomValidity,
  IValidity,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Triggers added to this list will be ignored when processing laws in the given list of child settlements.")]
  [AllowEmpty]
  [Derives(typeof (GameAction))]
  [LocDisplayName("Triggers To Block In Lesser Laws")]
  public 
  #nullable disable
  ControllerList<Type> TriggersToIgnoreInLesserLaws { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Legal Actions added to this list will be ignored when processing laws in the given list of child settlements.")]
  [AllowEmpty]
  [Derives(typeof (LegalAction))]
  [LocDisplayName("Legal Actions To Block In Lesser Laws")]
  public ControllerList<Type> LegalActionsToIgnoreInLesserLaws { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Actions added to this list will be ignored when processing laws in the given list of child settlements. Leave blank for 'all children'.")]
  [AllowEmpty]
  [SettlementChildrenAndSelf]
  public ControllerList<Settlement> OnlyAffectSettlements { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Laws that we will specifically ignore on settlements.  Only displays laws in children settlements. Note that blocking specific laws can be bypassed when the settlement creates a new law, so it's usually better to block general legal actions and triggers to prevent that.")]
  [AllowEmpty]
  [SettlementChildrenAndSelf]
  [AnyStateAllowed]
  [LocDisplayName("Laws To Block")]
  public ControllerList<Law> LawsToIgnore { get; set; }

  public override void Initialize();

  Result ICustomValidity.Valid();

  /// <summary>Returns settlements affected, returning all if a whitelist is not specified.</summary>
  public IEnumerable<Settlement> SettlementsAffected { get; }

  public IEnumerable<Type> BlockedTriggersAndLegalActions { get; }

  public override void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  [TooltipAffectedBy(true)]
  public LocString Tooltip();

  public override void Destroyed();
}
