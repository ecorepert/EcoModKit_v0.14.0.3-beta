// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TreeDebrisBlock
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Serialization;
using Eco.World.Blocks;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
/// <summary> Debris blocks tagged for talent-gated hand pickup via HandsInteractor.PickupDebris. Only players with the Cleanup Crew talent see the pickup interaction. </summary>
[Serialized]
[Occupied]
[Tag("Choppable")]
[Tag("DebrisPickupable")]
public class TreeDebrisBlock : Block, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }
}
