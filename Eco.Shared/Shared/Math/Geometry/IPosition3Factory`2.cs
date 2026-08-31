// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Geometry.IPosition3Factory`2
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math.Geometry;

/// <summary>
/// Adds API for new position creation for extension methods. Not intended for public API usage, but need to be public for extension methods.
/// These methods helps to implement generic math without overhead for extra world bounds checks for wrapped positions.
/// </summary>
public interface IPosition3Factory<out TPosition, T> : IPosition3<T> where TPosition : IPosition3Factory<TPosition, T>
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  internal TPosition WithXUnchecked(T x);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  internal TPosition WithYUnchecked(T y);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  internal TPosition WithZUnchecked(T z);

  internal TPosition WithComponentsUnchecked(T x, T y, T z);
}
