// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.CurrencyManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy;

public static class CurrencyManager
{
  public static 
  #nullable disable
  ConcurrentDictionary<string, Currency> UsernameToCurrency;

  public static Eco.Core.Systems.Registrar<Currency> Registrar { get; }

  public static IEnumerable<Currency> Currencies { get; }

  public static Currency GetPlayerCurrency(User user);

  public static Currency GetPlayerCurrency(string name);

  public static void Initialize();

  public static Currency AddCurrency(User user, string currencyName, CurrencyType currencyType);

  public static void CurrencyReport(Player player, Currency currency);

  public static Currency GetClosestCurrency(string currencyName);

  public static LocString PlayerCreditName(string username);

  public static IEnumerable<Debt> DebtsForUser(User user);

  public static void TryCreatePersonalCurrency(User user);
}
