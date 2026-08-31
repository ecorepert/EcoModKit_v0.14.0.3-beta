// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.TimeLog
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class TimeLog
{
  [Serialized]
  public ThreadSafeList<Range> Active;
  [Serialized]
  public double AdminSetBoostTime;

  public void StartTiming();

  public void StopTiming();

  /// <summary>Return the time played in the current day (not the last 24 hours, but in the last set of 24 hours since server start)</summary>
  public double SecondsPlayedToday();

  public double TotalAge();

  public double ActiveHours(double withinLastDays);

  public double ActiveSeconds(double withinLastSeconds);

  /// <summary>Counts the amount of days the player was online enough to be considered active.</summary>
  /// <remarks>A day is counted as active if the player was online for at least <paramref name="minimumHours" /> that day.</remarks>
  public int ActiveDays(float minimumHours);

  public LocString ActiveTimes();

  public int RecordCount();
}
