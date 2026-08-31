// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TimeFormatter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Shared.Utils;

public static class TimeFormatter
{
  public static string FormatTimeTrickery(double timeSeconds);

  public static string FormatDateTrickery(double timeSeconds);

  public static string FormatDateLongTrickery(double timeSeconds);

  public static string FormatSpanLongTrickery(double timeSeconds);

  public static string FormatDateLong(double timeSeconds);

  public static string FormatDateColor(double timeSeconds);

  public static string FormatDateTimeColor(this DateTime dateTime);

  public static string FormatSimple(TimeSpan time);

  public static string FormatSpan(
    double timeSeconds,
    TimeFormatter.Rounding rounding = TimeFormatter.Rounding.ShowTwoBiggest,
    bool useAbbreviations = true,
    bool showEmptyUnits = false,
    LocString expiredText = default (LocString));

  public static string FormatSpan(
    TimeSpan time,
    TimeFormatter.Rounding rounding = TimeFormatter.Rounding.ShowTwoBiggest,
    bool useAbbreviations = true,
    bool showEmptyUnits = false);

  public static string FormatSpanColor(
    double timeSeconds,
    TimeFormatter.Rounding rounding = TimeFormatter.Rounding.ShowTwoBiggest,
    bool useAbbreviations = true,
    bool showEmptyUnits = false,
    LocString expiredText = default (LocString));

  public static string FormatTimeTill(double nextTrigger, double time);

  public static string FormatTimeSince(double lastTime, double time);

  public enum Rounding
  {
    ShowAllUnits,
    ShowTwoBiggest,
    ShowBiggest,
  }

  private enum MostBiggestTimeDisplayUnit
  {
    Second,
    Minute,
    Hour,
    Day,
  }
}
