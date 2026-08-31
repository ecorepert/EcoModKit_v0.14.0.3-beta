// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.FractionalBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Serialization;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Blocks;

/// <summary>World block that stores a fractional composition via <see cref="P:Eco.Gameplay.Blocks.FractionalBlock.InternalRepartition" />, the placed counterpart of a
/// <see cref="T:Eco.Gameplay.Blocks.FractionalBlockItem" />. Constructed either empty (default) or from the item whose repartition is copied on placement.</summary>
[Serialized]
public abstract class FractionalBlock : Block
{
  /// <summary>Per-material fill fractions that define this block's composition, keyed the same way as the item's.
  /// [ThreadSafe]: populated once at placement and mutated only by the owning block thread; tooltip reads are safe on the resulting snapshot.
  /// NOT [SyncToView] — see <see cref="P:Eco.Gameplay.Blocks.FractionalBlockItem.InternalRepartition" /> for the BSON-encoding rationale.</summary>
  [Serialized]
  [Notify]
  [ThreadSafe]
  public Dictionary<Type, float> InternalRepartition { get; set; }

  /// <summary>Default constructor for serialization and empty block creation.</summary>
  protected FractionalBlock();

  /// <summary>Initializes the block's repartition from a placed <see cref="T:Eco.Gameplay.Blocks.FractionalBlockItem" />, copying its composition into the world.</summary>
  protected FractionalBlock(FractionalBlockItem fractional);
}
