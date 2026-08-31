// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.ItemTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Utils;

[Serialized]
public sealed class ItemTracker
{
  public event Action<User, Type, int, string> OnItemsAdded;

  [Serialized]
  public ThreadSafeList<IStack> TrackingStacks { get; }

  [Serialized]
  public ThreadSafeList<IStack> RemainingStacks { get; }

  [Serialized]
  public ThreadSafeList<IStack> ContributedStacks { get; }

  [Serialized]
  public InventoryActionType TrackAction { get; set; }

  [Serialized]
  public Vector3i Position { get; set; }

  [Serialized]
  public string PrependText { get; set; }

  [Serialized]
  public WorldObjectHandle TargetObject { get; set; }

  [Serialized]
  public bool AutocontrolMarker { get; set; }

  [Serialized]
  public bool RememberContributions { get; set; }

  public ItemTracker();

  public ItemTracker(
    IEnumerable<ItemStack> stacks,
    User user,
    Vector3i pos,
    LocString prependText,
    WorldObject obj = null);

  public string Contents { get; }

  public void AddToGroupMarker(User user);

  public void RemoveFromGroupMarker(User user);

  public void RemoveFromGroupMarker(IEnumerable<User> users);

  public void LockTracker(
    IEnumerable<IStack> stacks,
    User user,
    Vector3i pos,
    LocString prependText,
    WorldObject obj = null,
    bool excludeContributed = false);

  public void UpdatePrependText(LocString prependText);

  public void SetStacks(IEnumerable<IStack> stacks, bool excludeContributed = false);

  public void ResetContributions();

  public bool CaptureAction(GameAction action);

  public void Destroy();

  public LazyResult ShouldOverrideAuth(GameAction action);

  public bool ActionPerformed(GameAction action);

  public void AddUsers(IEnumerable<User> users);

  public void AddUser(User user);

  public void RemoveUser(User user);

  public void UpdateMarks();

  public void AddRemainingItems(IEnumerable<ItemStack> stacks);

  /// <summary>
  /// Reduces remaining stacks using <paramref name="maxRemainingStacks" />. After this call remaining stacks will only have items from <paramref name="maxRemainingStacks" /> and all quantities
  /// will be less or equal to quantities in <paramref name="maxRemainingStacks" />. If current quantity less than in <paramref name="maxRemainingStacks" /> then it will stay untouched.
  /// </summary>
  /// <returns>True if any of remaining stacks was modified.</returns>
  public bool ReduceRemainingStacks<TStack>(ICollection<TStack> maxRemainingStacks) where TStack : IStack;

  /// <summary>Calculate contributed item amount base on contribution type to prevent re-counting when AutoContributed contribution </summary>
  public int ContributedItem(int itemMoved, Item item, WorkOrderContributionType contributionType);

  public int Needed(Item item);

  public bool AnyLeft { get; }

  public float PercentDone();

  public string FractionalDescription { get; }

  public string DescribeOriginal { get; }

  public string DescribeRemaining { get; }

  public LocString DescribeOriginalInline { get; }

  public LocString DescribeRemainingInline { get; }
}
