// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BuildingToolItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.SharedTypes;
using Eco.Shared.Utils;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>
/// Base class for items that has block building functionality.
/// Extracted from HammerItem class. Needed to refer by type easily as tech tree item not available in core. (Same as like "is ToolItem" " is DurabilityItem", etc)
/// </summary>
[CanMakeBlockForm]
[Tag("Construction")]
public abstract class BuildingToolItem : ToolItem
{
  /// <summary>Swaps the targeted constructed block to the shape selected on the tool's form wheel, in place. Re-selecting the block's
  /// current shape rotates it instead. Costs the same as deconstructing and constructing: both game actions run (laws, claims) and the
  /// tool is used twice (calories, durability).</summary>
  [Interaction(InteractionTrigger.RightClick, "Change Shape", InteractionModifier.Ctrl, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Constructable"}, DisallowedEnvVars = new string[] {"Carried", "TargetHasRoutedPipe"})]
  public bool ChangeShape(
    Player player,
    InteractionTriggerInfo triggerInfo,
    InteractionTarget target);

  public override LocString GetNoSuitablePickupTargetFailureMessage(Inventory inventory);

  /// <summary> Attempts to pick up the block at given position. </summary>
  [RPC]
  public bool PickupBlock(Player player, Vector3i blockPos);

  /// <summary> Attempts to pick up multiple blocks at the given positions.</summary>
  [RPC]
  public bool PickupBlocks(Player player, BlockLayout layout);

  /// <summary> Attempts to pick up a World Object. </summary>
  [RPC]
  public Task<bool> PickupWorldObject(Player player, WorldObject worldObj);

  /// <summary> Attempts to place a layout of blocks at given position, with given rotation. </summary>
  [RPC]
  public bool Place(Player player, BlockLayout layout, int rotation);
}
