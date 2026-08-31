// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.SettlementTaxes
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy;

/// <summary>Defimes a set of taxes for a single settlement</summary>
[Serialized]
public class SettlementTaxes : 
  ISettlementTaxes,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public ThreadSafeAction TaxesChanged;

  [Serialized]
  [SyncToView(null, true)]
  public float SalesTax { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float CraftingFeeTax { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float ContractTax { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float DirectTransferTax { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float SelfDirectTransferTax { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float PropertyTax { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float CurrencyExchangeTax { get; }

  public Settlement Settlement { get; set; }

  [RPC]
  public void SetSalesTax(Player player, float val);

  [RPC]
  public void SetCraftingFeeTax(Player player, float val);

  [RPC]
  public void SetContractTax(Player player, float val);

  [RPC]
  public void SetDirectTransferTax(Player player, float val);

  [RPC]
  public void SetSelfDirectTransferTax(Player player, float val);

  [RPC]
  public void SetCurrencyExchangeTax(Player player, float val);

  [RPC]
  public void SetPropertyTax(Player player, float val);

  public void SetSalesTax(float val);

  public void SetCraftingFeeTax(float val);

  public void SetContractTax(float val);

  public void SetDirectTransferTax(float val);

  public void SetPropertyTax(float val);

  public void SetSelfDirectTransferTax(float val);

  public void SetCurrencyExchangeTax(float val);

  public ref int ControllerID { get; }

  public override string ToString();

  public List<float> TaxesToList();

  [OnDeserialized]
  public void UpdateOldTaxes();

  public float GetSalesTax(Currency currency = null);

  public float GetCraftingFeeTax(Currency currency = null);

  public float GetContractTax(Currency currency = null);

  public float GetDirectTransferTax(Currency currency = null);

  public float GetSelfDirectTransferTax(Currency currency = null);

  public float GetCurrencyExchangeTax(Currency currency = null);

  /// <summary>Set the value of all taxes</summary>
  public void AssignAll(float val);

  /// <summary>Return true if any tax rate is set.</summary>
  public bool AnyTaxes();

  /// <summary>Get a table of all the various types of taxes.</summary>
  public LocString DescribeTaxes();

  public void ShowTaxUpdates(Settlement settlement);

  public static LocString TotalAndTaxString(
    string format,
    Currency currency,
    float total,
    float taxRate);

  public static LocString SubtotalAndTaxString(
    string format,
    Currency currency,
    float total,
    float taxRate);

  public event PropertyChangedEventHandler PropertyChanged;
}
