// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SearchAndSelect.SearchAndSelectItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Items.SearchAndSelect;

[Serialized]
public class SearchAndSelectItem : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public ThreadSafeAction OnSelectionChanged { get; }

  [SyncToView(null, true)]
  [Serialized]
  public ItemStack Stack { get; set; }

  [Serialized]
  public string SearchTag { get; }

  [Serialized]
  public string SearchTitle { get; set; }

  [Serialized]
  public bool LimitQuantityTo1 { get; }

  [SyncToView(null, true)]
  [DependsOn("Stack")]
  [NewTooltipChildren(CacheAs.Instance, TTCat.Controls)]
  public Item Item { get; }

  public SearchAndSelectItem();

  public SearchAndSelectItem(string searchTag, string searchTitle, bool limitQuantityTo1);

  [RPC]
  public void OnClick(Player player);

  [RPC]
  public void ReplaceStack(Player player, int itemTypeID, int count);

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
