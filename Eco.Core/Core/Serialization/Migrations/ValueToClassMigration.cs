// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ValueToClassMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Migrates value to class with one of it's field filled with the value. Useful when required migration from value to class wrapping the value and extending it with additional info.</summary>
public class ValueToClassMigration : IMigration
{
  /// <summary>Creates new <see cref="T:Eco.Core.Serialization.Migrations.ValueToClassMigration" /> which converts a value to class with <paramref name="schemaType" /> and saves value to <paramref name="fieldName" /> with same schema type as the value.</summary>
  public ValueToClassMigration(string schemaType, string fieldName);

  public void Initialize(MigrationManager migrationManager);

  public void Migrate(MigrationContext context);
}
