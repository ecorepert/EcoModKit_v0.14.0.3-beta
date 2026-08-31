// Decompiled with JetBrains decompiler
// Type: Eco.Stats.IgnoreAggregateGroupingAttribute
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using System;

#nullable disable
namespace Eco.Stats;

/// <summary>Marks that property is ignored for aggregation grouping. I.e. Count shouldn't be used in grouping, because it is aggregatable field.</summary>
public class IgnoreAggregateGroupingAttribute : Attribute
{
}
