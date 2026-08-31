// Decompiled with JetBrains decompiler
// Type: Eco.Stats.PlotPositionKeyAttribute
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using System;

#nullable disable
namespace Eco.Stats;

/// <summary>Marks that to generate grouping key the position should use converted to plots value. I.e. it will still group together actions that happened at (101,102) and (104,103) positions since they are happened at same plot. Value still be saved in world positions, i.e., after merging records, it will show 1 record: (2 actions at 101,102).</summary>
public class PlotPositionKeyAttribute : Attribute
{
}
