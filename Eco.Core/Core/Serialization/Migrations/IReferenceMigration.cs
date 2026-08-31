// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.IReferenceMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Interface for object References migrations. I.e. for <see cref="T:Eco.Core.Serialization.Migrations.ClassRenameMigration" /> you need it to change reference type.</summary>
public interface IReferenceMigration : IClassMigration, IMigration
{
  /// <summary>Migrates <paramref name="context" /> containing information about reference: <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.ReferenceTypeName" /> and <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.ReferenceId" />.</summary>
  void MigrateReference(MigrationContext context);
}
