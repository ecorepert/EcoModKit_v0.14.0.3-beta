// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ModernCompostBinObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Garbage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Hand-written half of the Tech Tree-generated <see cref="T:Eco.Mods.TechTree.ModernCompostBinObject" />: implements <see cref="T:Eco.Mods.TechTree.IGarbageBin" /> so a parked truck garbage module
/// can drain it, and restricts its storage to garbage-tagged items (CompostItem is itself <c>[Tag("Garbage")]</c>, so the Garbage tag is the right unifying restriction).
/// House bins get no pollution containment, only a waste shield that recharges while the bin sits empty.</summary>
[Serialized]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (MinimapComponent), null)]
[RequireComponent(typeof (LinkComponent), null)]
[RequireComponent(typeof (PublicStorageComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[WasteRetention(0.4f)]
[RequireComponent(typeof (PickupBountyComponent), null)]
[Tag("Usable")]
[Ecopedia("Waste Management", "Containment", false, true, "Modern Compost Bin Item")]
public class ModernCompostBinObject : WorldObject, IRepresentsItem, IGarbageBin
{
  public virtual Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }

  protected override void Initialize();

  public Inventory GarbageContents { get; }

  public bool TryClaimForCollection();

  public void ReleaseCollectionClaim();

  protected override void PostInitialize();
}
