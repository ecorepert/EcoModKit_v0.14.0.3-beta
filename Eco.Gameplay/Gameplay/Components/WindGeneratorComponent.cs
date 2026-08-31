// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.WindGeneratorComponent
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

/// <summary> A component that will adjust the power output of an object that requires a clear area for wind. </summary>
[Serialized]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (ChunkSubscriberComponent), null)]
[NoIcon]
public class WindGeneratorComponent : WorldObjectComponent, IChunkSubscriber
{
  public override bool Enabled { get; }

  IEnumerable<Vector3i> IChunkSubscriber.RelevantChunkPositions();

  public List<Vector3i> RelevantChunkPositions();

  public float UpdateFrequencySec { get; }

  public float MaxQueuedChunkUpdateTime { get; }

  public double QueuedChunkUpdateTime { get; set; }

  public double LastChunkUpdateTime { get; set; }

  public override void Initialize();

  /// <summary> Trigger the associated behavior if the chunks in RelevantChunkPositions are changed. </summary>
  public void ChunksChanged();

  /// <summary> Checks if there are any new chunks in the columns this generator occupies and subscribes to them. </summary>
  public void UpdateChunkSubscriptions();

  /// <summary> Adjusts power output based on this generators view of the sky. </summary>
  public void WindTest();
}
