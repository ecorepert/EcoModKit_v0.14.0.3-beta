// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DictionaryKeyMigration`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations.DictionaryMigrations;
using System;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Migrates all dictionary keys to new key values using <see cref="F:Eco.Core.Serialization.Migrations.DictionaryKeyMigration`2.converter" />.</summary>
public class DictionaryKeyMigration<TOldKey, TNewKey> : DictionaryEntriesMigration
{
  public DictionaryKeyMigration(string valueSchemaType, Func<TOldKey, TNewKey> converter);

  public override void Initialize(MigrationManager migrationManager);

  protected override int MigrateEntries(int count, MigrationContext context, BinaryWriter writer);
}
