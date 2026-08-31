// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Comparers.ReferenceEqualityComparer
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Comparers;

/// <summary><see cref="T:Eco.Shared.Comparers.ReferenceEqualityComparer" /> compares objects by reference.</summary>
public sealed class ReferenceEqualityComparer : IEqualityComparer<object>
{
  public static readonly ReferenceEqualityComparer Instance;

  public bool Equals(object? x, object? y);

  public int GetHashCode(object? obj);
}
