// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.CivicAction_Vote
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable enable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
[LocDisplayName("Vote")]
[LocDescription("Vote for a candidate in an election.")]
[LocCategory("Elections")]
[CivicActionOnClick]
[Ecopedia(null, "Elections", false, true, null)]
[DoesNotNeedCivicArticle]
public class CivicAction_Vote : 
  CivicAction,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Eco.Shared.Networking.Eco(true)]
  [SettlementOnly]
  public 
  #nullable disable
  Election Election { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public ControllerList<VoteChoice> Choices { get; set; }

  public static void OnClicked(User user);

  public void SetupElection();

  public override Result CanEdit(User user);

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election election);

  public override LocString Description();

  internal void ForceVote(bool forceYesVote);

  internal void Randomize();

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
