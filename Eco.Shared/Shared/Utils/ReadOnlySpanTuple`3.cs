// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ReadOnlySpanTuple`3
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary><see cref="T:System.ValueTuple" /> like tuple of span values. <see cref="T:System.ReadOnlySpan`1" /> can't be used with non ref structs and classes and so we do need to have own tuple type for it.</summary>
public readonly ref struct ReadOnlySpanTuple<T1, T2, T3>
{
  public readonly ReadOnlySpan<T1> Item1;
  public readonly ReadOnlySpan<T2> Item2;
  public readonly ReadOnlySpan<T3> Item3;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public ReadOnlySpanTuple(ReadOnlySpan<T1> item1, ReadOnlySpan<T2> item2, ReadOnlySpan<T3> item3);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Deconstruct(
    out ReadOnlySpan<T1> item1,
    out ReadOnlySpan<T2> item2,
    out ReadOnlySpan<T3> item3);
}
