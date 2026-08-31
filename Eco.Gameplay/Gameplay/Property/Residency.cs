// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.Residency
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Rooms;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Property;

[Eco.Shared.Networking.Eco(true)]
public class Residency : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers,
  IProvidesContext,
  INotifyPropertyChanged,
  IRPCAuthChecks
{
  public static 
  #nullable disable
  ThreadSafeAction<Deed> ResidencyStatusChangedEvent;
  public static ThreadSafeAction<Room, User> ResidencyValueNeedsUpdateEvent;
  [Serialized]
  public RentForProperty RentForProperty;

  public event PropertyChangedEventHandler PropertyChanged;

  [Eco.Shared.Networking.Eco(true)]
  [ConfirmDelete]
  [LocDescription("A list of residents on this property. Residents gain points from housing values, and only private property can have residents.")]
  public ControllerHashSet<User> Residents { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("A list of citizens and demographics that may join as residents. Only the owner of the property can set this list.")]
  public Invitations Invitations { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Number of occupants allowed.")]
  public GameValue<float> MaxOccupants { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If checked, the owner of this deed may unclaim plots on the deed while you're a resident.")]
  public bool AllowPlotsUnclaiming { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  [Serialized]
  public Deed ParentDeed { get; }

  [SyncToView(null, true)]
  [DependsOnController("Residents", true)]
  public LocString ResidentsShortDescription { get; }

  /// <summary> Attempts to destroy the Residency objects. </summary>
  public GameActionPack TryDestroy(GameActionPack pack, ResidencyChangeReason reason);

  public void Destroy();

  internal static void DrainDirtyResidencies();

  public void Initialize(Deed parentDeed, Func<User, bool> isOwner);

  public void DebugForceEvict(User user);

  public bool DebugForceResidency(User user);

  public static bool IsResident(User user, Deed deed);

  public static Deed GetHouseResidency(User user);

  public static ThreadSafeList<Deed> GetAllResidentDeeds(User user);

  /// <summary> Returns any deed rented by user, which have any plot. </summary>
  public static Deed GetResidencyDeed(User u);

  /// <summary>Sets visibility of the accept-invite button.</summary>
  [SyncToView(null, true)]
  public bool CanBecomeResident(User user);

  /// <summary>RPC version of BecomeResident method. May require confirmation.</summary>
  [RPC(AccessType.None)]
  [VisibilityParam("CanBecomeResident")]
  public Task<bool> BecomeResident(Player player);

  /// <summary>Simplified version of become resident method which doesn't ask any confirmation and usually initiated by automated workflows (i.e. first deed creation, deed removal etc).</summary>
  public bool BecomeResidentOfOwnResidency(User user, ResidencyChangeReason reason = ResidencyChangeReason.OwnerTakingResidence);

  [RPC(RequiredAccess = AccessType.None)]
  [VisibilityParam("CanLeaveResidency")]
  public Task LeaveResidency(Player player);

  public Task<Result> VerifyCanRemove(
    Player player,
    IClientControlledContainer container,
    object obj);

  public void ForceAdd(IEnumerable<User> users);

  public void ForceClear();

  [DependsOnController("Residents", true)]
  public bool CanLeaveResidency(Player player);

  public void OnOwnerChanged(OwnerChangeType changeType);

  public void OnPropertyValueChanged();

  bool IRPCAuthChecks.IsRPCAuthorized(
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);

  public ref int ControllerID { get; }

  [Flags]
  private enum PendingChanges
  {
    CanBecomeResident = 1,
    ResidentsShortDescription = 2,
  }
}
