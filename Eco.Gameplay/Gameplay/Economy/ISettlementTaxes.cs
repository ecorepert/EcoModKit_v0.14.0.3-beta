// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.ISettlementTaxes
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Settlements;

#nullable disable
namespace Eco.Gameplay.Economy;

public interface ISettlementTaxes
{
  void ShowTaxUpdates(Settlement set);

  void SetSalesTax(float val);

  void SetCraftingFeeTax(float val);

  void SetContractTax(float val);

  void SetDirectTransferTax(float val);

  void SetPropertyTax(float val);

  void SetSelfDirectTransferTax(float val);

  float GetSalesTax(Currency currency = null);

  float GetCraftingFeeTax(Currency currency = null);

  float GetContractTax(Currency currency = null);

  float GetDirectTransferTax(Currency currency = null);

  float GetSelfDirectTransferTax(Currency currency = null);

  float GetCurrencyExchangeTax(Currency currency = null);
}
