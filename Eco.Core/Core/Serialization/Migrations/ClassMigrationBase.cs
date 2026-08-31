// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ClassMigrationBase
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

public abstract class ClassMigrationBase : 
  IInstanceMigration,
  IClassMigration,
  IMigration,
  IReferenceMigration
{
  public abstract IEnumerable<string> CompatibleSchemaTypes { get; }

  protected MigrationManager MigrationManager { get; }

  public virtual void Initialize(MigrationManager migrationManager);

  public void Migrate(MigrationContext context);

  /// <summary>
  /// Migrates an instance with provided <paramref name="context" />.
  /// It may modify <paramref name="context" /> with one of following migration results:
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.ReferenceTypeName" /> != null means that binary content was fully consumed and a reference should be serialized instead. It should contains the referenced object id in <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.ReferenceId" />;
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" /> modified and output schema is a class schema, it means that original class binary data was replaced with another class binary data and it should use new object serializer;
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" /> modified and output schema is the cached serializer schema, it means that original binary content was consumed and object instance created and cached for upcoming deserialization call;
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" /> modified, but output schema not class or cached object, it means that <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Reader" /> contains compatible binary data. If reader wasn't modified then it will be reset to initial position.
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" /> not modified, if <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Reader" /> modified then it should be re-serialized with original serializer or just reset reader position otherwise.
  /// </summary>
  public abstract void MigrateInstance(MigrationContext context);

  /// <summary>
  /// Migrates an reference with provided <paramref name="context" />.
  /// It may modify <paramref name="context" /> with one of following migration results:
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.ReferenceTypeName" /> != null means that binary content was fully consumed and a reference should be serialized instead. It should contains the referenced object id in <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.ReferenceId" />;
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" /> modified and output schema is a class schema, it means that original class binary data was replaced with another class binary data and it should use new object serializer;
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" /> modified and output schema is the cached serializer schema, it means that original binary content was consumed and object instance created and cached for upcoming deserialization call;
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" /> modified, but output schema not class or cached object, it means that <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Reader" /> contains compatible binary data. If reader wasn't modified then it will be reset to initial position.
  /// - <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Schema" /> not modified, if <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.Reader" /> modified then it should be re-serialized with original serializer or just reset reader position otherwise.
  /// </summary>
  public abstract void MigrateReference(MigrationContext context);
}
