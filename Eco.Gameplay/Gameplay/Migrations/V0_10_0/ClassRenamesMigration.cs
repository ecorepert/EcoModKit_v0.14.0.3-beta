// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_10_0.ClassRenamesMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_10_0;

[Migration(SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Civics.Elections.ElectionChoice", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Civics.Elections.ElectionChoiceYesNo", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Civics.Immigration.InitialSpawnManager", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.FuelSupplyComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.InOutLinkedInventoriesComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.ModularStockpileComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.PictureFrameComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.PublicStorageComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.SelectionStorageComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.StockpileComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.StorageComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.StoreCategory", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.StoreComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.StoreItemData", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Components.WorldStockpileComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Economy.ReputationManager", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Players.GroupMarkerPart", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Players.WorldMarker", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Players.WorldMarkerManager", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.CitizenRosterComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.CitizenshipOfCitizen", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.IsCitizenOfSettlement", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.SettlementClaimedPlotCount", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.SettlementCulture", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.SettlementFoundationComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.SettlementInfluencedPlotCount", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.SettlementRosterComponent", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.SettlmentAgeInDays", SinceVersion = 10.000001)]
[MigrationType("Eco.Gameplay.Settlements.SettlmentPopulation", SinceVersion = 10.000001)]
public class ClassRenamesMigration : AggregateMigration
{
}
