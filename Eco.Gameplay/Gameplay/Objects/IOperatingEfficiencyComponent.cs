// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.IOperatingEfficiencyComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary>A component that throttles the whole object: it reports a 0..1 throughput (e.g. an input pipe getting only half its demanded
/// fluid reports 0.5). The object's <see cref="P:Eco.Gameplay.Objects.WorldObject.OperatingEfficiency" /> is the MIN across providers; consumers (crafting, power,
/// fuel, housing) scale their work by it.</summary>
public interface IOperatingEfficiencyComponent
{
  float OperatingEfficiency { get; }
}
