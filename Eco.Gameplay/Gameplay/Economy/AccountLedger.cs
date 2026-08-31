// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.AccountLedger
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy;

[Serialized]
public class AccountLedger
{
  [Serialized]
  public ThreadSafeLimitedHistory<Transaction> Transactions { get; }

  public BankAccount Account { get; }

  public void SetAccount(BankAccount account);

  public static void AddOneWayTransaction(
    BankAccount from,
    BankAccount to,
    Currency cur,
    float amount,
    string desc);

  public string RenderToText();
}
