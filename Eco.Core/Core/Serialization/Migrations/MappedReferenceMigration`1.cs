// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.MappedReferenceMigration`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Migration for mapping from reference ID to object with <see cref="F:Eco.Core.Serialization.Migrations.MappedReferenceMigration`1.mapper" /> instead of standard reference resolve logic.</summary>
public class MappedReferenceMigration<T> : IClassMigration, IMigration, IReferenceMigration
{
  public MappedReferenceMigration(IEnumerable<string> compatibleSchemaTypes, Func<int, T?> mapper);

  public MappedReferenceMigration(IEnumerable<Type> compatibleTypes, Func<int, T?> mapper);

  public MappedReferenceMigration(Func<int, T?> mapper);

  public void Initialize(MigrationManager migrationManager);

  public void Migrate(MigrationContext context);

  public IEnumerable<string> CompatibleSchemaTypes { get; }

  public void MigrateReference(MigrationContext context);
}
