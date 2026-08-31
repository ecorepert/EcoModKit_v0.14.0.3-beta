// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.FilterInputProfile
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Garbage;
using System;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>One auto-detected input of a multi-input <see cref="T:Eco.Gameplay.Components.FilterComponent" />: the input fluid, its solid byproducts, and its optional catalyst.
/// All profiles share one output fluid (set on <see cref="M:Eco.Gameplay.Components.FilterComponent.ConfigureMultiInput(System.Type,System.Single,System.Single,Eco.Gameplay.Components.FilterInputProfile[])" />). The filter applies whichever profile matches the
/// fluid actually arriving — since a pipe network now carries a single fluid, no manual selection is needed.</summary>
public sealed class FilterInputProfile : IEquatable<
#nullable disable
FilterInputProfile>
{
  /// <summary>One auto-detected input of a multi-input <see cref="T:Eco.Gameplay.Components.FilterComponent" />: the input fluid, its solid byproducts, and its optional catalyst.
  /// All profiles share one output fluid (set on <see cref="M:Eco.Gameplay.Components.FilterComponent.ConfigureMultiInput(System.Type,System.Single,System.Single,Eco.Gameplay.Components.FilterInputProfile[])" />). The filter applies whichever profile matches the
  /// fluid actually arriving — since a pipe network now carries a single fluid, no manual selection is needed.</summary>
  public FilterInputProfile(Type InputType, FilterOutputDef[] Outputs, CatalystSpec? Catalyst = null);

  public Type InputType { get; init; }

  public FilterOutputDef[] Outputs { get; init; }

  public CatalystSpec? Catalyst { get; init; }

  [CompilerGenerated]
  public override 
  #nullable enable
  string ToString();

  [CompilerGenerated]
  public static bool operator !=(FilterInputProfile? left, FilterInputProfile? right);

  [CompilerGenerated]
  public static bool operator ==(FilterInputProfile? left, FilterInputProfile? right);

  [CompilerGenerated]
  public override int GetHashCode();

  [CompilerGenerated]
  public override bool Equals(object? obj);

  [CompilerGenerated]
  public bool Equals(FilterInputProfile? other);

  [CompilerGenerated]
  public FilterInputProfile \u003CClone\u003E\u0024();

  [CompilerGenerated]
  public void Deconstruct(
    out 
    #nullable disable
    Type InputType,
    out FilterOutputDef[] Outputs,
    out CatalystSpec? Catalyst);
}
