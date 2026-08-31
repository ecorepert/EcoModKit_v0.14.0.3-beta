// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.AggregateMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Migration which aggregates multiple migrations into one. Migrations applied after each other for every compatible type.</summary>
public class AggregateMigration : ClassMigrationBase, ITypeMigration, IClassMigration, IMigration
{
  public override IEnumerable<string> CompatibleSchemaTypes { get; }

  public override void Initialize(MigrationManager migrationManager);

  public override void MigrateInstance(MigrationContext context);

  public override void MigrateReference(MigrationContext context);

  public string MigrateType(string typeName);

  public void AddMigration(IClassMigration migration);

  public void AddMigrations(IEnumerable<IClassMigration> migrationCollection);
}
