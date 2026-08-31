// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DictionaryMigrations.DictionaryEntriesMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Migrations.DictionaryMigrations;

/// <summary>Base class for for dictionary entries migrations. Supports items filtering, but can't convert empty dictionary to non-empty.</summary>
public abstract class DictionaryEntriesMigration : DictionaryMigration
{
  protected DictionaryEntriesMigration(string keySchemaType, string valueSchemaType);

  protected DictionaryEntriesMigration(
    string keySchemaType,
    string valueSchemaType,
    string newSchemaType);

  public override void Migrate(MigrationContext context);

  protected abstract int MigrateEntries(int count, MigrationContext context, BinaryWriter writer);
}
