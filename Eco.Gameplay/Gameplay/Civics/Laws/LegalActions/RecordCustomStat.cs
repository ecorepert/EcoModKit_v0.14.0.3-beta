// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LegalActions.RecordCustomStat
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.Laws.LegalActions;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Statistics")]
[LocDescription("Record a custom stat of your choosing. Will be stored under the settlement that runs this law's stat folder.")]
public class RecordCustomStat : LegalAction, ICustomValidity, IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The name of the stat that will be recorded, creating it if it doesn't exist. Case insensitive.")]
  public string StatName { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Person to associate with this recording of the stat (optional)")]
  [AllowNullInView]
  public GameValue<User> Person { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Count associated with this event (optional, defaults to 1).")]
  [AllowNullInView]
  public GameValue<float> Count { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If set, the stat recording will appear in an infobox displayed briefly on the screen when triggered by a citizen.")]
  public bool DisplayResultToCitizen { get; set; }

  public override LocString Description();

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);

  public Result Valid();
}
