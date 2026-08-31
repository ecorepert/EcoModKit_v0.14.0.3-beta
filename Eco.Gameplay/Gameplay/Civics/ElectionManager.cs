// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.ElectionManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics;

[Serialized]
public class ElectionManager : 
  Singleton<
  #nullable disable
  ElectionManager>,
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers
{
  public IEnumerable<Election> ElectionDrafts(Settlement settlement);

  public IEnumerable<Election> CurrentElections(Settlement settlement);

  public IEnumerable<Election> OldElections(Settlement settlement);

  [SyncToView(null, true)]
  public IEnumerable<Election> HighlightedElections(Player player);

  public void ChooseElectionToAttachTo(
    User user,
    ElectionProcess process,
    CivicAction actionPerformed,
    bool force = false,
    Election forceElection = null);

  public Election CreateAndStartElectionForPosition(
    User user,
    Settlement settlement,
    ElectedTitle position);

  public Election NewElection(
    User user,
    Settlement settlement,
    ElectionProcess process,
    string name = null,
    bool debugElection = false);

  public Result CanStartForActions(User user, Election election);

  public Result CanStartElectionForPosition(User user, ElectedTitle position);

  public Result CanJoinElection(User user, Election election);

  public void FastTick();

  public void Initialize();

  public void CancelDraftElection(Player player, Election election);

  public void RemoveProposableFromDraftElections(IProposable target);

  public ref int ControllerID { get; }
}
