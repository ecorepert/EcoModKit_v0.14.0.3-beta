// Decompiled with JetBrains decompiler
// Type: Eco.World.Migrations.BlocksMigration78to80
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;

#nullable enable
namespace Eco.World.Migrations;

[Migration(SinceVersion = 3.5)]
public class BlocksMigration78to80 : AggregateMigration
{
  public class ThawMigration : DataMigration
  {
  }
}
