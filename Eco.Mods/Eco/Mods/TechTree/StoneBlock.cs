// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.StoneBlock
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;
using Eco.World.Blocks;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
[Serialized]
[Solid]
[Wall]
[Minable(1)]
[BecomesRubble(new Type[] {typeof (StoneRubbleSet1Chunk1Object), typeof (StoneRubbleSet1Chunk2Object), typeof (StoneRubbleSet1Chunk3Object)})]
[BecomesRubble(new Type[] {typeof (StoneRubbleSet2Chunk1Object), typeof (StoneRubbleSet2Chunk2Object), typeof (StoneRubbleSet2Chunk3Object), typeof (StoneRubbleSet2Chunk4Object)})]
[BecomesRubble(new Type[] {typeof (StoneRubbleSet3Chunk1Object), typeof (StoneRubbleSet3Chunk2Object), typeof (StoneRubbleSet3Chunk3Object)})]
[BecomesRubble(new Type[] {typeof (StoneRubbleSet4Chunk1Object), typeof (StoneRubbleSet4Chunk2Object), typeof (StoneRubbleSet4Chunk3Object)})]
[Tag("Minable")]
public class StoneBlock : Block, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }
}
