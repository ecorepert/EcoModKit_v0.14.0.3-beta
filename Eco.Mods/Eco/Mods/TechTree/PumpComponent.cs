// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PumpComponent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Pipes.LiquidComponents;
using Eco.Gameplay.Wires;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Pump")]
[NoIcon]
[RequireComponent(typeof (LiquidProducerComponent), null)]
[RequireComponent(typeof (ChunkSubscriberComponent), null)]
[Ecopedia(null, "Pipe Component", false, true, null)]
[Priority(-2)]
public class PumpComponent : WorldObjectComponent, IChunkSubscriber, IWireContainer
{
  /// <summary>Max horizontal distance, in blocks, between the pump and the open pipe end it draws from. Depth is free (a well straight below works), reach is not.</summary>
  public const int MaxIntakeDistance = 25;

  public override bool Enabled { get; }

  public IEnumerable<WireConnection> Wires { get; }

  public IEnumerable<Vector3i> CachedOpenEndPositions { get; }

  public bool ConnectedToWater { get; }

  /// <summary>True when the pipe does reach water, but the intake sits beyond <see cref="F:Eco.Mods.TechTree.PumpComponent.MaxIntakeDistance" /> horizontally, so nothing can be drawn.</summary>
  public bool IntakeTooFar { get; }

  public event Action ConnectivityUpdated;

  public event Action Destroyed;

  public override void Initialize();

  public override void OnAfterObjectMoved();

  public override void PostInitialize();

  public override void Destroy();

  public IEnumerable<Vector3i> RelevantChunkPositions();

  public float UpdateFrequencySec { get; }

  public float MaxQueuedChunkUpdateTime { get; }

  public double QueuedChunkUpdateTime { get; set; }

  public double LastChunkUpdateTime { get; set; }

  public void ChunksChanged();

  public void UpdateStatus();
}
