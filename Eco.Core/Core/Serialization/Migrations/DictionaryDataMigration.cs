// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DictionaryDataMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations.DataMigrations;
using Eco.Core.Serialization.Migrations.DictionaryMigrations;
using System;
using System.Collections.Generic;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>
/// Migration for both key and value. Original key and value may be accessed with <see cref="P:Eco.Core.Serialization.Migrations.DictionaryDataMigration.KeyInput" /> and <see cref="P:Eco.Core.Serialization.Migrations.DictionaryDataMigration.ValueInput" />.
/// It let you manipulate with Dictionary data at binary level similar way as <see cref="T:Eco.Core.Serialization.Migrations.DataMigration" /> works. With data inputs for key and value you can
/// access serialized data in binary form and use it for key and value generation. Migration itself doesn't define default modifications, but instead
/// modifications should be added with methods like <see cref="M:Eco.Core.Serialization.Migrations.DictionaryDataMigration.AddKeyTransform(System.Func{System.Collections.Generic.IDictionary{Eco.Core.Serialization.Migrations.DataMigrations.IDataInput,Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput},Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput})" />.
/// </summary>
public class DictionaryDataMigration : DictionaryEntriesMigration
{
  public DataInput KeyInput { get; }

  public DataInput ValueInput { get; }

  public DictionaryDataMigration(string keySchemaType, string valueSchemaType);

  public DictionaryDataMigration(
    string keySchemaType,
    string valueSchemaType,
    string newSchemaType);

  public override void Initialize(MigrationManager manager);

  /// <summary>
  /// Adds key transform modification. <paramref name="keyTransform" /> converts data input for a key to new key data input. <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.DataInputs" /> provided as second argument and may be used for accessing other registered data inputs.
  /// <example><code><![CDATA[
  /// var dm = new DataMigration(typeof(BankAccount));
  /// var holdingsMigration = new DictionaryDataMigration("int", SchemaUtils.GetSchemaType(typeof(Currency)));
  /// var serializedId      = holdingsMigration.ValueInput.Member("Currency").Member("SerializedID");
  /// holdingsMigration.AddKeyTransform(inputs => inputs[serializedId]);
  /// dm.MigrateMember(nameof(BankAccount.CurrencyHoldings), holdingsMigration);
  /// ]]></code></example>
  /// </summary>
  public void AddKeyTransform(
    Func<IDictionary<IDataInput, ReaderDataInput>, ReaderDataInput> keyTransform);

  /// <summary>Migrates Dictionary entries. Number of entries provided as <paramref name="count" />. Migrated content written to <paramref name="writer" />.</summary>
  protected override int MigrateEntries(int count, MigrationContext context, BinaryWriter writer);
}
