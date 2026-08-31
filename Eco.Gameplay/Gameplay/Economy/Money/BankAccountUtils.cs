// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Money.BankAccountUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Economy.Money;

/// <summary>Functions for accessing and manipulating bank accounts</summary>
public static class BankAccountUtils
{
  public static 
  #nullable disable
  IEnumerable<BankAccount> GetNonGovernmentAccountsAccessibleToUser(User user, Currency currency);

  /// <summary>Presents a dialog for the user to choose a bank account.  If only one, automatically chooses it.</summary>
  public static Task<BankAccount> AskUserForBankAccount(User user, LocString? title = null);
}
