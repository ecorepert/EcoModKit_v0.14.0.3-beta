// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.CollectionMigrations.CollectionToDictionaryDataMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations.DataMigrations;
using System;
using System.Collections.Generic;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Migrations.CollectionMigrations;

public class CollectionToDictionaryDataMigration : CollectionMigration
{
  public DataInput ItemInput { get; }

  public CollectionToDictionaryDataMigration(string itemSchemaType, string newSchemaType);

  /// <summary>
  /// Adds key output generator modification. <paramref name="keyGenerator" /> generates <see cref="T:Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput" /> for an entry key.
  /// <see cref="P:Eco.Core.Serialization.Migrations.MigrationContext.DataInputs" /> provided as second argument and may be used for accessing other registered data inputs.
  /// <example>
  /// Migration from list of CurrencyHolding to Dictionary with Currency.SerializedId as a key.
  /// <code><![CDATA[
  /// var dm = new DataMigration(typeof(BankAccount));
  /// var holdingsMigration = new CollectionToDictionaryDataMigration(SchemaUtils.GetSchemaType(typeof(CurrencyHolding)));
  /// var serializedId      = holdingsMigration.ItemInput.Member("Currency").Member("SerializedID");
  /// holdingsMigration.AddKeyOutputGenerator(inputs => inputs[serializedId]);
  /// dm.MigrateMember(nameof(BankAccount.CurrencyHoldings), holdingsMigration);
  /// ]]></code></example>
  /// </summary>
  public void AddKeyOutputGenerator(
    Func<IDictionary<IDataInput, ReaderDataInput>, ReaderDataInput> keyGenerator);

  /// <summary>Same as <see cref="M:Eco.Core.Serialization.Migrations.CollectionMigrations.CollectionToDictionaryDataMigration.AddKeyOutputGenerator(System.Func{System.Collections.Generic.IDictionary{Eco.Core.Serialization.Migrations.DataMigrations.IDataInput,Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput},Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput})" />, but generates a value instead of <see cref="T:Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput" />.</summary>
  public void AddKeyOutputGenerator<TOutput>(
    Func<IDictionary<IDataInput, ReaderDataInput>, TOutput> keyGenerator);

  public override void Initialize(MigrationManager manager);

  public override void Migrate(MigrationContext context);

  /// <summary>Migrates Collection to Dictionary entries. Number of entries provided as <paramref name="count" />. Migrated content written to <paramref name="writer" />.</summary>
  protected int MigrateEntries(int count, MigrationContext context, BinaryWriter writer);
}
