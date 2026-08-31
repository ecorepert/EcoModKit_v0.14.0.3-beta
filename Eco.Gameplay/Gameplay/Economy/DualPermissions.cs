// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.DualPermissions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Economy;

/// <summary>A dual-permissions object handles two sets of permissions: users and managers. Permissions are set by managers, and users cannot change permissions.</summary>
[Serialized]
public class DualPermissions : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IHasClientControlledContainers,
  IRPCAuthChecks,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public 
  #nullable disable
  ThreadSafeAction<IEnumerable<User>> ManagerSetChangedEvent;
  public ThreadSafeAction<IEnumerable<User>> UserSetChangedEvent;
  public ThreadSafeAction PermissionsChangedEvent;
  public Func<Player, IAlias, PermissionsType, bool> OnTryRemove;
  public Func<Player, IAlias, PermissionsType, bool> OnTryAdd;
  public Func<Player, IEnumerable<IAlias>, bool> OnTrySet;

  [Serialized]
  [SyncToView(null, true)]
  [ScanProp]
  [ClientCanSelectAndAdd("Select Managers", "Manager", "Managers", true)]
  [IgnoreValidity]
  [AllowEmpty]
  public ControllerAliasSet ManagerSet { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [ScanProp]
  [ClientCanSelectAndAdd("Select Users", "User", "user", true)]
  [IgnoreValidity]
  [AllowEmpty]
  public ControllerAliasSet UserSet { get; set; }

  public IEnumerable<IAlias> AllAliases { get; }

  public IEnumerable<User> AllUsers { get; }

  public IEnumerable<User> AllManagers { get; }

  public IEnumerable<User> AllNormalUsers { get; }

  [SyncToView(null, true)]
  public AccountAccess AccessType(Player player);

  public AccountAccess AccessType(User user);

  public bool VerifyCanAdd(Player player, IClientControlledContainer container, object obj);

  public virtual void Initialize(
    LocString managementTitle,
    LocString userTitle,
    Func<LocString> markedUpName);

  /// <summary> Verify if the player and the new set can be set to the container. </summary>
  public Task<Result> VerifyNewSetIsValid(
    Player player,
    IClientControlledContainer container,
    IEnumerable<object> newSet);

  public void Destroyed();

  public Task<Result> VerifyCanRemove(
    Player player,
    IClientControlledContainer container,
    object obj);

  public bool InList(User user, AccountAccess access);

  public bool CanAccess(IAlias alias, AccountAccess access = AccountAccess.Use, bool sendNoticeOnFail = false);

  bool IRPCAuthChecks.IsRPCAuthorized(
    IWorldObserver observer,
    Eco.Shared.Items.AccessType requiredAccess,
    object[] args);

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
