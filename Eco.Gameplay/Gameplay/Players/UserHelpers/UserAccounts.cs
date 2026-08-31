// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserHelpers.UserAccounts
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Money;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Players.UserHelpers;

[Serialized]
public class UserAccounts : 
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IDualPermissionManager,
  IHasClientControlledContainers
{
  [SyncToView(null, true)]
  public 
  #nullable disable
  IEnumerable<AppointedTitle> ManagedTitles { get; }

  [SyncToView(null, true)]
  public IEnumerable<Title> AssignedTitles { get; }

  [SyncToView(null, true)]
  public IEnumerable<BankAccount> AccessibleAccounts { get; }

  [SyncToView(null, true)]
  public IEnumerable<BankAccount> ManagedAccounts { get; }

  [SyncToView(null, true)]
  public ControllerHashSet<Settlement> HasGovernmentBankingPrivileges { get; set; }

  /// <summary>Settlements that have given us special permission to claim in their territory along.</summary>
  [SyncToView(null, true)]
  public ControllerHashSet<Settlement> CanExpandClaimsInSettlementsInfluence { get; set; }

  public static void Tick();

  public void Initialize(User user);

  public Eco.Core.Systems.Registrar<Title> Registrar { get; }

  LocString[] IDualPermissionManager.RandomTitles { get; }

  IRegistrar IDualPermissionManager.Registrar { get; }

  public Type TypeToAdd(Player creator, string listName);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
