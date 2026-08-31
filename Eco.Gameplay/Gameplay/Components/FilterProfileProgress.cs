// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.FilterProfileProgress
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Parked in-progress state of one multi-input profile: its byproduct accumulators (per-output, in mils) and loaded catalyst charge, kept while a
/// different profile is active so switching back resumes it instead of discarding it.</summary>
[Serialized]
public class FilterProfileProgress
{
  [Serialized]
  public int[] AccumulatedMilsPerOutput { get; set; }

  [Serialized]
  public CatalystState CatalystState { get; set; }
}
