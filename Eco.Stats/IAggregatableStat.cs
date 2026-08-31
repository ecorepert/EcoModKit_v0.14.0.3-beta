// Decompiled with JetBrains decompiler
// Type: Eco.Stats.IAggregatableStat
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

#nullable disable
namespace Eco.Stats;

/// <summary>Interface for aggregatable stats which may be merged together into less granular units. I.e. into minutes or hours.</summary>
public interface IAggregatableStat : ICountStat, IActionStat, IStat
{
}
