// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.MixedResidualsBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Blocks;
using Eco.Gameplay.Items;
using Eco.Shared.Serialization;
using Eco.World;
using Eco.World.Blocks;
using System;

#nullable disable
namespace Eco.Gameplay.Garbage;

[Serialized]
[NonSharedBlock]
[Solid]
[Wall]
[Diggable]
[Tag("Diggable")]
public class MixedResidualsBlock : FractionalBlock, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }

  protected MixedResidualsBlock();

  protected MixedResidualsBlock(FractionalBlockItem fractional);
}
