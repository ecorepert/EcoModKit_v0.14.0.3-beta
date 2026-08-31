// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_5.GameValueMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_5;

[Migration(SinceVersion = 3.91)]
[MigrationType(typeof (GameValueContext<Vector3i>))]
[MigrationType(typeof (GameValueContext<IAlias>))]
[MigrationType(typeof (GameValueContext<bool>))]
[MigrationType(typeof (GameValueContext<float>))]
[MigrationType(typeof (GameValueContext<string>))]
[MigrationType(typeof (GameValueContext<BankAccount>))]
[MigrationType(typeof (GameValueContext<Currency>))]
[MigrationType(typeof (GameValueContext<User>))]
public class GameValueMigration : AggregateMigration
{
}
