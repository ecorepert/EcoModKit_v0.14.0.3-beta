// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.InfluenceObjects.InfluenceMap
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Gameplay;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.UI;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using PropertyChanged;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.InfluenceObjects;

public class InfluenceMap : 
  IController,
  IViewController,
  IHasUniversalID,
  IPlotOverlayWithMapLegend,
  IMapEntryOverlay,
  IMinimapOption,
  IMinimapCategorizedOption
{
  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  public ControllerList<IInfluencer> Influencers { get; }

  [SyncToView(null, true)]
  public Array2D<int>? Map { get; }

  [SyncToView(null, true)]
  public InfluenceMap? ParentMap { get; }

  [SyncToView(null, true)]
  public InfluenceMap? ChildMap { get; }

  [SyncToView(null, true)]
  public float Priority { get; }

  [SyncToView(null, true)]
  public bool IsOnByDefault { get; }

  [SyncToView(null, true)]
  public string Name { get; }

  public InfluenceMap(string displayName, float priority);

  public void SetFamily(InfluenceMap child, InfluenceMap parent);

  public int GetInfluenceWorldPos(Vector2i worldPos);

  public int GetInfluencePlotPos(PlotPos plotPos);

  [SyncToView(null, true)]
  public string LegendEntriesViewKey { get; }

  [SyncToView(null, true)]
  [DependsOnController("Influencers", true)]
  public Dictionary<int, MapEntry> MapEntries { get; set; }

  [SyncToView(null, true)]
  [DependsOnController("MarkedUpName", true)]
  public string OverlayName { get; }

  [SyncToView(null, true)]
  public string FolderStructure { get; }

  /// <summary>Assign every value in the map with the results of the passed function, then trigger updates.
  /// Returns a list of positions that yielded a change.</summary>
  public List<PlotPos> UpdateAndGetChangedPlots(
    Func<PlotPos, int> plotPosToInfluencer,
    IEnumerable<IInfluencer> influencers);

  /// <summary> Updates the map entry color and notifies view changes for it.</summary>
  public void UpdateMapEntryColor(IInfluencer influencer);

  /// <summary>Describes the plot counts for this influence map of each influencer.</summary>
  public LocString DescribeMap();

  [DoNotNotify]
  public ref int ControllerID { get; }
}
