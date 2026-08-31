// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ClassRemoveMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary> Migration for a removed class which allows to invoke <see cref="F:Eco.Core.Serialization.Migrations.ClassRemoveMigration.onRemove" /> callback for removed instances members data. </summary>
public class ClassRemoveMigration : InstanceMigration
{
  public ClassRemoveMigration(string compatibleType);

  public ClassRemoveMigration(
    string compatibleType,
    string[] memberNames,
    Action<object[]>? onRemove);

  /// <inheritdoc cref="M:Eco.Core.Serialization.Migrations.ClassMigrationBase.MigrateInstance(Eco.Core.Serialization.Migrations.MigrationContext)" />
  public override void MigrateInstance(MigrationContext context);
}
