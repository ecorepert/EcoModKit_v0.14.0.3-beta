// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DummyMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary>
/// This migration may be used if you don't actually want to do any migration logic, but want to include this type in migration chain (to process attributes etc).
/// </summary>
public class DummyMigration : InstanceMigration
{
  public DummyMigration(string typeName);

  public override void MigrateInstance(MigrationContext context);
}
