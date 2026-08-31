// Decompiled with JetBrains decompiler
// Type: Eco.Stats.IActionStat
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using LiteDB;

#nullable disable
namespace Eco.Stats;

/// <summary>Interface for "action" stats. Action is deterministic and so can be identified by <see cref="P:Eco.Stats.IActionStat._id" /> and has <see cref="P:Eco.Stats.IActionStat.Time" /> when it happened.</summary>
public interface IActionStat : IStat
{
  ObjectId _id { get; set; }

  [IgnoreAggregateGrouping]
  int Time { get; set; }

  StatType StatType { get; }
}
