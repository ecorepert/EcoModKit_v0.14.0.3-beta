// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SingleBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Math;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Makes tool affect only one block, effectively disabling AOE.</summary>
public class SingleBlock : AreaOfEffectMode
{
  public override IEnumerable<Vector3i> GetAffectedBlocks(
    Player player,
    Vector3i centerPos,
    IEnumerable<Tag> tagsTargetable,
    IEnumerable<Tag>? mustHaveTags = null,
    IEnumerable<Tag>? mustNotHaveTags = null);
}
