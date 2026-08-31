// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.FuncPredicate`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Simple wrapper around <see cref="T:System.Func`2" /> delegate implementing <see cref="T:Eco.Shared.Utils.IPredicate`1" /> interface.</summary>
public readonly struct FuncPredicate<T> : IPredicate<T>
{
  private readonly Func<T, bool> func;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public FuncPredicate(Func<T, bool> func);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool Match(T item);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Func<T, bool> ToDelegate();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static implicit operator Func<T, bool>(FuncPredicate<T> predicate);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static implicit operator FuncPredicate<T>(Func<T, bool> func);
}
