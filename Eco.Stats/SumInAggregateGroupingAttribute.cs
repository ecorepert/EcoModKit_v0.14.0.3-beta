// Decompiled with JetBrains decompiler
// Type: Eco.Stats.SumInAggregateGroupingAttribute
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using System;

#nullable disable
namespace Eco.Stats;

/// <summary>If property has this attribute then it won't be used as grouping key, but instead will aggregate sum of all values of the property.</summary>
public class SumInAggregateGroupingAttribute : Attribute
{
}
