// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.Collectors.EventMetricCollector
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Diagnostics.Tracing;

#nullable enable
namespace Eco.Core.DebugStatistic.Collectors;

/// <summary>Base class for all <seealso cref="T:System.Diagnostics.Tracing.EventListener" /> based <seealso cref="T:Eco.Core.DebugStatistic.Collectors.IMetricCollector" /> instances.</summary>
public class EventMetricCollector : EventListener, IMetricCollector
{
  /// <summary>Integer keyword value used to initialize our <seealso cref="T:System.Diagnostics.Tracing.EventListener" /> instance.</summary>
  protected int listenerKeyword;
  /// <summary>Represents the prefix value used to store metrics with <seealso cref="T:Eco.Core.DebugStatistic.PerformancePlugin" />. MetricPrefix.XXXX = Value.</summary>
  protected string metricPrefix;

  public EventMetricCollector(int listenerKeyword, string metricPrefix);

  public void Initialize();

  public void Shutdown();

  protected override void OnEventSourceCreated(EventSource eventSource);

  /// <inheritdoc cref="M:Eco.Core.DebugStatistic.PerformancePlugin.StoreValueMetric(System.String,System.Double)" />
  protected void StoreMetric(string metricName, double value);

  /// <inheritdoc cref="M:Eco.Core.DebugStatistic.PerformancePlugin.GetValueMetric(System.String)" />
  protected double GetMetric(string metricName);

  /// <summary>Stores the payload of an <seealso cref="T:System.Diagnostics.Tracing.EventWrittenEventArgs" /> object from the <seealso cref="T:System.Diagnostics.Tracing.EventListener" /> as metrics in the <seealso cref="T:Eco.Core.DebugStatistic.PerformancePlugin" /> singleton instance.</summary>
  /// <param name="eventData">Event payload to store as metrics.</param>
  protected void StoreEventData(EventWrittenEventArgs eventData);
}
