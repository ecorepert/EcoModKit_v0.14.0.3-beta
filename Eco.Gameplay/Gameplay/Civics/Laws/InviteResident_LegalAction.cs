// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.InviteResident_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Laws.ExecutiveActions;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Civics.Laws;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Invite Resident")]
[LocCategory("Property")]
[LocDescription("Add a given citizen or group to 'Invited Residents' on a property.")]
public class InviteResident_LegalAction : 
  LegalAction,
  IExecutiveAction,
  IController,
  IViewController,
  IHasUniversalID,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen or group to invite to assign the property.")]
  [CanAutoAssign]
  [AccessNotNeeded]
  public GameValue<IAlias> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen will be invited to become a resident on the property at this location which must be within the influence of the current settlement.")]
  [CanAutoAssign]
  public GameValue<Vector3i> PropertyLocation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Should the citizen be invited or should the invite be rescinded?.")]
  public InviteOrRescind InviteOrRescind { get; set; }

  public override LocString Description();

  public PostResult PerformExecutiveAction(
    User user,
    IContextObject context,
    Settlement jurisdictionSettlement,
    AccountChangeSet acc);

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);
}
