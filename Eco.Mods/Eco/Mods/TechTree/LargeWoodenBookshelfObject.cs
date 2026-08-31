// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LargeWoodenBookshelfObject
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
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary> Partial class extension that gives the hidden Large Wooden Bookshelf a settlement-scoped area bonus for testing.
/// All crafting tables within the influence of the settlement selected on the Jurisdiction tab receive a 10% labor cost reduction.
/// This will be replaced with data-driven configuration in Phase H. </summary>
[Serialized]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[Tag("Usable")]
[Tag("HasTableSurface")]
[RequireComponent(typeof (AreaBonusComponent), null)]
[RequireComponent(typeof (JurisdictionComponent), null)]
[RequireComponent(typeof (StatusComponent), null)]
public class LargeWoodenBookshelfObject : WorldObject, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }

  protected override void Initialize();
}
