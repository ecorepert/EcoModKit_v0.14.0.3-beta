// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.PingData
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.DebugStatistic;

/// <summary> Used to track how ping and time together. Time is used to check for relevancy, i.e. look up only for last N minutes. </summary>
public struct PingData
{
  public float Seconds;
  public DateTime Time;

  public PingData(float ms, DateTime time);
}
