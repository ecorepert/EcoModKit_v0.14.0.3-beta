// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.IMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Base migration class.</summary>
public interface IMigration
{
  void Initialize(MigrationManager migrationManager);

  /// <summary>
  /// Performs migration using current MigrationContext.
  /// <see cref="M:Eco.Core.Serialization.Migrations.IMigration.Migrate(Eco.Core.Serialization.Migrations.MigrationContext)" /> method should follow a contract:
  /// - It can only modify <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Reader" /> and <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" />.
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" /> may only be modified with <see cref="M:Eco.Core.Serialization.Migrations.MigrationManager.CreateSchema(System.String)" /> or other similar methods (no new instance creation!)
  /// - If <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Reader" /> modified then it should fully consume migrated content from original reader, otherwise it should set the reader at initial read position.
  /// General rule is to always return a reader positioned at beginning of serialized content.
  /// </summary>
  /// <param name="context"></param>
  void Migrate(MigrationContext context);
}
