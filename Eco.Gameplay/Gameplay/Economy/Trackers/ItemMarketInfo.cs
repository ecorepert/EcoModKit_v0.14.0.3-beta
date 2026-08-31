// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Trackers.ItemMarketInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Trackers;

public struct ItemMarketInfo : IComparable
{
  public int Item;
  public Tag Tag;
  public Currency Currency;
  public float AvgSale;
  public float AvgBuy;
  public float AvgBuySell;
  public float SaleCount;
  public float BuyCount;

  public ItemMarketInfo(Currency currency, int itemID, Tag tag, IEnumerable<TradeTracker> list);

  public int CompareTo(object obj);

  internal float Val(ExchangeType exchangeType);

  public bool HasVal(ExchangeType exchangeType);
}
