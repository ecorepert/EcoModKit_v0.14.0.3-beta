// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Transaction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy;

[Serialized]
public class Transaction
{
  [Serialized]
  public string CachedString;
  public const int EmBaseSize = 18;

  [Serialized]
  public double Time { get; set; }

  [Serialized]
  public BankAccount Target { get; set; }

  [Serialized]
  public Currency Currency { get; set; }

  [Serialized]
  public string Description { get; set; }

  [Serialized]
  public float Amount { get; set; }

  [Serialized]
  public float NewBalance { get; set; }

  public Transaction();

  public Transaction(
    Currency currency,
    BankAccount target,
    float amount,
    float newBalance,
    string description);

  public void BuildCachedString();

  public override string ToString();

  public static string BuildString(
    string time,
    string transfer,
    string currency,
    string target,
    string balance,
    string description);
}
