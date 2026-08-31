// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.PeriodicUpdate
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Shared.Utils;

[Serialized]
public class PeriodicUpdate
{
  public static Func<double> GetSimTime;
  [Serialized]
  public double Period;
  [Serialized]
  public double NextTickTime;

  public bool DoUpdate { get; }

  public PeriodicUpdate();

  /// <summary>Create a timer that will return true to DoUpdate every X seconds.  If 'startReady' is false, then it will wait until the time elapses before the first trigger.</summary>
  public PeriodicUpdate(double interval, bool useRealTime = true, bool startReady = true);

  public double Time { get; }

  public double TimeTillNext { get; }

  public void SetToTriggerNextTick();

  /// <summary>Update the next tick time to be 'period' away.</summary>
  public void Reset();
}
