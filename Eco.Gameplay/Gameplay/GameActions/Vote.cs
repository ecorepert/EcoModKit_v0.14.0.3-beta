// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.Vote
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Civics")]
[LocDescription("A citizen voted in an election.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements that the Citizen is a part of, as well as the settlement (and its parents) hosting the election.")]
public class Vote : ElectionAction, IDynamicPreventability
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If they voted for a citizen, this is that player.")]
  public User VotedForUser { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Is this the first time they've voted in the election, or are they changing a previous vote?")]
  public VoteType VoteType { get; set; }

  public static Result CanPreventStatic(LawSection section);

  public Result CanPrevent(LawSection section);
}
