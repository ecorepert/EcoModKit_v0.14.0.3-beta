// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.EquatableArray`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Collections;

/// <summary>Equatable Array is a way to create equatable version of array which may be used as Dictionary key or for other hash/equals aware collections or operations.</summary>
public readonly struct EquatableArray<T>
{
  private readonly T[] array;
  private readonly int hashCode;

  public EquatableArray(params T[] array);

  public bool Equals(EquatableArray<T> other);

  public override bool Equals(object obj);

  public override int GetHashCode();

  public static bool operator ==(EquatableArray<T> left, EquatableArray<T> right);

  public static bool operator !=(EquatableArray<T> left, EquatableArray<T> right);
}
