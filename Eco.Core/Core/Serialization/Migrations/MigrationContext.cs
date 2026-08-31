// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.MigrationContext
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations.DataMigrations;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Migrations;

public class MigrationContext
{
  public ImmutableSerializerSchema Schema { get; set; }

  public double SchemaVersion { get; set; }

  public BinaryReader Reader { get; set; }

  public string ReferenceTypeName { get; set; }

  public int ReferenceId { get; set; }

  public Dictionary<IDataInput, ReaderDataInput> DataInputs { get; set; }
}
