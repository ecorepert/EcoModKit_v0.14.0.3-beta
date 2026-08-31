// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.CollectionEntriesMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Abstract collection migration (i.e. array or list).</summary>
public abstract class CollectionEntriesMigration : IMigration
{
  public string ElementSchemaType { get; }

  public string TargetElementSchemaType { get; }

  public IMigration EntryMigration { get; }

  public string TargetSchemaType { get; }

  protected CollectionEntriesMigration(
    string elementType,
    string targetElementType,
    IMigration entryMigration,
    Func<MigrationContext, int, bool>? filter = null);

  protected abstract string MakeSchemaType(string elementSchemaType);

  public void Initialize(MigrationManager migrationManager);

  public void Migrate(MigrationContext context);
}
