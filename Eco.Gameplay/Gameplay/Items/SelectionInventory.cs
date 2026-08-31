// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SelectionInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public class SelectionInventory : LimitedInventory
{
  public ThreadSafeAction OnSelectionChanged;

  [SyncToView(null, true)]
  protected IList<bool> SelectableStacks { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public int SelectedIndex { get; protected set; }

  public override bool NeedsAuth { get; }

  public ItemStack SelectedStack { get; }

  public Item SelectedItem { get; }

  protected SelectionInventory();

  public SelectionInventory(int maxStacks);

  protected override void Initialize();

  /// <summary>Refreshes SelectableStacks to match the current number of stacks. Call after adding/removing stacks.</summary>
  public void RefreshSelectableStacksSize();

  public bool SelectType(Player player, Type t);

  public bool SelectFirst(Player player, Predicate<ItemStack> test);

  [RPC]
  public virtual void RefreshSelected(Player player);

  [RPC]
  public virtual void SelectIndex(Player player, int slot);

  [RPC]
  public virtual void ReselectCurrent(Player player);
}
