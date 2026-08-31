// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.LegalActions.SendNotice
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
namespace Eco.Gameplay.Civics.LegalActions;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("Send a custom notice to a set of people.")]
[LocCategory("Communication")]
public class SendNotice : 
  LegalAction,
  IExecutiveAction,
  IController,
  IViewController,
  IHasUniversalID,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The text to send.")]
  public string Message { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Affects where the message will be displayed.")]
  public NotificationType NotificationType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [LocDescription("The people to send to.")]
  public GameValue<IAlias> PeopleToSendTo { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("An optional custom value to display at the end of the notice.")]
  [AllowNullInView]
  public GameValue<float> ValueToDisplay { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("An optional custom value to link a location.")]
  [AllowNullInView]
  public GameValue<Vector3i> LocationToDisplay { get; set; }

  public override LocString Description();

  public PostResult PerformExecutiveAction(
    User user,
    IContextObject context,
    Settlement jurisdictionSettlement,
    AccountChangeSet acc);

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);
}
