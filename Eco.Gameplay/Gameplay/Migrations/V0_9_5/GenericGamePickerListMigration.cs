// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_5.GenericGamePickerListMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Economy;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.LegislationSystem;
using Eco.Gameplay.Skills;
using Eco.Simulation.Types;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_5;

/// <summary> Migrates all existing <see cref="T:Eco.Gameplay.Civics.GameValues.GamePickerList" />s to <see cref="T:Eco.Gameplay.Civics.GameValues.GamePickerList`1" />, using <see cref="P:Eco.Gameplay.Civics.GameValues.GamePickerList.MustDeriveType" /> as 'T'.</summary>
[Migration(SinceVersion = 3.912)]
[MigrationType(typeof (GamePickerList<Title>))]
[MigrationType(typeof (GamePickerList<Skill>))]
[MigrationType(typeof (GamePickerList<IAlias>))]
[MigrationType(typeof (GamePickerList<Species>))]
[MigrationType(typeof (GamePickerList<Currency>))]
[MigrationType(typeof (GamePickerList<District>))]
[MigrationType(typeof (GamePickerList<GameAction>))]
[MigrationType(typeof (GamePickerList<Demographic>))]
public class GenericGamePickerListMigration : AggregateMigration
{
}
