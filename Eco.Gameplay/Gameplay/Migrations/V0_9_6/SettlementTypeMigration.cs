// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_6.SettlementTypeMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Shared.Items;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_6;

/// <summary> Migration related to Settlement.SettlementType migrated from enum to class </summary>
[Migration(SinceVersion = 3.92)]
[MigrationType(typeof (SettlementType))]
public class SettlementTypeMigration : DataMigration
{
}
