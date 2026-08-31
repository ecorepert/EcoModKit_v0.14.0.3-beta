// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.IChunkSubscriber
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components;

public interface IChunkSubscriber
{
  float UpdateFrequencySec { get; }

  double QueuedChunkUpdateTime { get; set; }

  double LastChunkUpdateTime { get; set; }

  float MaxQueuedChunkUpdateTime { get; }

  bool ResetUpdateTimeOnEveryChange { get; }

  bool IgnorePlantUpdates { get; }

  void ChunksChanged();

  IEnumerable<Vector3i> RelevantChunkPositions();
}
