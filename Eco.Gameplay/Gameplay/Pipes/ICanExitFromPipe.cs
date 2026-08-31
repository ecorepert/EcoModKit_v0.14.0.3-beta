// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.ICanExitFromPipe
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Wires;
using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable enable
namespace Eco.Gameplay.Pipes;

public interface ICanExitFromPipe
{
  float OnPipeExit(WireOutput wire, Ray posDir, PipePayload payload);

  LocString FlowTooltip(float flowrate);

  /// <summary>Applies this fluid's lasting spill side-effects (e.g. ground pollution) for a volume discarded OUTSIDE a pipe network — e.g. a machine's
  /// buffered intake deleted on pickup. Unlike <see cref="M:Eco.Gameplay.Pipes.ICanExitFromPipe.OnPipeExit(Eco.Gameplay.Wires.WireOutput,Eco.Shared.Math.Ray,Eco.Gameplay.Pipes.PipePayload)" /> it must not place blocks or emit particles. Default: no effect.</summary>
  void OnDiscarded(Vector3i pos, float amount);
}
