// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.AggregatableAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Stats;

#nullable disable
namespace Eco.Gameplay.GameActions;

/// <summary> This is base class for all actions which can be grouped for optimization reasons. It already generates GetGroupingKey via reflection based on attributes and config of stats. </summary>
public abstract class AggregatableAction : 
  GameAction,
  IAggregatableStat,
  ICountStat,
  IActionStat,
  IStat
{
  [IgnoreAggregateGrouping]
  public virtual float Count { get; set; }

  public virtual void AggregateFrom(IAggregatableStat stat);
}
