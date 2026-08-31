// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.PipeSegment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Wires;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Pipes;

/// <summary>One connected liquid segment: the maximal set of pipe blocks of one type carrying one fluid, with its source ports (WireOutputs), the consumer
/// ports it feeds (WireInputs), and how many open ends it has. Rebuilt by <see cref="T:Eco.Gameplay.Pipes.PipeNetworkManager" /> from the trace caches whenever the topology changes.</summary>
public class PipeSegment
{
  public readonly List<WireOutput> Sources;
  public readonly List<WireInput> Sinks;
  public int OpenEndCount;
  public Type FluidType;
  public bool Conflicted;

  public int NodeCount { get; }
}
