// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SearchAndSelect.SearchAndSelectInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items.SearchAndSelect;

[Serialized]
public class SearchAndSelectInventory : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers
{
  public ThreadSafeAction OnSelectionChanged { get; }

  [Serialized]
  [SyncToView(null, true)]
  public int MaxStacks { get; }

  [Serialized]
  public string SearchTag { get; }

  [Serialized]
  public string SearchTitle { get; }

  [Serialized]
  public bool LimitQuantityTo1 { get; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<SearchAndSelectItem> Stacks { get; }

  public IEnumerable<ItemStack> GetSelection();

  public ref int ControllerID { get; }

  public SearchAndSelectInventory(
    int maxStacks,
    string searchTag,
    string searchTitle,
    bool limitQuantityTo1);

  protected SearchAndSelectInventory();

  [RPC]
  public void AddStack(Player player);

  public void Add(ItemStack stack);
}
