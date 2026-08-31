// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.CurrencyInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

/// <summary> Holds the necessary currency info for contract clauses related with currency transfers. </summary>
public struct CurrencyInfo
{
  public BankAccount Account;
  public Currency Currency;
  public float Amount;

  public CurrencyInfo(BankAccount account, Currency currency, float amount);
}
