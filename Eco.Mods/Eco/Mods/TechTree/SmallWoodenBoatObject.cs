// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SmallWoodenBoatObject
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
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[RequireComponent(typeof (StandaloneAuthComponent), null)]
[RequireComponent(typeof (PublicStorageComponent), null)]
[RequireComponent(typeof (MovableLinkComponent), null)]
[RequireComponent(typeof (VehicleComponent), null)]
[RequireComponent(typeof (BoatComponent), null)]
[RequireComponent(typeof (ModularStockpileComponent), null)]
[RequireComponent(typeof (MinimapComponent), null)]
[RequireComponent(typeof (PartsComponent), null)]
[RepairRequiresSkill(typeof (ShipwrightSkill), 3)]
[Ecopedia("Crafted Objects", "Vehicles", false, true, "SmallWoodenBoat Item")]
public class SmallWoodenBoatObject : PhysicsWorldObject, IRepresentsItem
{
  public override float InteractDistance { get; }

  public override TableTextureMode TableTexture { get; }

  public override bool PlacesBlocks { get; }

  public override LocString DisplayName { get; }

  public Type RepresentedItemType { get; }

  protected override void Initialize();
}
