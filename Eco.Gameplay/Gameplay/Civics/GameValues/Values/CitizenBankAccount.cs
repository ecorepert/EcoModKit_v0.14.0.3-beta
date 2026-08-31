// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.CitizenBankAccount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Economy;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Citizens")]
[LocDescription("The personal (default) bank account of a citizen.")]
public class CitizenBankAccount : GameValue<BankAccount>
{
  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The citizen whose personal bank account to get.")]
  [CanAutoAssign]
  public GameValue<User> Citizen { get; set; }

  protected override Eval<BankAccount> Evaluate(IContextObject action);

  public override LocString Description();
}
