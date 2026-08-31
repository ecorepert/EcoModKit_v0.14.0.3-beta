// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.CivicAction_StartCandidateElection
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
[LocDisplayName("Start Candidate Election")]
[LocDescription("Begin an election for a government office.")]
[LocCategory("Elections")]
[Ecopedia(null, "Elections", false, true, null)]
[DoesNotNeedCivicArticle]
public class CivicAction_StartCandidateElection : CivicAction
{
  [Eco.Shared.Networking.Eco(true)]
  [SettlementOnly]
  [ActiveOnly]
  public ElectedTitle Position { get; set; }

  /// <summary>This is overriden to false for this action because this action invokes another global <see cref="M:Eco.Gameplay.Players.Player.OkBox(Eco.Shared.Localization.LocString)" /> that is tailored for elections.</summary>
  public override bool NotifyOnPerform { get; }

  public override void ValidateParamsOnSubmit();

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election proposingElection);

  public override LocString Description();
}
