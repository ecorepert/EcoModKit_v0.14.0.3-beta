// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Wrapping.IWrappedPosition3WithUnboundedY`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math.Geometry;

#nullable enable
namespace Eco.Shared.Math.Wrapping;

/// <summary>Interface for unbounded by Y wrapped positions (Y may go negative or over world size Y). May be useful for intermediate calculations or for movable object positions which not tight to world grid space.</summary>
public interface IWrappedPosition3WithUnboundedY<out T> : IWrappedPosition3<T>, IPosition3<T>
{
  bool IWrappedPosition3<T>.HasBoundedY { get; }
}
