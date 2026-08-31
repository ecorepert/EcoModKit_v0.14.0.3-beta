// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.LegalActions.IgnoreAuth_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.LegalActions;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Ignore Authorization")]
[LocDescription("Ignore all authorization restrictions for the triggering action.")]
[LocCategory("Law Enforcement")]
public class IgnoreAuth_LegalAction : LegalAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("When set, this will prompt users with 'Possible access through <law>' when looking at objects they wouldn't otherwise have access to.")]
  public bool PromptCitizensOnInteractions { get; set; }

  public override LocString Description();

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);
}
