// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Constitution
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
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Controllers;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics;

[Serialized]
[Ecopedia(null, "Constitution", false, true, null)]
[LocDescription("Defines how civic actions are performed, and how officials are elected or appointed.")]
public class Constitution : 
  SimpleProposable,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  IDescribable,
  IHasSubRegistrarEntries,
  INamed,
  ICachesValidity,
  IHasID,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  INotifyPropertyChanged
{
  public static readonly 
  #nullable disable
  ThreadSafeAction<Constitution> ArticleDescriptionChanged;
  [Serialized]
  public Vector3i Pos;
  [Serialized]
  public bool RequiresHostBacking;

  [Eco.Shared.Networking.Eco(true)]
  [AllowEmpty]
  [ForceScanSubProp]
  [InheritParentScanProps]
  public ControllerList<CivicArticle> Articles { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<CivicArticle> AmendedArticles { get; set; }

  [SyncToView(null, true)]
  public List<CivicArticle> AllArticles { get; internal set; }

  [SyncToView(null, true)]
  public bool Founded { get; }

  public override bool RequiresHost { get; }

  public float RoomValue { get; }

  public float OverthrowValue { get; }

  public override bool DescribedWithTable { get; }

  protected override bool RequiresSlot { get; }

  [EcoTextLimit(EcoTextLimitAttribute.TextRangeStyle.ConstitutionName)]
  public override string Name { get; set; }

  public static Constitution CreateDebugConstitution(Settlement settlement);

  public override void Initialize();

  /// <summary> Update Constitution articles name when Constitution gets renamed </summary>
  public void OnRenamed(string oldName);

  public IEnumerable<IHasID> SubRegistrarEntries { get; }

  public override void OnBeforeStateChangeInternal(
    ProposableState newState,
    CivicsUtils.StateChangeDetailFlags flags);

  public override void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  public override void Destroyed();

  [DependsOnMember("Name")]
  [DependsOnMember("UserDescription")]
  [DependsOnMember("Articles")]
  [DependsOnSubMember("Articles", "Name")]
  [DependsOnSubMember("Articles", "UserDescription")]
  public override LocString Description();

  /// <summary>Fill the constitution with all powers allowed by elections of the given process, by the given proposers.</summary>
  /// <param name="defaultProcess"></param>
  /// <param name="defaultProposers"></param>
  public void InitDefaultConstitution(ElectionProcess defaultProcess = null, IAlias defaultProposers = null);

  [RPC]
  public void AddArticle(Player player);

  public void ClearAllArticles();

  bool ICachesValidity.IgnoreValidity { get; }
}
