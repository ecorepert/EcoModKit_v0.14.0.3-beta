// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Trackers.ExchangeRates
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy.Trackers;

[Serialized]
public class ExchangeRates : IController, IViewController, IHasUniversalID
{
  public ref int ControllerID { get; }

  public 
  #nullable disable
  ExchangeRate GetExchangeRate(Currency c1, Currency c2);

  public IEnumerable<ExchangeRate> GetExchangeRates(Currency currency);

  public string DescribeRatesForCurrency(Currency cur, ExchangeType exchangeType = ExchangeType.SellPrices);

  public void UpdateRates(IEnumerable<TradeTracker> allTrades);
}
