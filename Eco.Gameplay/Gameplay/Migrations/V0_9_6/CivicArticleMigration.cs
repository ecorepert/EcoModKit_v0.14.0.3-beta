// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_6.CivicArticleMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;
using System;

#nullable enable
namespace Eco.Gameplay.Migrations.V0_9_6;

[Migration(SinceVersion = 3.92)]
public class CivicArticleMigration : MigrationCollection
{
  /// <summary>This will help to convert old condition member to the new GamePickerList entry.
  /// To create a game picker entry we will first create a value of a type we need and convert it to a GamePikerList entry.</summary>
  public void MigrateConditions(
    DataMigration dm,
    Type entryType,
    string migrateMember = "ChangingCivicObjects",
    string genericTypeName = "class[Eco.Gameplay.Civics.Misc.IProposable]");
}
