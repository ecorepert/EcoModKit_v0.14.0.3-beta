// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.InstanceMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>
/// Base class for instance migrations. This kind of migration doesn't care about class headers, but only migrates instance content (fields, properties etc).
/// <see cref="T:Eco.Core.Serialization.Migrations.ClassMigrationBase" /> takes are about nullability flags and other meta info. It also constructs serialized header from output schema.
/// </summary>
public abstract class InstanceMigration : ClassMigrationBase
{
  public override IEnumerable<string> CompatibleSchemaTypes { get; }

  /// <summary>Constructs new <see cref="T:Eco.Core.Serialization.Migrations.InstanceMigration" /> which works with <paramref name="compatibleType" />. <paramref name="compatibleType" /> is either schema type or type name.</summary>
  protected InstanceMigration(string compatibleType);

  /// <summary>Constructs new <see cref="T:Eco.Core.Serialization.Migrations.InstanceMigration" /> which works with <paramref name="compatibleTypes" />. <paramref name="compatibleTypes" /> is either schema types or type names or mix.</summary>
  protected InstanceMigration(IEnumerable<string> compatibleTypes);

  public override void MigrateReference(MigrationContext context);
}
