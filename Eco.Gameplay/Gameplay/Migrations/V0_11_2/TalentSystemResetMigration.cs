// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_11_2.TalentSystemResetMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Gameplay.Players;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_11_2;

/// <summary>Resets only player TALENTS (not skills) for the talent system refactor.
/// Skills, specialties, and their levels are preserved - only the talent selections
/// are reset and stars refunded, so players can re-choose talents under the new bonus-based system.
/// Servers can place a <c>.donotmigratetalents</c> file in Configs/ to skip this migration.</summary>
[Migration(SinceVersion = 11.010703)]
[MigrationType(typeof (User))]
public class TalentSystemResetMigration : DataMigration
{
}
