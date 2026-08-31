// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.Collectors.GCMetricCollector
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Diagnostics.Tracing;

#nullable enable
namespace Eco.Core.DebugStatistic.Collectors;

/// <summary>Implementation of <see cref="T:Eco.Core.DebugStatistic.Collectors.IMetricCollector" /> for collecting information and metrics about the .NET Garbage Collector.</summary>
public class GCMetricCollector : EventMetricCollector
{
  protected override void OnEventWritten(EventWrittenEventArgs eventData);
}
