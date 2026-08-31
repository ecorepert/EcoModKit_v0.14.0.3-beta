// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ConcreteTypeMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations.DataMigrations;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary> Migration from base type to multiple concrete types based on object's field values. If you need to migrate only by single field you can use simplified <see cref="T:Eco.Core.Serialization.Migrations.ConcreteTypeMigration`1" />. </summary>
public class ConcreteTypeMigration : InstanceMigration
{
  /// <summary>
  /// Initializes a new instance of the <see cref="T:Eco.Core.Serialization.Migrations.ConcreteTypeMigration" /> class.
  /// It will convert every class of <paramref name="baseTypeName" /> into more specific (concrete) type using field values of <paramref name="fieldNames" />.
  /// For every migrated object it will invoke <paramref name="typeMapper" /> with array of values for <paramref name="fieldNames" /> in same order and the function should return new type name.
  /// </summary>
  public ConcreteTypeMigration(
    #nullable disable
    string baseTypeName,
    IEnumerable<string> fieldNames,
    Func<object[], string> typeMapper);

  /// <summary>
  /// Initializes a new instance of the <see cref="T:Eco.Core.Serialization.Migrations.ConcreteTypeMigration" /> class.
  /// It will convert every class of <paramref name="baseTypeName" /> into more specific (concrete) type using <paramref name="fieldNames" /> (members of the object).
  /// For every migrated object it will invoke <paramref name="typeMapper" /> with array of <see cref="T:Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput" /> for <paramref name="fieldNames" /> in same order and the function should return new type name.
  /// </summary>
  public ConcreteTypeMigration(
    string baseTypeName,
    IEnumerable<string> fieldNames,
    Func<ReaderDataInput[], string> typeMapper);

  /// <inheritdoc cref="M:Eco.Core.Serialization.Migrations.ClassMigrationBase.MigrateInstance(Eco.Core.Serialization.Migrations.MigrationContext)" />
  public override void MigrateInstance(MigrationContext context);
}
