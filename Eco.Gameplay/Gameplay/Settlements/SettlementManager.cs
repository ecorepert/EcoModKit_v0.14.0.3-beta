// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.InfluenceObjects;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>Handles settlement creation and tracking, mapping their influence as well.</summary>
[Serialized]
public class SettlementManager : 
  Singleton<
  #nullable disable
  SettlementManager>,
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<
  #nullable enable
  ThreadSafeSubscriptions>,
  ISubscriptions,
  INotifyPropertyChanged
{
  public 
  #nullable disable
  ThreadSafeAction FastTickEvent;
  public ThreadSafeAction<IEnumerable<Settlement>> SettlementInfluenceChangedEvent;
  public ThreadSafeAction<Settlement> ImmigrationChanged;

  [SyncToView(null, true)]
  [Serialized]
  public Settlement LegacySettlement { get; set; }

  public SettlementDebug Debug { get; }

  public void Initialize();

  public LocString GetStatusForSettlement(Vector2i pos);

  public void SlowTick();

  /// <summary>Allows external processes to trigger an immediate update when big changes happen</summary>
  public void EnsureUpdated();

  public void FastTick();

  /// <summary>Gets the point influencing the given position, considering only the influence points, not anything else like assigned settlement on stakes, which can affect it otherwise.
  /// Passed null means take lowest.</summary>
  public Settlement GetInfluenceAccordingToInfluencePointsOnlyAtPos(
    PlotPos pos,
    SettlementType? settlementTypeBeingCalculated,
    Influence[] influences = null);

  public bool InfluencedBy(Settlement settlement, Vector2i worldPos);

  public bool InfluencedBy(Settlement settlement, PlotPos plotPos);

  public void ForceUpdateAllSettlements();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public enum InitPriority
  {
    FixCitizenship = -100, // 0xFFFFFF9C
    CultureManager = -50, // 0xFFFFFFCE
    Normal = 0,
  }
}
