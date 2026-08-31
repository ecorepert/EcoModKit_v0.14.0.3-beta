// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.ExecutiveActions.CivicAction_PerformExecutiveAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Laws.ExecutiveActions;

[Serialized]
[LocDisplayName("Executive Action")]
[LocDescription("Perform an executive action on each citizen.")]
[LocCategory("Civics")]
[Ecopedia(null, "Executive Actions", false, true, null)]
[Tag("CanBeInConstitution")]
public class CivicAction_PerformExecutiveAction : 
  CivicAction,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  IProvidesContext,
  IFullDescribable,
  IDescribable,
  ICustomValidity,
  IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("A title or short description of the executive action.")]
  public string ExecutiveActionTitle { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Determines which citizens to perform the actions listed in 'Actions on Each Citizen' upon.")]
  [Background("6198C8")]
  [AllowEmpty]
  public ControllerList<GameValue<bool>> CitizenConditions { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The actions to run on each citizen inside this settlement, meeting the 'Citizen Conditions' set above.")]
  [Background("FFE09B")]
  [AllowEmpty]
  public ControllerList<IExecutiveAction> ActionOnEachCitizenInSettlement { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Actions to run once total, separate from actions run on citizens specified above.")]
  [Background("FFE09B")]
  [DontGetContext]
  [AllowEmpty]
  public ControllerList<IExecutiveAction> ActionsToRunOnce { get; set; }

  public IEnumerable<IExecutiveAction> AllActions { get; }

  public override Result CanEdit(User user);

  public override Result Perform(User executingUser, Election election);

  public Result Valid();

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  public override LocString Subject { get; }

  public override LocString Description();

  public LocString FullDescribe();
}
