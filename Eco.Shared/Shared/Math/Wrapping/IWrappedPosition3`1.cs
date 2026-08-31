// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Wrapping.IWrappedPosition3`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math.Geometry;

#nullable enable
namespace Eco.Shared.Math.Wrapping;

/// <summary>Common interface for pre-wrapped positions for optimized calculations like <see cref="T:Eco.Shared.Math.WrappedWorldPosition3i" /> or <see cref="T:Eco.Shared.Math.WrappedPosition3i" />.</summary>
public interface IWrappedPosition3<out T> : IPosition3<T>
{
  bool HasBoundedY { get; }

  ref readonly WrappedSpace Space { get; }
}
