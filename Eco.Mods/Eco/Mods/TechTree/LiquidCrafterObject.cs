// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LiquidCrafterObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Pipes.LiquidComponents;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (LiquidConverterComponent), null)]
[Category("Hidden")]
public class LiquidCrafterObject : WorldObject, IRepresentsItem
{
  public override LocString DisplayName { get; }

  public virtual Type RepresentedItemType { get; }

  protected override void Initialize();
}
