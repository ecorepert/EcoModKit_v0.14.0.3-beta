// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CountryFoundationObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Settlements.Components;
using Eco.Gameplay.Systems.InitialSpawn;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (MinimapComponent), null)]
[RequireComponent(typeof (HousingComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (RoomRequirementsComponent), null)]
[RequireRoomContainment]
[RequireRoomVolume(45)]
[RequireRoomMaterialTier(3f, new Type[] {})]
[Tag("Usable")]
[Ecopedia("Work Stations", "Government", false, true, "Country Foundation Item")]
[RequireComponent(typeof (CitizenRosterComponent), null)]
[RequireComponent(typeof (SettlementRosterComponent), null)]
[RequireComponent(typeof (RoomRequirementsComponent), null)]
[RequireComponent(typeof (ConstitutionComponent), null)]
[RelatedFeature("UseSettlementSystem", true)]
[HasCivicAction(typeof (CivicAction_JoinSettlement))]
[HasCivicAction(typeof (CivicAction_AddChildSettlement))]
[HasCivicAction(typeof (CivicAction_CedeChildSettlement))]
[HasCivicAction(typeof (CivicAction_SecedeFromParentSettlement))]
[HasCivicAction(typeof (CivicAction_DissolveSettlement))]
[HasCivicAction(typeof (CivicAction_CancelSettlementActions))]
[HasCivicAction(typeof (CivicAction_RevokeCitizenship))]
public class CountryFoundationObject : 
  SettlementFoundationObject,
  IRepresentsItem,
  ICivicObject,
  ISpawnPositionOffset
{
  public virtual Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }

  protected override void Initialize();

  public override SettlementType SettlementType { get; }

  public Vector2i SpawnPositionOffset { get; }
}
