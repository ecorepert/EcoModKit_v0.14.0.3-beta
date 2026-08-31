// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Utils.StatUtils
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Stats;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.Utils;

/// <summary>Static utility functions for serving statistics data to web services.</summary>
public static class StatUtils
{
  /// <summary>Retrieves statistics information by name using specified start and end real life days to limit the returning data</summary>
  /// <param name="key">Name of the statistic to retrieve</param>
  /// <param name="startingDay">Day to start the retrieval range at</param>
  /// <param name="endingDay">Day to end the retrieval range at</param>
  /// <returns>Returns the stat's info, the values for the specified range, and the interval used to clamp the data results.</returns>
  public static (StatInfo Info, List<TimeValue> Values, int Interval) GetGraphValuesFromDayRange(
    string key,
    double startingDay,
    double endingDay,
    float maxSeconds);

  /// <inheritdoc cref="M:Eco.WebServer.Utils.StatUtils.GetGraphValuesFromDayRange(System.String,System.Double,System.Double,System.Single)" />
  public static (StatInfo Info, List<TimeValue> Values, int Interval) GetGraphValuesFromDayRange(
    string key,
    double startingDay,
    double endingDay);

  /// <inheritdoc cref="M:Eco.WebServer.Utils.StatUtils.GetGraphValuesFromDayRange(System.String,System.Double,System.Double,System.Single)" />
  public static (StatInfo Info, List<TimeValue> Values, int Interval) GetGraphValuesFromDayRange(
    StatInfo info,
    double startingDay,
    double endingDay);
}
