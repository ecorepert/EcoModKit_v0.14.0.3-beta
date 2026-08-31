// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.GarbageSorterObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Garbage;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Property;
using Eco.Gameplay.Skills;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Level 1 sorter: takes MixedGarbageItem and sorts it into 4 intermediate FractionalBlockItems (one per waste category).
/// Each category requires a catalyst to operate efficiently — without catalyst, sorted material becomes waste.</summary>
[Serialized]
[RequireComponent(typeof (OnOffComponent), null)]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (MinimapComponent), null)]
[RequireComponent(typeof (SharedLinkComponent), null)]
[RequireComponent(typeof (PartsComponent), null)]
[RequireComponent(typeof (PowerGridComponent), null)]
[RequireComponent(typeof (PowerConsumptionComponent), null)]
[RequireComponent(typeof (HousingComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[RequireComponent(typeof (PaintableComponent), null)]
[RequireComponent(typeof (RoomRequirementsComponent), null)]
[RequireRoomContainment]
[RequireRoomVolume(500)]
[RequireRoomMaterialTier(2.8f, new Type[] {})]
[Tag("Usable")]
[Ecopedia("Waste Management", "Garbage Sorting", false, true, "Garbage Sorter Item")]
[RepairRequiresSkill(typeof (MechanicsSkill), 1)]
[RepairRequiresSkill(typeof (SelfImprovementSkill), 5)]
[RequireComponent(typeof (SortingComponent), null)]
public class GarbageSorterObject : WorldObject, IRepresentsItem, ICatalystUser
{
  public virtual Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }

  protected override void Initialize();

  public static IEnumerable<CatalystSpec> Catalysts { get; }

  protected override void PostInitialize();
}
