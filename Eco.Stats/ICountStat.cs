// Decompiled with JetBrains decompiler
// Type: Eco.Stats.ICountStat
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

#nullable disable
namespace Eco.Stats;

/// <summary>Stat which has <see cref="P:Eco.Stats.ICountStat.Count" /> value. It may be used primary for the aggregation or when action performed on multiple items, but
/// should be counted for each of them (i.e. "buy" for N items should be same as two "buy" actions for N/2 items, and for pollution the amount is the total pollution quantity).</summary>
public interface ICountStat
{
  [SumInAggregateGrouping]
  float Count { get; set; }
}
