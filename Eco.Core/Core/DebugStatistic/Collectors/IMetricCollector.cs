// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.Collectors.IMetricCollector
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.DebugStatistic.Collectors;

/// <summary>Base interface for all metric collectors used by <seealso cref="T:Eco.Core.DebugStatistic.PerformancePlugin" />.</summary>
public interface IMetricCollector
{
  /// <summary>Performs setup/initialization operations on the metric collector instance.</summary>
  void Initialize();

  /// <summary>Performs shutdown operations on the metric collector instance.</summary>
  void Shutdown();
}
