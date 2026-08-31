// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_0.BlocksMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_0;

[MigrationType("Eco.Mods.TechTree.MortaredSandstoneWindowGrillesBlock", MigrationType = typeof (MigrationDummyBlock), SinceVersion = 3.8)]
[MigrationType("Eco.Mods.TechTree.MortaredStoneWindowGrillesBlock", MigrationType = typeof (MigrationDummyBlock), SinceVersion = 3.8)]
[MigrationType("Eco.Mods.TechTree.MortaredGraniteWindowGrillesBlock", MigrationType = typeof (MigrationDummyBlock), SinceVersion = 3.8)]
[MigrationType("Eco.Mods.TechTree.MortaredLimestoneWindowGrillesBlock", MigrationType = typeof (MigrationDummyBlock), SinceVersion = 3.8)]
[MigrationType("Eco.Mods.TechTree.HewnLogWindowGrillesBlock", MigrationType = typeof (MigrationDummyBlock), SinceVersion = 3.8)]
[Migration(SinceVersion = 3.8)]
public class BlocksMigration : ClassRenameMigration
{
}
