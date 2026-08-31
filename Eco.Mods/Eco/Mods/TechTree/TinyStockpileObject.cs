// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TinyStockpileObject
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
using Eco.Gameplay.Occupancy;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (LinkComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[Tag("Usable")]
[Ecopedia("Crafted Objects", "Storage", false, true, "Tiny Stockpile Item")]
[RequireComponent(typeof (PublicStorageComponent), null)]
[RequireComponent(typeof (StockpileComponent), null)]
[RequireComponent(typeof (WorldStockpileComponent), null)]
public class TinyStockpileObject : WorldObject, IRepresentsItem
{
  public static readonly Vector3i DefaultDim;

  public virtual Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }

  protected override void Initialize();

  public override InteractionTargetPriority TargetPriority { get; }

  protected override void OnCreatePostInitialize();

  protected override void PostInitialize();
}
