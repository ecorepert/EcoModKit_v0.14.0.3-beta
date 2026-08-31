// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.AreaOfEffectMode
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Math;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Base class for all AOE modes.</summary>
public abstract class AreaOfEffectMode
{
  /// <summary>Set to true to ignore all blocks if central block doesn't meet the condition.</summary>
  protected readonly bool requireCentralBlock;

  /// <param name="requireCentralBlock">Set to true to ignore all blocks if central block doesn't meet the condition.</param>
  protected AreaOfEffectMode(bool requireCentralBlock);

  /// <summary>Gets positions of all blocks affected by a tool during an interaction or an empty enumerable if no blocks are affected.</summary>
  /// <param name="player">Player who is using the tool.</param>
  /// <param name="centerPos">Position of the block player interacted with.</param>
  /// <param name="tagsTargetable">Only blocks that have any of these tags can be affected by this interaction.</param>
  /// <param name="mustHaveTags">Only blocks that have all of these tags can be affected by this interaction.</param>
  /// <param name="mustNotHaveTags">Only blocks that don't have any of these tags can be affected by this interaction.</param>
  public abstract IEnumerable<Vector3i> GetAffectedBlocks(
    Player player,
    Vector3i centerPos,
    IEnumerable<Tag> tagsTargetable,
    IEnumerable<Tag>? mustHaveTags = null,
    IEnumerable<Tag>? mustNotHaveTags = null);
}
