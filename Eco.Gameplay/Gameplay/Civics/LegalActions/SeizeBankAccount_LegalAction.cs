// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.LegalActions.SeizeBankAccount_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Civics.Laws.ExecutiveActions;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Civics.LegalActions;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Seize Bank Account")]
[LocDescription("Replace managers and users of a bank account.")]
[LocCategory("Finance")]
public class SeizeBankAccount_LegalAction : 
  LegalAction,
  IExecutiveAction,
  IController,
  IViewController,
  IHasUniversalID,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  [HidePermanentAccounts]
  [LocDescription("Managers and users of this bank account will be changed.")]
  public GameValue<BankAccount> TargetAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AllowNullInView]
  [AccessNotNeeded]
  [LocDescription("Who will become the only manager and user of this bank account.")]
  public GameValue<IAlias> NewOwner { get; set; }

  public override LocString Description();

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);

  public PostResult PerformExecutiveAction(
    User user,
    IContextObject action,
    Settlement jurisdictionSettlement,
    AccountChangeSet acc);
}
