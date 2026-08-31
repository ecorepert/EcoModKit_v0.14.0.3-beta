// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Geometry.IPosition3`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Math.Geometry;

/// <summary>Base interface for all positions for generic math.</summary>
public interface IPosition3<out T>
{
  T X { get; }

  T Y { get; }

  T Z { get; }
}
