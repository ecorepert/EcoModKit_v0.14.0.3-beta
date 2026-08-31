// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DictionaryMigrations.DictionaryValueMigration`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Migrations.DictionaryMigrations;

/// <summary>Migrates all dictionary values to new value using <see cref="F:Eco.Core.Serialization.Migrations.DictionaryMigrations.DictionaryValueMigration`2.converter" />.</summary>
public class DictionaryValueMigration<TOldValue, TNewValue> : DictionaryEntriesMigration
{
  public DictionaryValueMigration(string keySchemaType, Func<TOldValue, TNewValue> converter);

  public override void Initialize(MigrationManager migrationManager);

  protected override int MigrateEntries(int count, MigrationContext context, BinaryWriter writer);
}
