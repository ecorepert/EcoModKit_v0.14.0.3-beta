// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Immigration.InitialSpawnManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Simulation.Time;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics.Immigration;

/// <summary>Class that handles giving players choices where they would like to initially spawn.
/// Provides two sets: procedurally generated spots, based on clusters of resources, and settlements that are accepting new
/// citizens.</summary>
[ChatCommandHandler]
public class InitialSpawnManager : 
  Singleton<
  #nullable disable
  InitialSpawnManager>,
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<
  #nullable enable
  ThreadSafeSubscriptions>,
  ISubscriptions
{
  /// <summary>Invoked when the initial points are regenerated.</summary>
  public 
  #nullable disable
  ThreadSafeAction UpdatedInitialPoints;
  /// Update on this frequency. Can be pretty infrequent
  public PeriodicUpdateConfig UpdateTimer;

  public void Tick();

  public void SetUpdateRequired();

  /// <summary> Called by the client to get the updated spawn points.</summary>
  [RPC]
  public IEnumerable<InitialSpawnPoint> GetSpawnPoints();

  /// <summary>Called by a player when they want to spawn at a given position.</summary>
  [RPC]
  public void StartHere(Player player, InitialSpawnPoint point);

  /// <summary> Generates spawn points. If DisplayOnlySettlements (in the configuration) is true and there are settlements this method will generate only settlements points </summary>
  public void GenerateAllSpawnPoints(bool debugPoints = false);

  /// <summary>Describes the points available for initial spawn.</summary>
  public LocString DescribePoints { get; }

  public LocString SummaryPoints { get; }

  [ChatCommand("Controls initial spawn.", ChatAuthorizationLevel.Admin)]
  public static void InitialSpawn(IChatClient chatClient);

  [ChatSubCommand("InitialSpawn", "Force update the spawn position now.", ChatAuthorizationLevel.Admin)]
  public static void Update(IChatClient chatClient);

  [ChatSubCommand("InitialSpawn", "Generate debug data showing all the clusters we consider for initial points.", ChatAuthorizationLevel.DevTier)]
  public static void UpdateDebug(IChatClient chatClient);

  [ChatSubCommand("InitialSpawn", "Lists the initial spawn positions currently active.", ChatAuthorizationLevel.User)]
  public static void List(IChatClient chatClient);

  [ChatSubCommand("InitialSpawn", "Re-run the initial spawn selection for the given user (or current user if null).", ChatAuthorizationLevel.Admin)]
  public static void Do(IChatClient chatClient, User user = null);

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  [Localized(true, false, "", false)]
  public enum Attractant
  {
    [LocDescription("Pioneers living on homesteads that are not yet part of a town.")] Pioneers,
    [LocDescription("Minerals for mining.")] Mining,
    [LocDescription("Plains for farming.")] Farmlands,
    [LocDescription("Wild food for foraging.")] WildFood,
    [LocDescription("Access to forests for logging.")] Forest,
  }
}
