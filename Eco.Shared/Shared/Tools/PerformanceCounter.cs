// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Tools.PerformanceCounter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Tools;

/// <summary>
/// A PerformanceCounter is a collection of values with performance data for a single topic.
/// Values will be grouped together under the PerformanceCounter name, but can optionally have text associated
/// with them individually too.
/// </summary>
public class PerformanceCounter
{
  public static Func<TimeSpan> GetTime;
  public const int AbsoluteMaxValues = 1000;
  protected readonly PerformanceCounterValue[] Values;
  public readonly int MaxValues;
  public int Head;
  public int Length;

  public string Name { get; }

  public ReadOnlySpan<PerformanceCounterValue> RecordedValues { get; }

  public int TotalCount { get; }

  public TimeSpan TotalDuration { get; }

  /// <summary>Create a PerformanceCounter with the maximum number of historical values stored.</summary>
  public PerformanceCounter(string name, int maxValues = 1000);

  /// <summary>Returns all value recorders of type <typeparamref name="T" />.</summary>
  public IEnumerable<T> GetRecorders<T>() where T : IValueRecorder;

  /// <summary> Add a value with an optional name. Call Dispose to end duration time, or use a using block.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public PerformanceCounterValueRef AddValue(string? name = null, object? context = null);

  /// <summary> Add a value with an optional name with known duration.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void AddValue(TimeSpan duration, string? name = null, object? context = null);

  /// <summary> Add an event marker, which is a durationless event.</summary>
  public void AddMarker();

  /// <summary>Get the min, max, and average for the specified period of time.</summary>
  public AggregatedValue Aggregate(TimeSpan period);

  /// <summary>Get the min, max, and average for the history of values.</summary>
  public AggregatedValue Aggregate();

  /// <summary>Attempts to retrieve the last value stored.</summary>
  /// <param name="value">Value stored if it exists. Otherwise 0</param>
  /// <returns><c>true</c> if a value was retrieved. Otherwise <c>false</c>.</returns>
  public bool TryGetLastValue(out double value);

  /// <summary>Empowers <see cref="T:Eco.Shared.Tools.PerformanceCounter" /> with <paramref name="valueRecorder" />. Do it before start using the counter to avoid multi-threading issues.</summary>
  public PerformanceCounter WithValueRecorder(IValueRecorder valueRecorder);
}
