// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.NylonFutonBedObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (HousingComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (BedComponent), null)]
[RequireComponent(typeof (MountComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[RequireComponent(typeof (RoomRequirementsComponent), null)]
[RequireRoomContainment]
[RequireRoomVolume(26)]
[Tag("Usable")]
[Ecopedia("Housing Objects", "Bedroom", false, true, "Nylon Futon Bed Item")]
public class NylonFutonBedObject : WorldObject, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }

  protected override void Initialize();

  protected override void OnCreatePostInitialize();
}
