// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using ConcurrentCollections;
using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;
using StrangeCloud.Service.Client.Contracts;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>Singleton instance containing all the users in the game, logged in or not.</summary>
[LocDisplayName("UserManager")]
public sealed class UserManager : 
  Eco.Simulation.Simulation,
  ICategory,
  INamed,
  IController,
  IViewController,
  IHasUniversalID,
  IWorkerPlugin,
  IServerPlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IConfigurablePlugin,
  IEditablePlugin,
  ISaveablePlugin,
  IInitializablePlugin,
  IDisposable,
  IThreadedPlugin,
  IShutdownablePlugin
{
  public Registrar<User> UserRegistrar;
  public static ThreadSafeAction<User> OnUserLoggedIn;
  public static ThreadSafeAction<User> OnUserLoggedOut;
  public static ThreadSafeAction<User> NewUserJoinedEvent;
  public static ThreadSafeAction ManagerInitializedEvent;
  internal static ConcurrentDictionary<string, User> UsersBySteamID;
  internal static ConcurrentDictionary<string, User> UsersBySLGID;
  internal static ConcurrentDictionary<string, User> UsersByEntityId;
  public static ConcurrentHashSet<User> OnlineUsers;
  public static readonly Initializer Initializer;
  /// <summary> Minimum User name length accepted, different from other Registrars value, see <see cref="T:Eco.Core.Systems.RegistrarConstants" /> </summary>
  public static readonly int MinUserNameLength;

  public Type ContainedType { get; }

  public IHasID GetById(int id);

  public IHasID GetByName(string name);

  public LocString RegistrarName { get; }

  public static IEnumerable<string> Usernames { get; }

  public static IEnumerable<User> Users { get; }

  public static IEnumerable<User> Admins { get; }

  [SyncToView(null, true)]
  public int OnlineUserCount { get; }

  [SyncToView(null, true)]
  public int TotalUserCount { get; }

  /// <summary><see cref="T:System.Linq.Enumerable" /> containing all currently logged in users with Twitch integration enabled.</summary>
  public static IEnumerable<User> TwitchUsers { get; }

  /// <summary>Total number of Twitch enabled users currently logged into the server.</summary>
  public static int TwitchStreamerCount { get; }

  public static LocString UILink(string username, LocString? defaultVal = null);

  public static LocString MarkUpName(string username, LocString? defaultVal = null);

  public static UserConfig Config { get; }

  public static bool RequireAuthentication { get; set; }

  public IPluginConfig PluginConfig { get; }

  public static UserManager Obj { get; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public bool ShouldKickAFKUsers { get; }

  [SyncToView(null, true)]
  public float TimeRequiredForAFKSeconds { get; }

  [SyncToView(null, true)]
  public IEnumerable<INamed> Entries { get; }

  ref int IHasUniversalID.ControllerID { get; }

  /// <summary>Creates temp user management for time while action is running. Mainly for testing purposes.</summary>
  /// <param name="action">action to be executed with temp legislation.</param>
  public static void WithTempUserManager(Action action);

  public void Dispose();

  public void Initialize(TimedTask timer);

  public void Run();

  public Task ShutdownAsync();

  public static Action<User> OnPlayerDefaultsChanged { get; set; }

  public static Action<User> OnPlayerSkillsChanged { get; set; }

  public static Action<User> OnPlayerStatsChanged { get; set; }

  /// <summary> Gets user names of real players, not test users </summary>
  [RPC]
  public List<string> GetUserNames();

  public void RefreshUserData();

  public static User FindUserByName(string username);

  public static User FindUserByAccount(StrangeUser account);

  public static User FindUserById(Guid strangeId, string steamId, string slgId);

  public static User FindUserBySteamId(string steamId);

  public static User FindUserBySlgId(string slgId);

  public static User FindUserByStrangeId(Guid strangeId);

  public static User FindUserByStrangeId(string strangeId);

  public static User FindUserByID(int handle);

  public static User FindUser(string anything, out UserIdType type);

  public static User FindUser(string anything);

  public User CreateNewUser(StrangeUser strangeUser, string username);

  public static User GetOrCreateUser(StrangeUser strangeUser, string username);

  /// <summary>Get or create a new spawn point.</summary>
  public static Vector3 GetOrRelocateSpawnPosition();

  public string GetDisplayText();

  public object GetEditObject();

  public string GetStatus();

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public void OnEditObjectChanged(object o, string param);

  public void ResetUser(User user);

  public Task DoWork(CancellationToken token);

  public string GetCategory();

  public override string ToString();

  public void SaveAll();

  public void UserLoggedOut(User user);

  /// <summary>Checks if an incoming StrangeUser instance is authorized to connect.</summary>
  public bool AuthorizeClientConnection(StrangeUser session);
}
