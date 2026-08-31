// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicArticle
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
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.Constitutional;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics;

[Serialized]
[DisplayName("Article")]
[LocDescription("Defines rules about how the government works.")]
[Ecopedia(null, "Civic Articles", false, true, null)]
public class CivicArticle : 
  SimpleProposable,
  ICustomValidity,
  IValidity,
  IParentedEntry,
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID
{
  [Notify]
  public 
  #nullable disable
  ThreadSafeAction ArticleUpdatedEvent { get; }

  [LocDisplayName("Applies To")]
  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [LocDescription("Which kind of civic actions does this rule apply to?")]
  public CivicConditionBase AppliesTo { get; set; }

  [WatchSubMember("MarkedUpName", "ArticleUpdatedEvent", SubPropWatcherFlag.None)]
  [Eco.Shared.Networking.Eco(true)]
  [AllowNullInView]
  [AllowEmpty]
  [LocDescription("Defines which citizens are allowed to propose an election that would perform this action.")]
  public GamePickerListAlias Proposers { get; set; }

  [WatchSubMember("MarkedUpName", "ArticleUpdatedEvent", SubPropWatcherFlag.None)]
  [Eco.Shared.Networking.Eco(true)]
  [AllowNullInView]
  [AllowEmpty]
  [LocDescription("Defines which citizens can perform these kinds of actions immediately, without election.")]
  public GamePickerListAlias Executors { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [AllowNullInView]
  [LocDescription("Defines the kind of election that will be run to determine if the action should be taken.")]
  public ElectionProcess ElectionProcess { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [Advanced]
  [LocDescription("When multiple civic articles can apply to a given action, the one with the highest priority value will be used. (the higher the number, the higher the priority)")]
  public float Priority { get; set; }

  [EcoTextLimit(EcoTextLimitAttribute.TextRangeStyle.CivicArticleName)]
  public override string Name { get; set; }

  public override void Initialize();

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();

  public float CalcPriority();

  public void SetRemovingAmendment(ConstitutionalAmendment removingAmendment);

  public ConstitutionalAmendment RemovedByAmendment { get; }

  [SyncToView(null, true)]
  public string RemovalStatus { get; }

  [SyncToView(null, true)]
  public IHasID Parent { get; set; }

  public override bool RequiresHost { get; }

  [SyncToView(null, true, Flags = SyncFlags.ClientCached)]
  [DependsOnSubMember("Proposers", "OnUserSetChanged")]
  [DependsOnSubMember("Executors", "OnUserSetChanged")]
  [DependsOnSubMember("ElectionProcess", "MarkedUpName")]
  [DependsOnMember("AppliesTo")]
  public override LocString Description();

  public override Result Valid();

  public IEnumerable<CivicActionResult> CanAttempt(User user, CivicAction action);

  [Serialized]
  public int Index { get; set; }

  public string ExecutorsNameString();

  public string ProposersNameString();

  public bool ContainsExecutor(IAlias executor);

  public bool ContainsProposer(IAlias proposer);

  public LocString DescribeWithTitle();
}
