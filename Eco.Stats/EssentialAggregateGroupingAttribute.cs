// Decompiled with JetBrains decompiler
// Type: Eco.Stats.EssentialAggregateGroupingAttribute
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using System;

#nullable disable
namespace Eco.Stats;

/// <summary>Marks that property is important for grouping. For now only important property is Citizen since it's the only one that is used in queries.</summary>
public class EssentialAggregateGroupingAttribute : Attribute
{
}
