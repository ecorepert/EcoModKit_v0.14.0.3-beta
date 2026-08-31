// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ClassRenameMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

public class ClassRenameMigration : InstanceMigration, ITypeMigration, IClassMigration, IMigration
{
  public ClassRenameMigration(
  #nullable disable
  IDictionary<string, string> mapping);

  public ClassRenameMigration(string oldClassName, string newClassName);

  public override void MigrateInstance(MigrationContext context);

  public override void MigrateReference(MigrationContext context);

  public string MigrateType(string typeName);
}
