// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Trackers.ExchangeRate
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Trackers;

public class ExchangeRate
{
  public static readonly string[] ExchangeTypeNames;

  [SyncToView(null, true)]
  public Currency Currency1 { get; set; }

  [SyncToView(null, true)]
  public Currency Currency2 { get; set; }

  [SyncToView(null, true)]
  public double[] Rates { get; set; }

  public CurrencyPair Pair { get; }

  public static ExchangeRate Average(IEnumerable<ExchangeRate> list);

  public Currency OtherCurrency(Currency cur);

  public double GetRate(Currency cur, ExchangeType exchangeType);
}
