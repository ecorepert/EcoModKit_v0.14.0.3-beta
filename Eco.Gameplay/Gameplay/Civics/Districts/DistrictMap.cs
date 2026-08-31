// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Districts.DistrictMap
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.LegislationSystem;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Gameplay;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.UI;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Civics.Districts;

[Serialized]
[Eco.Shared.Networking.Eco(true)]
[Ecopedia(null, "Districts", false, true, null)]
[LocDescription("A map that defines the areas of the world covered by a specific set of districts.")]
[Tag("CanBeInConstitution")]
public class DistrictMap : 
  SimpleProposable,
  ICustomClientEdit,
  ICopyable,
  IHasSubRegistrarEntries,
  IMinimapOption,
  IMapEntryOverlay,
  IPlotOverlayWithMapLegend,
  IMinimapCategorizedOption
{
  public static 
  #nullable disable
  ThreadSafeAction<District> DistrictDescriptionUpdatedEvent;
  public static ThreadSafeAction<DistrictMap> DistrictsUpdatedEvent;
  public Dictionary<District, int> DistrictPlotCountCache;

  [Serialized]
  [SyncToView(SyncFlags.MustRequest | SyncFlags.ClientCached)]
  [DontClone]
  public Array2D<int> Map { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [DontClone]
  public ControllerDictionary<int, District> Districts { get; set; }

  [SyncToView(null, true)]
  [DependsOnController("Districts", true)]
  public IEnumerable<IHasID> SubRegistrarEntries { get; }

  [SyncToView(null, true)]
  public string FolderStructure { get; }

  [SyncToView(null, true)]
  public float Priority { get; }

  [SyncToView(null, true)]
  public bool IsOnByDefault { get; }

  [SyncToView(null, true)]
  public string LegendEntriesViewKey { get; }

  [SyncToView(null, true)]
  public Dictionary<int, MapEntry> MapEntries { get; set; }

  [DependsOnMember("Districts")]
  [DependsOnMember("CachedTotalArea")]
  [DependsOnMember("CachedTotalPlots")]
  [SyncToView(null, true)]
  public override LocString Description();

  public void DistrictChanged(District district);

  public string DescribeSize(District district);

  public override void Destroyed();

  public override void Initialize();

  public override void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  public void Remove(District district);

  public void ResetMap();

  public object GetArea(District entry);

  public void UpdateDistricts();

  public District GetDistrictAtWorldPos(WorldPosition2i worldPos);

  public District GetDistrictAtPlotPos(PlotPos plotPos);

  public District GetDistrictByID(int id);

  public void Edit(User user, bool readOnly, Action<IController> onSubmit = null, Action<User> onClose = null);

  public Task EditAsync(
    User user,
    bool readOnly,
    Action<IController> onSubmit = null,
    Action<User> onClose = null);

  [RPC]
  public void AddDistrict(Player player);

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public override Dictionary<IHasID, IHasID> GetPairsOfOldAndNewRevisions(IProposable old);

  public CopyResult CopyFrom(object source);
}
