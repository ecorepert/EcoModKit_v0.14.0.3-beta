// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.LegalActions.RevokeCitizenship_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.LegalActions;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Revoke Citizenship")]
[LocCategory("Citizens")]
[LocDescription("Revoke the citizenship of a player.")]
[RelatedFeature("UseSettlementSystem", true)]
public class RevokeCitizenship_LegalAction : LegalAction
{
  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [Advanced]
  [LocDescription("Player who's citizenship is being revoked.")]
  public GameValue<User> Citizen { get; set; }

  public override LocString Description();

  protected override PostResult Perform(Law law, GameAction context, AccountChangeSet acc);
}
