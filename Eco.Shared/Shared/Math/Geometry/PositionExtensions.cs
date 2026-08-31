// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Geometry.PositionExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math.Geometry;

/// <summary>Position extension methods collection.</summary>
public static class PositionExtensions
{
  /// <summary>Returns XZ two-dimensional vector.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i XZ<T>(this T position) where T : IPosition3<int>;
}
