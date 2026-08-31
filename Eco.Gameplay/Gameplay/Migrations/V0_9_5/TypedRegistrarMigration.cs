// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_5.TypedRegistrarMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Core.Stats;
using Eco.Core.Systems;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Constitutional;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Civics.Districts;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.Immigration;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Economy.WorkParties;
using Eco.Gameplay.Items;
using Eco.Gameplay.LegislationSystem;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Messaging.Chat.Channels;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_5;

[Migration(SinceVersion = 3.915)]
[MigrationType(typeof (Registrar<CivicArticle>))]
[MigrationType(typeof (Registrar<ElectionProcess>))]
[MigrationType(typeof (Registrar<Law>))]
[MigrationType(typeof (Registrar<Election>))]
[MigrationType(typeof (Registrar<Title>))]
[MigrationType(typeof (Registrar<District>))]
[MigrationType(typeof (Registrar<DistrictMap>))]
[MigrationType(typeof (Registrar<Demographic>))]
[MigrationType(typeof (Registrar<Constitution>))]
[MigrationType(typeof (Registrar<ConstitutionalAmendment>))]
[MigrationType(typeof (Registrar<ImmigrationPolicy>))]
[MigrationType(typeof (Registrar<BankAccount>))]
[MigrationType(typeof (Registrar<Currency>))]
[MigrationType(typeof (Registrar<WorkOrder>))]
[MigrationType(typeof (Registrar<WorkParty>))]
[MigrationType(typeof (Registrar<Contract>))]
[MigrationType(typeof (Registrar<Settlement>))]
[MigrationType(typeof (Registrar<Channel>))]
[MigrationType(typeof (Registrar<StatEntry>))]
[MigrationType(typeof (GeneratedRegistrarWrapper<Tag>))]
public class TypedRegistrarMigration : AggregateMigration
{
}
