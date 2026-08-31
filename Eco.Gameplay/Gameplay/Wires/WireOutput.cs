// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Wires.WireOutput
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Pipes;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Wires;

[ForceCreateView]
public class WireOutput : WireConnection
{
  public 
  #nullable disable
  ThreadSafeList<Ray> CachedOpenEnds { get; }

  public ThreadSafeHashSet<Vector3i> CachedChunks { get; }

  public int HorizontalLength { get; }

  public int VerticalLength { get; }

  public int TotalLength { get; }

  public Type CarriedLiquidType { get; set; }

  public Func<bool> IdleDisplayGate { get; set; }

  protected override Type IdleDisplayType { get; }

  internal IReadOnlyList<WireOutput> PeerOutputs { get; }

  internal IReadOnlyList<WireInput> ConnectedSinks { get; }

  /// <summary>The set of conflicting fluids when this output's network carries more than one liquid type, else null. Refreshes the network cache first.</summary>
  public Type[] ConflictingLiquidTypes();

  public WireOutput(WorldObject owner, Type connectionType, string name = "Output");

  public WireOutput(WorldObject owner, Type connectionType, Ray posDirLocal, string name = "Output");

  public override LocString WireConnectionTooltip { get; }

  public void SendSignal(float val);

  public void NotifyProducedTypeChanged(Type newType);

  public float SendItemConsume(ItemStack stack, int maxToSend, float time);

  public void StopSendingItems();

  public float MaxCanReceive(Type type);

  /// <summary>Uncapped pipe ends on this output's network — each one competes with the connected machines for flow (surfaced so producers can warn).</summary>
  public int OpenEndCount { get; }

  /// <summary>Machines wired to this output. Zero alongside open ends means the line is a deliberate discharge (a chimney, reclaimed water) rather than a leak.</summary>
  public int ConnectedInputCount { get; }

  public float SendItem(PipePayload payload, bool divideAmongOutputs = true);

  public override void UpdateIfNeeded();

  public void Destroy();

  public void ForceRebuild();
}
