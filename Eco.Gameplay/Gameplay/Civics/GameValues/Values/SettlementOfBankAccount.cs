// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.SettlementOfBankAccount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Settlements")]
[LocDescription("Gets the settlement associated with a given bank account.")]
public class SettlementOfBankAccount : GameValue<Settlement>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account to check.")]
  [CanAutoAssign]
  public GameValue<Eco.Gameplay.Economy.BankAccount> BankAccount { get; set; }

  public override LocString Description();

  protected override Eval<Settlement> Evaluate(IContextObject context);
}
