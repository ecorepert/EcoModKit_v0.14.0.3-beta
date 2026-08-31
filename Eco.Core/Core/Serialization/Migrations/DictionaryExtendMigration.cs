// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DictionaryExtendMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations.DictionaryMigrations;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Migration extending dictionary with new items. Items should be generated with provided function.</summary>
public class DictionaryExtendMigration : DictionaryMigration
{
  public DictionaryExtendMigration(
    string keySchemaType,
    string valueSchemaType,
    Func<ICollection<KeyValuePair<object, object>>> generator);

  public override void Migrate(MigrationContext context);
}
