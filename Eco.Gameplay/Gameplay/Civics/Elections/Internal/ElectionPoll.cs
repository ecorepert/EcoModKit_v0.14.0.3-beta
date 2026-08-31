// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.Internal.ElectionPoll
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics.Elections.Internal;

/// <summary>Funcs for creating a poll election.</summary>
public static class ElectionPoll
{
  /// <summary>Query the user for and create an election polling the userbase.</summary>
  public static void CreatePollElection(User user);

  [Eco.Shared.Networking.Eco(true)]
  public class PollOption : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
  {
    [Eco.Shared.Networking.Eco(true)]
    public string Name { get; set; }

    [DoNotNotify]
    public ref int ControllerID { get; }

    public event PropertyChangedEventHandler PropertyChanged;
  }

  [LocDisplayName("Start Poll")]
  [LocDescription("Start a poll, which does not have any world effects but can be used for making decisions as a group.")]
  [DoesNotNeedCivicArticle]
  [Serialized]
  public class CivicAction_StartPoll : 
    CivicAction,
    IHasClientControlledContainers,
    IController,
    IViewController,
    IHasUniversalID
  {
    [Eco.Shared.Networking.Eco(true)]
    [Range(3f, 50f)]
    public string ElectionTitle { get; set; }

    [Eco.Shared.Networking.Eco(true)]
    public string PollQuestion { get; set; }

    [Eco.Shared.Networking.Eco(true)]
    [HideRootListEntry]
    public ControllerList<ElectionPoll.PollOption> PollOptions { get; set; }

    [Eco.Shared.Networking.Eco(true)]
    [LocDescription("The election process that conducts the poll.")]
    [SettlementOnly]
    public ElectionProcess ProcessToUse { get; set; }

    [Eco.Shared.Networking.Eco(true)]
    [LocDescription("If set, allow early completion when enough people have voted.")]
    public bool AllowEarlyEndWithEnoughVotes { get; set; }

    public override bool NotifyOnPerform { get; }

    public override Result CanExecute(User user);

    /// <summary>Start an election with the given properties.</summary>
    public override Result Perform(User user, Election proposingElection);

    public override LocString Description();
  }

  [LocDisplayName("Start Poll")]
  [LocDescription("Start a poll, which does not have any world effects but can be used for making decisions as a group.")]
  [DoesNotNeedCivicArticle]
  [Serialized]
  [Eco.Shared.Networking.Eco(true)]
  public class CivicAction_FinishPoll : CivicAction
  {
    [Serialized]
    public string PollQuestion;

    public override LocString Description();

    public override Result Perform(User user, Election election);

    public override LocString ElectionStarted(User user, Election election);

    public override LocString Failed(User user);
  }
}
