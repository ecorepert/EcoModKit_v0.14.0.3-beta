// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.CompletedGarbage
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using System;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Represents a completed garbage output from a recipe. Quantity is in mils (1000 mils = 1 whole unit; see <see cref="F:Eco.Gameplay.Blocks.MilsMath.UnitMils" />).</summary>
[Serialized]
public class CompletedGarbage
{
  [Serialized]
  public Type? Garbage { get; set; }

  [Serialized]
  public int Quantity { get; set; }

  public CompletedGarbage();

  public CompletedGarbage(Type garbage, int quantity);
}
