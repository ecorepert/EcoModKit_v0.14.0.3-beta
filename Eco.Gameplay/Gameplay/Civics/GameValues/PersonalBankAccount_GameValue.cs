// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.PersonalBankAccount_GameValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Economy;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[Eco.Shared.Networking.Eco(true)]
[Ecopedia(null, "Bank Accounts", false, true, null)]
[LocDisplayName("Personal Bank Account")]
[LocDescription("Target citizen's personal bank account.")]
public class PersonalBankAccount_GameValue : GameValue<BankAccount>
{
  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The user whose personal bank account will be used.")]
  public GameValue<Eco.Gameplay.Players.User> User { get; set; }

  public override LocString Description();

  protected override Eval<BankAccount> Evaluate(IContextObject action);
}
