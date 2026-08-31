// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Store.Internal.StoreItemData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components.Store.Internal;

/// <summary> This class contains stores data: all offers and currency. It handles callbacks for offer changes.  </summary>
[Serialized]
public class StoreItemData : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers,
  IClearOnTrade,
  IClearRequestHandler,
  INotifyPropertyChanged
{
  [Notify]
  public static 
  #nullable disable
  ThreadSafeAction<StoreItemData> SellOffersChangedEvent { get; }

  [Notify]
  public static ThreadSafeAction<StoreItemData> BuyOffersChangedEvent { get; }

  [Serialized]
  [Notify]
  public Currency Currency { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<StoreCategory> SellCategories { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<StoreCategory> BuyCategories { get; set; }

  public IEnumerable<StoreCategory> Categories { get; }

  public IEnumerable<TradeOffer> SellOffers { get; }

  public IEnumerable<TradeOffer> BuyOffers { get; }

  public bool HasDataThatCanBeCleared { get; }

  public Result TryHandleClearRequest(Player player);

  public void CopyCategoriesFrom(StoreItemData other, StoreComponent target);

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
