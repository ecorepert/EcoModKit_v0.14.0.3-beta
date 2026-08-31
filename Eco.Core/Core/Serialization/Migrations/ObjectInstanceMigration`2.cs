// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ObjectInstanceMigration`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary> Used to migrate object instance of compatible type (specified in constructor) to instance of same or another type. It may not produce null value as result and also may not produce value type. May be used as root level migration. </summary>
public class ObjectInstanceMigration<TSrc, TDst> : InstanceMigration
{
  public ObjectInstanceMigration(string compatibleType, Func<MigrationManager, TSrc, TDst> migrate);

  public ObjectInstanceMigration(
    IEnumerable<string> compatibleTypes,
    Func<MigrationManager, TSrc, TDst> migrate);

  public ObjectInstanceMigration(string compatibleType, Func<TSrc, TDst> migrate);

  public ObjectInstanceMigration(IEnumerable<string> compatibleTypes, Func<TSrc, TDst> migrate);

  public override void MigrateInstance(MigrationContext context);
}
