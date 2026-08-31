// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.WaterRiverGeneratorComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary> A component that will adjust the power output of an object that requires river water. </summary>
[Serialized]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (ChunkSubscriberComponent), null)]
[NoIcon]
public class WaterRiverGeneratorComponent : WorldObjectComponent, IChunkSubscriber
{
  public override bool Enabled { get; }

  public IEnumerable<Vector3i> RelevantChunkPositions();

  public float UpdateFrequencySec { get; }

  public float MaxQueuedChunkUpdateTime { get; }

  public double QueuedChunkUpdateTime { get; set; }

  public double LastChunkUpdateTime { get; set; }

  public override void Initialize();

  /// <summary> Trigger the associated behavior if the chunks in RelevantChunkPositions are changed. </summary>
  public void ChunksChanged();

  /// <summary>
  /// Tests if the Waterwheel meets all necessary conditions to function.
  /// The Waterwheel needs at least some of its blocks submerged in water to function, and needs to be free of obstructions.
  /// In order for water to fill blocks occupied by the waterwheel, some of the blocks have to be set as EmptyBlock, which opens the possibility of a block being placed there, so checks exist to ensure this has not happened.
  /// </summary>
  public void WaterTest();
}
