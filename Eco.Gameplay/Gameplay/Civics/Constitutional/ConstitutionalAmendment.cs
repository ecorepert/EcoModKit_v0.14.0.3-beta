// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Constitutional.ConstitutionalAmendment
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
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Systems;
using Eco.Gameplay.Systems.Controllers;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Civics.Constitutional;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("Specifies a change to the constituion. Allows adding, removing, and changing of civic articles.")]
[Ecopedia(null, "Constitution", false, true, null)]
[Tag("CanBeInConstitution")]
public class ConstitutionalAmendment : 
  SimpleProposable,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  IDescribable,
  ICustomValidity,
  IValidity,
  ICopyable,
  INotifyRecursiveChanged,
  IHasSubRegistrarEntries
{
  [Eco.Shared.Networking.Eco(true)]
  [TreatAsReference]
  [LocDescription("An optional existing article that is removed with this amendment.")]
  [AllowEmpty]
  [SettlementOnly]
  public ControllerList<CivicArticle> RemoveExistingArticles { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [ShowFullObject]
  [DontClone]
  [ForceScanSubProp]
  [LocDescription("A new article that will be added to the constitution.")]
  [AllowEmpty]
  public ControllerList<CivicArticle> NewArticles { get; set; }

  public override bool DescribedWithTable { get; }

  public override Result Valid();

  public override void Initialize();

  public override void OnBeforeStateChangeInternal(
    ProposableState newState,
    CivicsUtils.StateChangeDetailFlags flags);

  public override void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  public override void Destroyed();

  public IEnumerable<IHasID> SubRegistrarEntries { get; }

  public void OnRecursiveChange(PropertyInfo prop, object objParent);

  [TooltipAffectedBy(true)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public override LocString Description();

  public CopyResult CopyFrom(object source);
}
