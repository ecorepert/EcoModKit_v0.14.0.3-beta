// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Tools.AggregatingValueRecorder
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Tools;

/// <summary><see cref="T:Eco.Shared.Tools.IValueRecorder" /> aggregating data by specific period. I.e. per second or per minute. Aggregates number of recorded values and total duration per period.</summary>
public class AggregatingValueRecorder : IValueRecorder
{
  /// <summary>Returns number of events per period aggregated data. I.e. per second.</summary>
  public AggregatedValue AggregatedCount { get; }

  /// <summary>Returns duration of all events per period aggregated data. I.e. per second.</summary>
  public AggregatedValue AggregateDuration { get; }

  /// <summary>Aggregation period.</summary>
  public TimeSpan Period { get; }

  public AggregatingValueRecorder(TimeSpan period, bool aggregateEmpty = true);

  public void RecordValue(in PerformanceCounterValue value);

  /// <summary>Ensures all periods data aggregated. Usually it auto flushes when next period starts, but for rare events it may not happen and require manual flush.</summary>
  public void FlushCompleted();

  void IValueRecorder.RecordValue(in PerformanceCounterValue value);
}
