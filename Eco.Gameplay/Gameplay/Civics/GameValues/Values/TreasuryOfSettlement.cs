// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.TreasuryOfSettlement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Economy;
using Eco.Gameplay.GameActions;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("The official treasury account of a given settlement.")]
public class TreasuryOfSettlement : GameValue<BankAccount>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The settlement to query the bank account from.")]
  [CanAutoAssign]
  public GameValue<Eco.Gameplay.Settlements.Settlement> Settlement { get; set; }

  public override LocString Description();

  protected override Eval<BankAccount> Evaluate(IContextObject context);
}
