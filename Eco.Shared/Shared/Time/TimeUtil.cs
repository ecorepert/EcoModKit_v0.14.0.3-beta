// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Time.TimeUtil
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Items;
using System;

#nullable disable
namespace Eco.Shared.Time;

public static class TimeUtil
{
  public static DateTime UnixEpochTime;
  public const int SecondsPerMinute = 60;
  public const int SecondsPerHour = 3600;
  public const int SecondsPerDay = 86400;
  public const int DaysPerWeek = 7;

  public static double Seconds { get; }

  public static double Milliseconds { get; }

  public static double Days { get; }

  public static float SecondsF { get; }

  public static double SecondsToMs(double seconds);

  public static double MsToSeconds(double ms);

  public static double SecondsToMinutes(double seconds);

  public static double SecondsToHours(double seconds);

  public static double SecondsToDays(double seconds);

  public static double MinutesToSeconds(double minutes);

  public static double HoursToDays(double hours);

  public static double HoursToSeconds(double hours);

  public static double HoursToMinutes(double hours);

  public static double DaysToSeconds(double days);

  public static double DaysToMinutes(double days);

  public static double DaysToHours(double days);

  public static double WeeksToMinutes(double weeks);

  public static string DaysHoursMinutes(double seconds);

  public static double RealNowTimeSpanInSec();

  public static double RealNowTimeSpanInMin();

  /// <summary>Converts seconds to desired unit of time</summary>
  /// <returns>Time converted to <paramref name="timeUnits" /></returns>
  public static double SecondsToTimeUnit(double seconds, TimeUnits timeUnits);

  /// <summary>Converts time from one unit of time to another</summary>
  /// <returns>Time converted from <paramref name="startUnit" /> to <paramref name="finalUnit" /></returns>
  public static double ConvertTime(TimeUnits startUnit, double value, TimeUnits finalUnit);

  public static double DaysToSeconds(object dinnerPartyMaxDays);
}
