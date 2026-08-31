// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SteamTractorObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.Exhaustion;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Custom Steam tractor logic goes here, stuff that ins't autogen.</summary>
[Serialized]
[RequireComponent(typeof (StandaloneAuthComponent), null)]
[RequireComponent(typeof (PaintableComponent), null)]
[RequireComponent(typeof (FuelSupplyComponent), null)]
[RequireComponent(typeof (FuelConsumptionComponent), null)]
[RequireComponent(typeof (MovableLinkComponent), null)]
[RequireComponent(typeof (AirPollutionComponent), null)]
[RequireComponent(typeof (VehicleComponent), null)]
[RequireComponent(typeof (CustomTextComponent), null)]
[RequireComponent(typeof (ModularVehicleComponent), null)]
[RequireComponent(typeof (MinimapComponent), null)]
[RequireComponent(typeof (PartsComponent), null)]
[RepairRequiresSkill(typeof (MechanicsSkill), 2)]
[ExhaustableUnlessOverridenVehicle]
[Ecopedia("Crafted Objects", "Vehicles", false, true, "SteamTractor Item")]
[RequireComponent(typeof (VehicleToolComponent), null)]
public class SteamTractorObject : PhysicsWorldObject, IRepresentsItem
{
  public override TableTextureMode TableTexture { get; }

  public override bool PlacesBlocks { get; }

  public override LocString DisplayName { get; }

  public Type RepresentedItemType { get; }

  protected override void Initialize();

  protected override void PostInitialize();
}
