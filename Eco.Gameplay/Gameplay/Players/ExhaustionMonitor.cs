// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.ExhaustionMonitor
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class ExhaustionMonitor : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public static bool ExhaustedEnabled { get; }

  public static bool ExhaustionTimeSaving { get; }

  [SyncToView(null, true)]
  public bool IsExhausted { get; }

  [SyncToView(null, true)]
  public ImmutableCountdown ExhaustionCountdown { get; }

  [SyncToView(null, true)]
  public ImmutableCountdown RefreshCountdown { get; }

  [SyncToView(null, true)]
  public double MaxDailySec { get; }

  [SyncToView(null, true)]
  public string RefreshHoursFormatted { get; }

  [SyncToView(null, true)]
  public string MaxTotalHoursFormatted { get; }

  [SyncToView(null, true)]
  public string MaxSavedHoursFormatted { get; }

  [SyncToView(null, true)]
  public string SavedHoursFormatted { get; }

  public double PlaytimeInPeriod { get; }

  public double SavedTimeInSecs { get; }

  public string TimeUntilRefreshDesc { get; }

  public double RemainingPlaytime { get; }

  public double MaxTimeForPeriodPlusSavedTime { get; }

  public double MaxSavedSec { get; }

  public void Init(User owner);

  public bool CheckEnergyAndNotify(out LocString result, PhysicsWorldObject wo = null);

  public void Tick();

  /// <summary>Sets current saved time and updates exhaustion time countdown</summary>
  public void SetSavedTime(double timeInSecs, bool force = false);

  public void ExhaustForDay();

  public void DefaultReset();

  public void SetLastRefreshDay(int days);

  public string DescribeExhaustion();

  /// <summary>Give this user an extra number of hours of energy.  This rolls over.</summary>
  public void Energize(float hours);

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
