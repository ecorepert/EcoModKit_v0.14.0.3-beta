// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Comparers.FuncBasedEqualityComparer`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Comparers;

/// <summary><see cref="T:System.Collections.Generic.IEqualityComparer`1" /> based on provided equality and hash functions. Useful when API only supports <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, but you want to use lambda functions.</summary>
public class FuncBasedEqualityComparer<T> : IEqualityComparer<T>
{
  public FuncBasedEqualityComparer(Func<T?, T?, bool> equals, Func<T, int> hashCode);

  public bool Equals(T? x, T? y);

  public int GetHashCode(T obj);
}
