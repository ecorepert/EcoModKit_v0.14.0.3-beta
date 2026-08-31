// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.VersionedObject`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Comparer which only compares version component of (version, object) component.</summary>
internal readonly struct VersionedObject<T> : IComparable<VersionedObject<T>>
{
  public readonly double SinceVersion;
  public readonly T Object;

  public VersionedObject(double sinceVersion, T obj);

  public int CompareTo(VersionedObject<T> other);
}
