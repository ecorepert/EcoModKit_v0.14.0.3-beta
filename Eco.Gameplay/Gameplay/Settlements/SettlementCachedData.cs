// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementCachedData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements.Annexation;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>Tracks various properties of settlements needed for different things, and keeps them updated.</summary>
[Serialized]
public class SettlementCachedData : 
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IController,
  IViewController,
  IHasUniversalID
{
  public static 
  #nullable disable
  ThreadSafeAction<Settlement> SettlementCachedDataChanged;
  public static ThreadSafeAction<Settlement> CultureChanged;
  public ThreadSafeAction ChangedEvent;
  public HashSet<PlotPos> ClaimedPlots;
  public HashSet<PlotPos> InfluencedPlots;

  /// <summary>Cached sum of all culture values on all deeds of the settlement</summary>
  [SyncToView(SyncFlags.MustRequest)]
  [Notify]
  public LocString CultureDescription { get; set; }

  [Notify]
  public float CultureTotal { get; set; }

  [Notify]
  public float CultureRecursiveTotal { get; set; }

  /// <summary>Records of annexation where this settlement is the source or target.</summary>
  [SyncToView(SyncFlags.MustRequest)]
  public IEnumerable<AnnexationRecord> AnnexationRecords { get; }

  /// <summary>Cached list of deeds associated with this settlement</summary>
  public ControllerHashSet<Deed> Deeds { get; set; }

  public void Initialize(int settlementID);

  public void Destroy();

  /// <summary>Called by annexation builder when the enumerable may have changed.</summary>
  public void AnnexationRecordsUpdated();

  public LocString GetCultureFoldout();

  public LocString GetBenefitsFoldout();

  public LocString GetSpecialtiesFoldout(Settlement settlement);

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
