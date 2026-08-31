// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ReferenceCollectionToDictionaryMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary> Used to migrate a collection of references into a dictionary, with ID as key ('null' entries are skipped). </summary>
/// <remarks> Useful when wanting to migrate a ControllerList without having to wait for registrar initialization.    </remarks>
public class ReferenceCollectionToDictionaryMigration : IMigration
{
  protected 
  #nullable disable
  MigrationManager MigrationManager { get; }

  public void Initialize(MigrationManager migrationManager);

  public void Migrate(MigrationContext context);
}
