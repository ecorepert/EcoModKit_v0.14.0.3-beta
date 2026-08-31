// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.LiquidComponents.ChimneyComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Pipes.LiquidComponents;

[RequireComponent(typeof (ChunkSubscriberComponent), null)]
[RequireComponent(typeof (LiquidProducerComponent), null)]
[NoIcon]
[Serialized]
public class ChimneyComponent : WorldObjectComponent, IChunkSubscriber
{
  public static int MaxPipeHorizontalOffset;

  public override bool Enabled { get; }

  public LiquidProducerComponent Producer { get; }

  public override void Initialize();

  public IEnumerable<Vector3i> RelevantChunkPositions();

  public float UpdateFrequencySec { get; }

  public float MaxQueuedChunkUpdateTime { get; }

  public double QueuedChunkUpdateTime { get; set; }

  public double LastChunkUpdateTime { get; set; }

  /// <summary>Returns chimney output position if it exits.</summary>
  public bool TryGetOutputPosition(out Vector3i outputPosition);

  public void ChunksChanged();
}
