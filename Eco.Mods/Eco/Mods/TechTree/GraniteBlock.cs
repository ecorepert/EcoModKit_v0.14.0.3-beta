// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.GraniteBlock
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
[Cliff]
[Minable(3)]
[BecomesRubble(new Type[] {typeof (GraniteRubbleSet1Chunk1Object), typeof (GraniteRubbleSet1Chunk2Object), typeof (GraniteRubbleSet1Chunk3Object)})]
[BecomesRubble(new Type[] {typeof (GraniteRubbleSet2Chunk1Object), typeof (GraniteRubbleSet2Chunk2Object), typeof (GraniteRubbleSet2Chunk3Object), typeof (GraniteRubbleSet2Chunk4Object)})]
[BecomesRubble(new Type[] {typeof (GraniteRubbleSet3Chunk1Object), typeof (GraniteRubbleSet3Chunk2Object), typeof (GraniteRubbleSet3Chunk3Object)})]
[BecomesRubble(new Type[] {typeof (GraniteRubbleSet4Chunk1Object), typeof (GraniteRubbleSet4Chunk2Object), typeof (GraniteRubbleSet4Chunk3Object)})]
[Tag("Minable")]
public class GraniteBlock : Block, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }
}
