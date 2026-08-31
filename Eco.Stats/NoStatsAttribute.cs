// Decompiled with JetBrains decompiler
// Type: Eco.Stats.NoStatsAttribute
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using Eco.Core.Controller;
using Eco.Shared.View;

#nullable disable
namespace Eco.Stats;

/// <summary> Prevents an action from being tracked in stats. </summary>
public class NoStatsAttribute : ViewClassAttribute
{
  public override ViewClassFlags Flags { get; }
}
