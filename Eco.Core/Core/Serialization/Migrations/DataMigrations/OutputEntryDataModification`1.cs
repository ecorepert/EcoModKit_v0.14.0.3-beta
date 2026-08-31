// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.OutputEntryDataModification`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

/// <summary>Modification with generates <see cref="T:Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput" /> for value of type <typeparamref name="TOutput" /> with <see cref="F:Eco.Core.Serialization.Migrations.DataMigrations.OutputEntryDataModification`1.generateOutput" /> function for specified <see cref="F:Eco.Core.Serialization.Migrations.DataMigrations.OutputEntryDataModification`1.dataInput" />. May be used by <see cref="T:Eco.Core.Serialization.Migrations.DictionaryDataMigration" /> or <see cref="T:Eco.Core.Serialization.Migrations.CollectionMigrations.CollectionToDictionaryDataMigration" /> for key/value data generation.</summary>
public class OutputEntryDataModification<TOutput> : IEntryDataModification
{
  public OutputEntryDataModification(
    DataInput input,
    Func<IDictionary<IDataInput, ReaderDataInput>, TOutput> generateOutput);

  public void Initialize(MigrationManager manager);

  public void ModifyEntry(Dictionary<IDataInput, ReaderDataInput> dataInputs);
}
