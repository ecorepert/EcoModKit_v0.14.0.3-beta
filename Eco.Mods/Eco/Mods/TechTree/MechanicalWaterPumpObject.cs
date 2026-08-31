// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.MechanicalWaterPumpObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Pipes.LiquidComponents;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[RequireComponent(typeof (LiquidProducerComponent), null)]
[RequireComponent(typeof (AttachmentComponent), null)]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (PowerGridComponent), null)]
[RequireComponent(typeof (PowerConsumptionComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[Tag("Usable")]
[Ecopedia("Crafted Objects", "Specialty", false, true, "Mechanical Water Pump Item")]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (OnOffComponent), null)]
[RequireComponent(typeof (PumpComponent), null)]
public class MechanicalWaterPumpObject : WorldObject, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }

  protected override void Initialize();
}
