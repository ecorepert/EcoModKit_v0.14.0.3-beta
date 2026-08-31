// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.UserRoster
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
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
namespace Eco.Gameplay.UI;

/// <summary>A roster maintains a list of users in which both the owner of the list and the user being added need to approve.  It tracks
/// a set of members (externally defined), a set of applicants, and a set of invitees.
/// This is used for membership requirements like residency, classrooms, and citizenship.</summary>
[Serialized]
public class UserRoster : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IRoster,
  IHasClientControlledContainers
{
  public ThreadSafeAction<INetObject, object> MemberAddedEvent { get; }

  public ThreadSafeAction<INetObject, object> MemberRemovedEvent { get; }

  public ThreadSafeAction MembersChangedEvent { get; }

  public event Func<User, Task<bool>>? CanAcceptInviteCallback;

  public event Func<User, Task<bool>>? CanApplyCallback;

  public event Func<User, Task<bool>>? CanLeaveCallback;

  public event Func<User, Player?, Result>? CanBeMember;

  public event Func<User, Task<UserRoster>>? ShouldJoinUponLeaving;

  public event Func<Player, IEnumerable<User>, Task<bool>>? CheckAdminAssign;

  [Serialized]
  [SyncToView(null, true)]
  [ConfirmDelete]
  [LocDescription("Current list of members.")]
  public ControllerHashSet<User> Members { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [ConfirmDelete]
  [LocDescription("List of people who have been invited and can join anytime.")]
  public ControllerHashSet<IAlias> Invited { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [ConfirmDelete]
  [LocDescription("List of people who have applied for membership and can be approved by the owner.")]
  public ControllerHashSet<User> Applicants { get; set; }

  [Serialized]
  public bool ApplicantsAllowed { get; set; }

  [SyncToView(null, true)]
  public LocString Title { get; }

  public LocString ExtraInfo { get; set; }

  ~UserRoster();

  public void SetApprover(IAlias approver);

  /// <summary>Updates the names of the memberships.</summary>
  public void SetDescriptions(LocString memberDesc, LocString memberDescPlural);

  public void Initialize(WorldObject hostObject);

  [SyncToView(null, true)]
  [DependsOn("Approver", new string[] {"ApplicantsAllowed"})]
  public LocString Status { get; }

  [SyncToView(null, true)]
  [DependsOnController("Applicants", true)]
  public bool IsApplicant(User user);

  [RPC]
  [VisibilityParam("IsApplicant")]
  public void RejectApplication(User userSelfCancelling);

  [RPC]
  public void RejectApplication(User userApproving, User deniedUser);

  [SyncToView(null, true)]
  [DependsOnController("Members", true)]
  [DependsOnController("Invited", true)]
  [DependsOnController("Applicants", true)]
  [DependsOnController("ApplicantsAllowed", true)]
  public bool CanApply(User user);

  [RPC]
  [VisibilityParam("CanApply")]
  public void Apply(User user);

  [SyncToView(null, true)]
  [DependsOnController("Approver", true)]
  public bool CanApprove(User user);

  [RPC]
  [VisibilityParam("CanApprove")]
  public void Approve(User userApproving, User userApplicant);

  [SyncToView(null, true)]
  [DependsOnController("Invited", true)]
  public bool CanAcceptInvitation(User user);

  [RPC]
  [VisibilityParam("CanAcceptInvitation")]
  public void AcceptInvitation(User user);

  public void AddToRoster(User? userAdding, User userToAdd, bool sendNotice, bool forceAdd = false);

  [SyncToView(null, true)]
  [DependsOnController("Approver", true)]
  public bool CanInvite(User user);

  [RPC]
  [VisibilityParam("CanInvite")]
  public void Invite(User invitingUser);

  /// <summary> </summary>
  public bool TryInvite(User userInviting, IAlias userInvited, bool notifyInviter = true);

  [SyncToView(null, true)]
  [DependsOnController("Members", true)]
  public bool CanLeave(User user);

  /// <summary>This will make sure to check whether the player should join another roster upon leaving or not.</summary>
  [RPC]
  [VisibilityParam("CanLeave")]
  public void LeaveAndJoinAnotherRoster(User userLeaving, bool notify = true);

  /// <param name="rosterToJoinUponLeaving">If we want the player to join another roster before actually leaving this one then we specifiy this param.</param>
  public void Leave(User userLeaving, bool notify = true, UserRoster? rosterToJoinUponLeaving = null);

  /// <param name="rosterToJoinUponLeaving">In case we want the user to join another roster before leaving this one.</param>
  public bool ForceRemoveMember(User user, UserRoster? rosterToJoinUponLeaving = null);

  public bool RemoveApplicant(User user);

  public bool RemoveInvited(User user);

  [SyncToView(null, true)]
  public bool CanAdminAssign(Player player);

  [RPC]
  [VisibilityParam("CanAdminAssign")]
  public Task AdminAssign(Player player);

  public ref ThreadSafeSubscriptions? Subscriptions { get; }

  public int MemberCount { get; }

  public void SubscribeRosterChange(Action onChanged);

  public event PropertyChangedEventHandler? PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }
}
