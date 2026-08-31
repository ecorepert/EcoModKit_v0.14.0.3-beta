// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.LegalActions.Prevent_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.LegalActions;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Prevent")]
[LocDescription("Prevents the triggering action from happening.")]
[LocCategory("Law Enforcement")]
public class Prevent_LegalAction : LegalAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Optional text that will be displayed to the citizen upon prevention.")]
  [AllowNullInView]
  public string DisplayText { get; set; }

  public override LocString Description();

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);
}
