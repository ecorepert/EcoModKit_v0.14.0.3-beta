// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.LegalActions.ChangePropertyOwner_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.GameValues.PropertyValues;
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
[LocDisplayName("Change Property Owner")]
[LocCategory("Property")]
[LocDescription("Change the owners of a set of property. May only target deeds within jurisdication.")]
public class ChangePropertyOwner_LegalAction : 
  LegalAction,
  IExecutiveAction,
  IController,
  IViewController,
  IHasUniversalID,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The properties that their owners will be changed, which needs to be inside the current settlement.")]
  public PropertySet Property { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [AllowNullInView]
  [LocDescription("The owner to assign the property. Leave blank to remove the owner and unclaim the property.")]
  public GameValue<IAlias> NewOwner { get; set; }

  public string OwnerDesc { get; }

  public override LocString Description();

  public PostResult PerformExecutiveAction(
    User user,
    IContextObject context,
    Settlement jurisdictionSettlement,
    AccountChangeSet acc);

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);
}
