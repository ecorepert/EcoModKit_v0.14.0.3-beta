// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_2.FlatSteelStairsMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_2;

[MigrationType("Eco.Mods.TechTree.FlatSteelFloatStairsBlock", MigrationType = typeof (MigrationDummyBlock), SinceVersion = 3.902)]
[MigrationType("Eco.Mods.TechTree.FlatSteelFloatStairs90Block", MigrationType = typeof (MigrationDummyBlock), SinceVersion = 3.902)]
[MigrationType("Eco.Mods.TechTree.FlatSteelFloatStairs180Block", MigrationType = typeof (MigrationDummyBlock), SinceVersion = 3.902)]
[MigrationType("Eco.Mods.TechTree.FlatSteelFloatStairs270Block", MigrationType = typeof (MigrationDummyBlock), SinceVersion = 3.902)]
[Migration(SinceVersion = 3.902)]
public class FlatSteelStairsMigration : ClassRenameMigration
{
}
