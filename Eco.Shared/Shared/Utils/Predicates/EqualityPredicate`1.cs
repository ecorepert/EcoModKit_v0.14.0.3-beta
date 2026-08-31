// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Predicates.EqualityPredicate`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils.Predicates;

/// <summary>Equality predicate with custom <see cref="F:Eco.Shared.Utils.Predicates.EqualityPredicate`1.equalityComparer" />.</summary>
public readonly struct EqualityPredicate<T> : IPredicate<T>
{
  private readonly T equalTo;
  private readonly IEqualityComparer<T> equalityComparer;

  public EqualityPredicate(T equalTo, IEqualityComparer<T> equalityComparer);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool Match(T item);
}
