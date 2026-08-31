// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.OccupancyRequirementComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Occupancy;

/// <summary> Will enable/disable worldobject status if it passes through the world object placement requirements, by default the worldObject will use a surface side from
/// the defined occupancy position to calculate placement requirements, and some specific ones will use surface requirement for more complex  requirements</summary>
[Serialized]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (ChunkSubscriberComponent), null)]
public class OccupancyRequirementComponent : WorldObjectComponent, IChunkSubscriber
{
  public override bool Enabled { get; }

  public IEnumerable<Vector3i> RelevantChunkPositions();

  public float UpdateFrequencySec { get; }

  public float MaxQueuedChunkUpdateTime { get; }

  public double QueuedChunkUpdateTime { get; set; }

  public double LastChunkUpdateTime { get; set; }

  public override void Initialize();

  public void ChunksChanged();
}
