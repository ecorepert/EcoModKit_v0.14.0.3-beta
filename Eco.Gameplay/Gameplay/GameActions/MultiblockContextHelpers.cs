// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.MultiblockContextHelpers
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.SharedTypes;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.GameActions;

public static class MultiblockContextHelpers
{
  /// <inheritdoc cref="M:Eco.Gameplay.GameActions.MultiblockContextHelpers.CreateMultiblockContext(Eco.Gameplay.Items.ToolItem,Eco.Gameplay.Players.Player,System.Boolean,System.Collections.Generic.IEnumerable{Eco.Shared.Math.Vector3i},System.Collections.Generic.IEnumerable{System.Type},System.Func{Eco.Gameplay.GameActions.GameAction})" />
  public static MultiblockActionContext CreateMultiblockContext(
    this ToolItem tool,
    Player player,
    bool applyXPSkill,
    Vector3i position,
    IEnumerable<Type>? blockTypesInArea = null,
    Func<GameAction>? gameActionConstructor = null);

  /// <summary>Builds a MultiblockActionContext based on the player's data.</summary>
  /// <param name="applyXPSkill">If FALSE, this sets the ExperienceSkill to NULL which results in no AddExperience() post effect being added to the action.</param>
  /// <param name="area">Positions of blocks to be included in this context.</param>
  /// <remarks>Returned MultiblockActionContext doesn't have to contain multiple blocks. It contains all blocks specified in <paramref name="area" />.</remarks>
  public static MultiblockActionContext CreateMultiblockContext(
    this ToolItem tool,
    Player player,
    bool applyXPSkill,
    IEnumerable<Vector3i>? area = null,
    IEnumerable<Type>? blockTypesInArea = null,
    Func<GameAction>? gameActionConstructor = null);

  /// <inheritdoc cref="M:Eco.Gameplay.GameActions.MultiblockContextHelpers.TryCreateMultiblockContext(Eco.Gameplay.Items.ToolItem,Eco.Gameplay.GameActions.MultiblockActionContext@,Eco.Shared.SharedTypes.InteractionTarget,Eco.Gameplay.Players.Player,System.Collections.Generic.IEnumerable{Eco.Gameplay.Items.Tag},System.Boolean,System.Collections.Generic.IEnumerable{System.Type},System.Func{Eco.Gameplay.GameActions.GameAction},System.Collections.Generic.IEnumerable{Eco.Gameplay.Items.Tag},System.Collections.Generic.IEnumerable{Eco.Gameplay.Items.Tag})" />
  public static bool TryCreateMultiblockContext(
    this ToolItem tool,
    out MultiblockActionContext context,
    InteractionTarget target,
    Player player,
    bool applyXPSkill = true,
    IEnumerable<Type>? blockTypesInArea = null,
    Func<GameAction>? gameActionConstructor = null,
    IEnumerable<string>? mustHaveTags = null,
    IEnumerable<string>? mustNotHaveTags = null,
    params string[] tagsTargetable);

  /// <summary>
  /// Builds a context that's ready to be used by the AtomicActions, including all necessary info for the action
  /// to be performed with the appropriate target block(s), and handle XP, durability, and calories consumption.
  /// </summary>
  /// <param name="tagsTargetable">Only blocks that have any of these tags can be affected by this interaction.</param>
  /// <param name="mustHaveTags">Only blocks that have all of these tags can be affected by this interaction.</param>
  /// <param name="mustNotHaveTags">Only blocks that don't have any of these tags can be affected by this interaction.</param>
  /// <returns>True if at least one block valid for this tool was found and context was successfully created.</returns>
  public static bool TryCreateMultiblockContext(
    this ToolItem tool,
    out MultiblockActionContext context,
    InteractionTarget target,
    Player player,
    IEnumerable<Tag> tagsTargetable,
    bool applyXPSkill = true,
    IEnumerable<Type>? blockTypesInArea = null,
    Func<GameAction>? gameActionConstructor = null,
    IEnumerable<Tag>? mustHaveTags = null,
    IEnumerable<Tag>? mustNotHaveTags = null);
}
