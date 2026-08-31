// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ObjectMigration`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary>
/// Used to migrate object instance to other object instance. It may not be used as auto root-level migration, but can be used explicitly as member migration or collection entry migration.
/// It allows to migrate object to null or to value type (opposite to <see cref="T:Eco.Core.Serialization.Migrations.ObjectInstanceMigration`2" />).
/// </summary>
public class ObjectMigration<TSrc, TDst> : IMigration
{
  protected MigrationManager MigrationManager { get; set; }

  public ObjectMigration(Func<MigrationManager, TSrc, TDst> migrate);

  public ObjectMigration(Func<TSrc, TDst> migrate);

  public void Initialize(MigrationManager migrationManager);

  public void Migrate(MigrationContext context);
}
