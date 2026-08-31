// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.ScopedEnumerable`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Collections;

/// <summary>Implementation of <see cref="T:Eco.Shared.Collections.IScopeAwareEnumerable`1" /> for scoped enumerable. Scoped enumerable can't be safely referenced outside of current method scope and have to make defensive copy in such cases.</summary>
public readonly struct ScopedEnumerable<T> : IScopeAwareEnumerable<T>, IEnumerable<T>, IEnumerable
{
  private readonly IEnumerable<T> enumerable;

  public ScopedEnumerable(IEnumerable<T> enumerable);

  public bool IsScoped { get; }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public IReadOnlyCollection<T> ToUnscopedCollection();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public IEnumerator<T> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
