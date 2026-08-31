// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.LegalActions.ChangeReputation_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Civics.Laws.ExecutiveActions;
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
[LocDisplayName("Change Reputation")]
[LocDescription("Change the reputation for a user, given from the settlement issuing the law (Settlements have a limit of reputation they can give, shown in ecopedia settings).")]
[LocCategory("Communication")]
[CannotBePrevented]
public class ChangeReputation_LegalAction : 
  LegalAction,
  IExecutiveAction,
  IController,
  IViewController,
  IHasUniversalID,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("How much to change the target's reputation by.  Unlike normal reputation changes, this has no limit. Use with care!")]
  [NegativeAllowed]
  public GameValue<float> ReputationChange { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("A message to be attached to the reputation change.")]
  public string ReputationMessage { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The citizen to change reputation for.")]
  public GameValue<User> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Send a notice in the world news panel upon grant.")]
  public bool SendNotice { get; set; }

  public override LocString Description();

  public PostResult PerformExecutiveAction(
    User user,
    IContextObject context,
    Settlement jurisdictionSettlement,
    AccountChangeSet acc);

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);
}
