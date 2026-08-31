// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.StopwatchUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary> <see cref="T:System.Diagnostics.Stopwatch" /> utilities for high performance time measures. </summary>
public static class StopwatchUtils
{
  /// <summary> Returns number of <see cref="P:System.Diagnostics.Stopwatch.ElapsedTicks" /> for <paramref name="milliseconds" />. </summary>
  public static long TicksFromMilliseconds(long milliseconds);

  /// <summary> Returns number of <see cref="P:System.Diagnostics.Stopwatch.ElapsedTicks" /> for <paramref name="milliseconds" />. </summary>
  public static long TicksFromMilliseconds(double milliseconds);

  /// <summary> Returns number of <see cref="P:System.Diagnostics.Stopwatch.ElapsedTicks" /> for <paramref name="seconds" />. </summary>
  public static long TicksFromSeconds(double seconds);

  /// <summary> Returns number of <see cref="P:System.Diagnostics.Stopwatch.ElapsedTicks" /> for <paramref name="timeSpan" />. </summary>
  public static long TicksFromTimeSpan(TimeSpan timeSpan);

  /// <summary> Returns number of milliseconds for <see cref="P:System.Diagnostics.Stopwatch.ElapsedTicks" />. </summary>
  public static double MillisecondsFromTicks(long ticks);

  /// <summary> Returns number of nanoseconds for <see cref="P:System.Diagnostics.Stopwatch.ElapsedTicks" />. </summary>
  public static double NanosecondsFromTicks(long ticks);

  /// <summary> Returns number of seconds for <see cref="P:System.Diagnostics.Stopwatch.ElapsedTicks" />. </summary>
  public static double SecondsFromTicks(long ticks);

  /// <summary> Returns <see cref="T:System.TimeSpan" /> for raw <see cref="T:System.Diagnostics.Stopwatch" /> ticks. </summary>
  public static TimeSpan TimeSpanFromTicks(long ticks);
}
