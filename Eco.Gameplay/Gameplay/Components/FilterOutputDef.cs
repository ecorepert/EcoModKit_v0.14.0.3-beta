// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.FilterOutputDef
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>One fractional-block output of a <see cref="T:Eco.Gameplay.Components.FilterComponent" />: a composition and a liquid-units threshold per emitted block.</summary>
public sealed class FilterOutputDef : IEquatable<
#nullable disable
FilterOutputDef>
{
  /// <summary>One fractional-block output of a <see cref="T:Eco.Gameplay.Components.FilterComponent" />: a composition and a liquid-units threshold per emitted block.</summary>
  public FilterOutputDef(IReadOnlyDictionary<Type, float> Composition, float UnitsPerEmission);

  public IReadOnlyDictionary<Type, float> Composition { get; init; }

  public float UnitsPerEmission { get; init; }

  [CompilerGenerated]
  public override 
  #nullable enable
  string ToString();

  [CompilerGenerated]
  public static bool operator !=(FilterOutputDef? left, FilterOutputDef? right);

  [CompilerGenerated]
  public static bool operator ==(FilterOutputDef? left, FilterOutputDef? right);

  [CompilerGenerated]
  public override int GetHashCode();

  [CompilerGenerated]
  public override bool Equals(object? obj);

  [CompilerGenerated]
  public bool Equals(FilterOutputDef? other);

  [CompilerGenerated]
  public FilterOutputDef \u003CClone\u003E\u0024();

  [CompilerGenerated]
  public void Deconstruct(
    out 
    #nullable disable
    IReadOnlyDictionary<Type, float> Composition,
    out float UnitsPerEmission);
}
