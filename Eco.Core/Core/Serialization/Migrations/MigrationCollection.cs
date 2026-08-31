// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.MigrationCollection
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Collection of migrations. Unlike <see cref="T:Eco.Core.Serialization.Migrations.AggregateMigration" /> these migrations are unordered and may be applied independently.</summary>
public class MigrationCollection : IEnumerable<IClassMigration>, IEnumerable
{
  /// <summary>Add <paramref name="migration" /> to the collection.</summary>
  protected void AddMigration(IClassMigration migration);

  /// <summary>Add new <see cref="T:Eco.Core.Serialization.Migrations.DataMigration" /> for type <typeparamref name="T" /> to the collection. <paramref name="configure" /> action may be used to add data modifications to the migration.</summary>
  protected void AddDataMigration<T>(Action<DataMigration> configure);

  /// <summary>Add new <see cref="T:Eco.Core.Serialization.Migrations.DataMigration" /> for type <paramref name="type" /> to the collection. <paramref name="configure" /> action may be used to add data modifications to the migration.</summary>
  protected void AddDataMigration(Type type, Action<DataMigration> configure);

  /// <summary>Add new <see cref="T:Eco.Core.Serialization.Migrations.DataMigration" /> for type name or schema type to the collection. <paramref name="configure" /> action may be used to add data modifications to the migration.</summary>
  protected void AddDataMigration(string typeOrSchemaType, Action<DataMigration> configure);

  public IEnumerator<IClassMigration> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
