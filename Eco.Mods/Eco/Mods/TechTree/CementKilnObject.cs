// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CementKilnObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Pipes.LiquidComponents;
using Eco.Gameplay.Property;
using Eco.Gameplay.Skills;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[RequireComponent(typeof (AirPollutionComponent), null)]
[RequireComponent(typeof (ChimneyComponent), null)]
[RequireComponent(typeof (LiquidProducerComponent), null)]
[RequireComponent(typeof (AttachmentComponent), null)]
[RequireComponent(typeof (OnOffComponent), null)]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (MinimapComponent), null)]
[RequireComponent(typeof (LinkComponent), null)]
[RequireComponent(typeof (CraftingComponent), null)]
[RequireComponent(typeof (PartsComponent), null)]
[RequireComponent(typeof (FuelSupplyComponent), null)]
[RequireComponent(typeof (FuelConsumptionComponent), null)]
[RequireComponent(typeof (HousingComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (PluginModulesComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[RequireComponent(typeof (RoomRequirementsComponent), null)]
[RequireRoomContainment]
[RequireRoomVolume(24)]
[RequireRoomMaterialTier(2.8f, new Type[] {})]
[Tag("Usable")]
[Ecopedia("Work Stations", "Craft Tables", false, true, "Cement Kiln Item")]
[RepairRequiresSkill(typeof (MechanicsSkill), 1)]
[RepairRequiresSkill(typeof (SelfImprovementSkill), 5)]
public class CementKilnObject : WorldObject, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }

  protected override void Initialize();
}
