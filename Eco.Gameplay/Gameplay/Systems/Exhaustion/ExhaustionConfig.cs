// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Exhaustion.ExhaustionConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace Eco.Gameplay.Systems.Exhaustion;

/// <summary>Settings for storing server exhaustion configs</summary>
[Localized(true, false, "", false)]
public class ExhaustionConfig : 
  Singleton<ExhaustionConfig>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public DateTime LocalTime { get; }

  public DateTime UtcTime { get; }

  [TimeCategory]
  [LocDisplayName("Time Exhaustion")]
  public string OnOffInstruction { get; }

  [LocDescription("Defines local hours to refresh daily playtime hours (0 to 23 hours)")]
  [Range(0, 23, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
  [TimeCategory]
  [LocDisplayName("Refresh Local Hours")]
  public float RefreshLocalHours { get; set; }

  [LocDescription("Defines local minutes to refresh daily playtime hours (0 to 59 minutes)")]
  [Range(0, 59, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
  [TimeCategory]
  [LocDisplayName("Refresh Local Minutes")]
  public float RefreshLocalMinutes { get; set; }

  [LocDescription("Displays server local time")]
  [PropertyExplanation]
  [TimeCategory]
  [LocDisplayName("Local Time")]
  public string LocalTimeNow { get; }

  [LocDescription("Displays server local refresh time")]
  [PropertyExplanation]
  [TimeCategory]
  [LocDisplayName("Local Refresh Time")]
  public string LocalRefresh { get; }

  [LocDescription("Displays UTC time of server")]
  [PropertyExplanation]
  [TimeCategory]
  [LocDisplayName("UTC Time")]
  public string UTCNow { get; }

  [LocDescription("Displays UTC time to refresh daily gain hours for playtime.")]
  [PropertyExplanation]
  [TimeCategory]
  [LocDisplayName("UTC Refresh Time")]
  public string UTCRefresh { get; }

  [LocDescription("Refresh in hours as countdown")]
  [PropertyExplanation]
  [TimeCategory]
  [LocDisplayName("Refreshes in:")]
  public string TimeUntilRefreshDesc { get; }

  [LocDescription("At the exhaustion refresh time, each citizen's exhaustion time will be reset to this value.")]
  [PropertyExplanation]
  [TimeCategory]
  [LocDisplayName("Hours to be gained at current refresh")]
  public string RefreshHoursGain { get; }

  [LocDescription("The amount of hours of exhaustion time given to a user when a refresh happens on this day of the week.")]
  [DayCategory]
  public float MondayExhaustionRefreshHours { get; set; }

  [LocDescription("The amount of hours of exhaustion time given to a user when a refresh happens on this day of the week.")]
  [DayCategory]
  public float TuesdayExhaustionRefreshHours { get; set; }

  [LocDescription("The amount of hours of exhaustion time given to a user when a refresh happens on this day of the week.")]
  [DayCategory]
  public float WednesdayExhaustionRefreshHours { get; set; }

  [LocDescription("The amount of hours of exhaustion time given to a user when a refresh happens on this day of the week.")]
  [DayCategory]
  public float ThursdayExhaustionRefreshHours { get; set; }

  [LocDescription("The amount of hours of exhaustion time given to a user when a refresh happens on this day of the week.")]
  [DayCategory]
  public float FridayExhaustionRefreshHours { get; set; }

  [LocDescription("The amount of hours of exhaustion time given to a user when a refresh happens on this day of the week.")]
  [DayCategory]
  public float SaturdayExhaustionRefreshHours { get; set; }

  [LocDescription("The amount of hours of exhaustion time given to a user when a refresh happens on this day of the week.")]
  [DayCategory]
  public float SundayExhaustionRefreshHours { get; set; }

  [LocDescription("If enabled, when exhaustion refresh happens any unused time will be added to a time bank which can be used on subsequent days. This is capped at the property below.")]
  [PropertyExplanation]
  [SavingCategory]
  [SyncToView(null, true)]
  public bool AllowPlaytimeSaving { get; set; }

  [PropertyExplanation]
  [SavingCategory]
  [SyncToView(null, true)]
  [DependsOn("AllowPlaytimeSaving")]
  [LocDescription("Maximum saved hours players can store. This limits how much playtime player can save up.")]
  public float MaxSavedHours { get; set; }

  [PropertyExplanation]
  [SavingCategory]
  [SyncToView(null, true)]
  [DependsOn("AllowPlaytimeSaving")]
  [LocDescription("Pause exhaustion countdown when player sits in furniture or is sleeping and resumes when getting up.")]
  public bool AllowExhaustionPauseOnRest { get; set; }

  [PropertyExplanation]
  [SavingCategory]
  [SyncToView(null, true)]
  [LocDescription("Extra playtime hours for players when Exhaustion is first enabled.")]
  public float BonusHoursOnExhaustionEnabled { get; set; }

  [PropertyExplanation]
  [SavingCategory]
  [SyncToView(null, true)]
  [LocDescription("Allow bonus retroactive playtime for player when joining after first game day. So, player can receive as much time as if playing from start. Only enabled when AllowPlaytimeSaving is active.")]
  public bool BonusRetroactiveHoursAfterStart { get; set; }

  [VehicleCategory]
  [LocDescription("This determines if the specific vehicle is affected by exhaustion limitations or not, true means it cannot be used when exhausted.")]
  public List<VehicleExhaustionConfig> Vehicles { get; set; }

  /// <summary>Shortcut for each week day hour. Not meant to be displayed in editor</summary>
  [Browsable(false)]
  [SyncToView(null, true)]
  public Dictionary<int, float> HoursGainPerWeekday { get; }

  /// <summary> Shortcut for daily hours gain for today. Not meant to be seen in editor </summary>
  [Browsable(false)]
  public float DailyGainHoursToday { get; }

  /// <summary> Shortcut for max hours player can have today. Not meant to be seen in editor</summary>
  [Browsable(false)]
  public float MaxTotalHoursOfDay(DayOfWeek day);

  /// <summary> Shortcut for time in seconds until next hours gain refresh happens. Not meant to be seen in editor</summary>
  [Browsable(false)]
  public double TimeUntilRefresh { get; }

  /// <summary> Shortcut date time when next hours gain refresh happens. Not meant to be seen in editor</summary>
  [Browsable(false)]
  public DateTime CurrentRefresh { get; }

  public void SetHoursForAllDays(float val);

  public void Initialize();

  public bool IsExhaustable(PhysicsWorldObject wo);

  /// <summary>Daily hours gain from refresh at each week day</summary>
  public static float HoursGainPerDayFromWeek(DayOfWeek day);

  public static double SecondsGainPerDayFromWeek(DayOfWeek day);

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
