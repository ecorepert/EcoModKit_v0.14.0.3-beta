// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Store.Internal.PurchaseData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components.Store.Internal;

public class PurchaseData
{
  public User Customer;
  public Currency Currency;
  public BankAccount StoreAccount;
  public BankAccount CustomerAccount;
  public Dictionary<TradeOffer, int> Buying;
  public Dictionary<TradeOffer, int> Selling;
  public bool DisplayModelBeingBought;
  public HashSet<Inventory> DestinationInventories;
  /// <summary> For tag-based offers, maps each offer to the resolved concrete items and quantities (determined at trade time). </summary>
  public Dictionary<TradeOffer, List<(Item ResolvedItem, int Quantity)>> ResolvedTagItems;
  /// <summary> Snapshots of each offer's representative item at trade-setup time, used so notifications reflect what was sold rather than what the offer looks like after the pack has mutated it.</summary>
  public Dictionary<TradeOffer, Item> BuyingDisplayItems;
  public Dictionary<TradeOffer, Item> SellingDisplayItems;
  public float BuyerIncome;
  public float SellerIncome;
  public float Tax;

  public float PaymentDiff { get; }

  public bool IsBarter { get; }

  public string BuyDesc { get; }

  public string SellDesc { get; }

  /// <summary> Captures the current representative item for every buying/selling offer, so notifications built later still reflect the item at trade-setup time. </summary>
  public void CaptureDisplayItems();

  /// <param name="describingToTradeInitiator">Will you describe the trade to the player who initialized the trade?</param>
  public LocString TradeDesc(bool describingToTradeInitiator = false);
}
