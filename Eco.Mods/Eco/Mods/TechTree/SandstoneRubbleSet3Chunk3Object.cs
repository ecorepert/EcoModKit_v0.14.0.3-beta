// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SandstoneRubbleSet3Chunk3Object
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Mods.TechTree;

[Eco.Gameplay.Objects.BecomesRubble(new Type[] {typeof (SandstoneRubbleSet3Chunk3Split1Object), typeof (SandstoneRubbleSet3Chunk3Split2Object)})]
[Serialized]
[Tag("MinableRubble")]
public class SandstoneRubbleSet3Chunk3Object : RubbleObject<SandstoneItem>
{
  public override Vector3 SpawnOffset { get; }
}
