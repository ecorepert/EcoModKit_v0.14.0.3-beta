// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.VersionedTypeMapping`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Mapping between type name and corresponding object (i.e. <see cref="T:Eco.Core.Serialization.Migrations.IInstanceMigration" /> or <see cref="T:Eco.Core.Serialization.Migrations.IReferenceMigration" />) which aware about versioning.</summary>
internal class VersionedTypeMapping<T>
{
  public bool IsEmpty { get; }

  public IEnumerable<T> All { get; }

  /// <summary>Checks if there any mapping for any version for <paramref name="schemaType" />.</summary>
  public bool HasMapping(string schemaType);

  /// <summary>Quick check if there any migrations <paramref name="sinceVersion" /> for <paramref name="schemaType" />.</summary>
  public bool HasMigrations(string schemaType, double sinceVersion);

  /// <summary>Tries to get versioned objects for <paramref name="schemaType" /> having version greater than <paramref name="sinceVersion" /> and less than <paramref name="tillVersion" />.</summary>
  public bool TryGetVersionedObjects(
    string schemaType,
    double sinceVersion,
    double tillVersion,
    [NotNullWhen(true)] out IEnumerable<VersionedObject<T>>? objects);

  /// <summary>Tries to get versioned objects for <paramref name="schemaType" /> having version greater than <paramref name="sinceVersion" />.</summary>
  public bool TryGetVersionedObjects(
    string schemaType,
    double sinceVersion,
    [NotNullWhen(true)] out IEnumerable<VersionedObject<T>>? objects);

  /// <summary>Adds mapping for all <paramref name="schemaTypes" />.</summary>
  public void AddRange(IEnumerable<string> schemaTypes, double sinceVersion, T item);

  /// <summary>Adds mapping for <paramref name="schemaType" />.</summary>
  public void Add(string schemaType, double sinceVersion, T item);
}
