// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementCitizenship
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Players;
using Eco.Gameplay.UI;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>Tracks the citizens of a settlement using a Roster type, so new citizens can apply/be invited/accepted/etc.</summary>
/// <remarks>Also tracks the number of claims and stakes that get spawned as population increases.                      </remarks>
[Serialized]
public class SettlementCitizenship : 
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Serialized]
  public 
  #nullable disable
  ThreadSafeDictionary<User, double> UserRemovalTimers;

  [Notify]
  public ThreadSafeAction CitizensChangedEvent { get; set; }

  public static ThreadSafeAction<Settlement> CitizensChangedGlobalEvent { get; set; }

  public static ThreadSafeAction<HashSet<User>, Settlement> BecameCitizenEvent { get; set; }

  public static ThreadSafeAction<HashSet<User>, Settlement> LeftCitizenshipEvent { get; set; }

  public static ThreadSafeAction<User, Settlement, bool> CitizenshipChanged { get; set; }

  public static void WatchUserCitizenshipChanged(User user, Action action);

  [Serialized]
  public UserRoster DirectCitizenRoster { get; }

  [Serialized]
  public ThreadSafeDictionary<User, TimeLog> CitizenTimes { get; set; }

  /// <summary>Setup citizenship management for a settlement</summary>
  internal void Initialize(Settlement settlement, Demographic citizenship);

  public bool RemoveCitizenNonVoluntarily(User user);

  public void UpdateName();

  public int CitizenCount { get; }

  public int ActiveCitizenCount { get; }

  public bool HasCitizen(User user);

  public bool HasDirectCitizen(User user);

  public ThreadSafeHashSet<User> AllCitizens { get; }

  public IEnumerable<User> NonAbandonedCitizens { get; }

  public IEnumerable<User> AbandonedCitizens { get; }

  /// <summary>Event to update our citizens in any roster, as well as citizens in our children settlements.</summary>
  public void QueueCitizensCacheUpdate();

  /// <summary>Citizens added by the change currently being broadcast. Only set while the events fired from <see cref="M:Eco.Gameplay.Settlements.SettlementCitizenship.UpdateCitizenCache" /> run; empty for unrelated triggers like recounts.</summary>
  public IReadOnlyList<User> LastJoinedCitizens { get; }

  public bool RemoveCitizen(User user);

  public void RemoveAllDirectCitizens(
    bool joinParentUponLeaving,
    IEnumerable<User> usersToKeep = null,
    bool forceRemove = false);

  public void FastTick();

  public void Destroy();

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  private enum ApplyOrJoin
  {
    Apply,
    Join,
  }
}
