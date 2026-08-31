// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.PerformanceIntervalStat
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using ConcurrentCollections;

#nullable enable
namespace Eco.Core.DebugStatistic;

/// <summary>Custom interval stat counter used by <seealso cref="T:Eco.Core.DebugStatistic.PerformancePlugin" /> for generating reports.</summary>
internal class PerformanceIntervalStat
{
  public readonly ConcurrentHashSet<int> ControllerIDSet;
  public readonly ConcurrentHashSet<int> PlayerIdSet;
  public readonly string Name;
  public int Count;
  public double MS;

  public PerformanceIntervalStat(string name);

  public void Add(int count, double ms);

  public override string ToString();

  public string ToString(int padding);
}
