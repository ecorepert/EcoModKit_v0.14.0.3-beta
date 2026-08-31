// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.IEntryDataModification
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

/// <summary>Data modification for an entry of dictionary or collection.</summary>
public interface IEntryDataModification
{
  void Initialize(MigrationManager manager);

  /// <summary>Modifies <paramref name="dataInputs" /> for a collection or dictionary entry.</summary>
  void ModifyEntry(Dictionary<IDataInput, ReaderDataInput> dataInputs);
}
