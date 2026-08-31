// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.Deed
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Culture;
using Eco.Gameplay.Economy.Reputation;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Rooms;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using PropertyChanged;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Property;

[Serialized]
public class Deed : 
  SimpleEntry,
  IOwnerChangeable,
  IOwned,
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers,
  IRPCAuthChecks,
  IAnnexable,
  INamed,
  IHasReputation,
  IReputationAssociated,
  IGeneratesCulture
{
  public 
  #nullable disable
  ThreadSafeList<Room> Rooms;
  [Serialized]
  public Settlement ForceSettlement;
  public bool Destroying;

  [Notify]
  public static ThreadSafeAction<Deed, IOwnableHandle, bool> OwnedObjectChangedEvent { get; }

  [Notify]
  public static ThreadSafeAction<Deed> OwnerUserSetChangedEvent { get; }

  [Notify]
  public static ThreadSafeAction<Deed> DeedRenamedEvent { get; }

  [Notify]
  public static ThreadSafeAction<Deed> OwnedObjectRenamedEvent { get; }

  [Notify]
  public static ThreadSafeAction<Deed> OwnerRenamedEvent { get; }

  [Notify]
  public static ThreadSafeAction<Deed> PropertyValueChangedEvent { get; }

  [Notify]
  public ThreadSafeAction<OwnerChangeType> OwnerChangedEvent { get; }

  [Notify]
  public ThreadSafeAction NameChangedEvent { get; }

  [Notify]
  public ThreadSafeAction ChangedEvent { get; }

  [Notify]
  public ThreadSafeAction ResidentsChangedEvent { get; }

  [SyncToView(null, true)]
  [Serialized]
  public int AllowedPlots { get; set; }

  [SyncToView(null, true)]
  [DependsOnController("OwnedObjects", true)]
  public int PlotCount { get; }

  [SyncToView(null, true)]
  public HashSet<PlotPos> PlotPosSet { get; }

  [Eco.Shared.Networking.Eco(true)]
  [ScanProp]
  [ClientCanSelectAndAdd("Select Citizens and Groups who may Access This Property.", "Accessor", "Accessors", true)]
  [AccessNotNeeded]
  [AllowEmpty]
  public ControllerHashSet<IAlias> Accessors { get; }

  [Serialized]
  [Notify]
  public ControllerHashSet<IOwnableHandle> OwnedObjects { get; }

  [Eco.Shared.Networking.Eco(true)]
  public IAlias Owner { get; }

  [Notify]
  public ControllerDictionary<string, LocString> WarningsDescription { get; }

  [SyncToView(null, true)]
  [DependsOn("Owner")]
  [ScanProp]
  public IAlias Owners { get; set; }

  [SyncToView(null, true)]
  public Eco.Shared.Items.AccessType AccessType(User user);

  public bool IsAuthorized(User user, Eco.Shared.Items.AccessType accessType);

  bool IRPCAuthChecks.IsRPCAuthorized(
    IWorldObserver observer,
    Eco.Shared.Items.AccessType requiredAccess,
    object[] args);

  [Serialized]
  [SyncToView(null, true)]
  [LocDescription("Defines the type of property and what effects the rooms and furniture have. See Ecopedia.")]
  [OnChangedMethod("OnDeedPropertyTypeChanged")]
  [RelatedFeature("CultureEnabled", true)]
  public PropertyType DeedPropertyType { get; set; }

  [Serialized]
  [Notify]
  public WorldObjectHandle HostObject { get; set; }

  [SyncToView(null, true)]
  public Vector3i HostObjectPosition { get; }

  [SyncToView(null, true)]
  [Serialized]
  [AutoRPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  public Color Color { get; set; }

  [SyncToView(null, true)]
  [AutoRPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  public override string Name { get; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  public bool PrivateDining { get; set; }

  /// <summary>The value of this deed, based on its type.</summary>
  [SyncToView(SyncFlags.MustRequest)]
  public PropertyValue PropertyValue { get; set; }

  [Serialized]
  public float PropertyValueBoost { get; set; }

  [Notify]
  public bool IsAbandoned { get; set; }

  [Notify]
  public Room OutdoorRoom { get; set; }

  [WatchSubMember("Residents", "ResidentsChangedEvent", SubPropWatcherFlag.None)]
  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public Residency Residency { get; set; }

  [SyncToView(null, true)]
  [DependsOn("Residency")]
  [NewTooltipChildren(CacheAs.Instance)]
  public RentForProperty Rent { get; }

  [Notify]
  public Vector3i? CachedCenterPos { get; }

  public float CachedMaxRadius { get; }

  /// <summary>Return the settlement influencing this position, by looking at the components on the stake. Can be a settlement stake, a foundation, or a homestead stake.</summary>
  [SyncToView(null, true)]
  public Settlement CachedInfluencingSettlement { get; }

  [Notify]
  public Settlement CachedOwningSettlement { get; }

  /// <summary>True if claimed land on this plot is locked to the settlement assigned only.</summary>
  [SyncToView(null, true)]
  [DependsOn("CachedInfluencingSettlement")]
  public bool BlockChildInfluence { get; }

  public IEnumerable<Settlement> IndirectInfluencingSettlements { get; }

  [Serialized]
  ThreadSafeDictionary<int, int> IAnnexable.SettlementIDtoAnnexWarningIssued { get; set; }

  [Notify]
  public ValResult<float> CachedCultureValue { get; set; }

  [Notify]
  [Serialized]
  public float CultureBoostFromAdmin { get; set; }

  /// <summary>This function allow us to add and remove warnings from the deed while at the same time sending a warning for all owners as mail the first time it gets added.</summary>
  public void UpdateWarnings(bool add, string title, LocString? description = null, bool notify = true);

  /// <summary>We get all the warnings in a single LocString.</summary>
  public LocString GetWarningsDescription();

  public bool IsOverburdened { get; }

  public override LocString CreatorText(Player reader);

  /// <summary>Update what settlement is associated with this deed. This can change when a homemstead component changes allegiances.</summary>
  public void UpdateInfluencingSettlement();

  /// <summary>Is this deed claimed via a homestead claim stake?</summary>
  [SyncToView(null, true)]
  public bool IsHomesteadDeed { get; }

  public bool IsVehicleDeed { get; }

  /// <summary>Sets the host object, the placed claim stake or foundation that allows the deed to claim property.</summary>
  public void ChangeHostObject(WorldObject obj, bool sendNotice = true);

  public void DebugSetInfluencingSettlement(Settlement settlement);

  public void OnCreate();

  /// <summary>Verify property change is valid and apply it if so, or inform user why not if not.</summary>
  [RPC]
  public void SetDeedPropertyType(Player player, PropertyType value);

  /// <summary>Force changing the property type, clearing residents as needed.</summary>
  public void ForceDeedPropertyType(PropertyType type);

  public void Destroy();

  public override void Destroyed();

  public void OnRenamed(string oldName);

  public void RaisePropertyValueChangedEvent();

  public void RaiseOwnerRenamedEvent();

  public void RaiseOwnerUserSetChangedEvent();

  /// <summary> Residents and owners </summary>
  public IEnumerable<User> RelevantUsers { get; }

  public bool IsRentable { get; }

  public string EntryDescription { get; }

  public IEnumerable<PropertyPlot> Plots { get; }

  public override void Initialize();

  public void InitializeForSettlements();

  public void OpenAuthorizationMenuOn(Player player);

  public Result DeleteDeed(Player player);

  public void ChangeOwnables(
    IEnumerable<IOwnableHandle> toAdd,
    IEnumerable<IOwnableHandle> toRemove);

  public void AddOwnable(IOwnableHandle obj);

  public void RemoveOwnable(IOwnableHandle obj);

  [RPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  public void ChangeOwners(Player changer, IAlias newOwner);

  public float PercentOwnership(IAlias alias);

  public bool ContainsOwner(IAlias alias);

  public bool CanAccess(IAlias alias);

  protected bool VerifyOwner(Player player);

  /// <summary>Changes owner of the deed without any checks.</summary>
  public LocString ForceChangeOwners(IAlias newOwner, OwnerChangeType changeType);

  /// <summary>Perform related checks and pass the changing action through the action manager.</summary>
  /// <param name="pack">A game action pack to use.</param>
  /// <param name="changer">The one who will be 'Citizen' in all the checks and child actions.</param>
  /// <param name="newOwner">New owner of the deed.</param>
  /// <param name="transferAction">Is it needed to trigger a PropertyTransfer game action.</param>
  /// <param name="autoPerform">Is it needed to invoke pack.TryPerform() within this method.</param>
  /// <param name="okBox"></param>
  /// <param name="superAccess">There will be no check whether the changer has access to the property. Currently used for sales in the real estate desk.</param>
  /// <returns>Returns either result of CanChangeOwner chek or the result of the pack.TryPerform() invokation.</returns>
  public Result TryChangeOwners(
    GameActionPack pack,
    Player changer,
    IAlias newOwner,
    bool transferAction,
    bool autoPerform = true,
    bool okBox = true,
    bool superAccess = false,
    OwnerChangeType changeType = OwnerChangeType.Normal);

  [RPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  public void Open(Player player);

  [RPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  public void Claim(Player player);

  [RPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  protected void Delete(Player player);

  [RPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  public Task EditInMap(User user);

  [RPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  protected void RemoveOwnable(Player player, IDeedOwned obj);

  [RPC]
  public bool MoveOwnable(Player player, IDeedOwned obj, Deed toDeed);

  [RPC(Eco.Shared.Items.AccessType.OwnerAccess)]
  public void SetResidency(User user);

  [RPC(Eco.Shared.Items.AccessType.None)]
  public Task AcceptIfNotMember(User user);

  [RPC(Eco.Shared.Items.AccessType.None)]
  public void RemoveInvitationIfExists(User user);

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public override LocString UILinkContent();

  public void Save();

  public bool HasContainerAccess(Player player, string listName);

  User IHasReputation.UserSource { get; }

  Result IHasReputation.CanGiveReputation(User giver);

  bool IAnnexable.CanAnnex { get; }

  LocString IAnnexable.TypeAndName { get; }

  SettlementType? IAnnexable.SettlementType { get; }

  LocString IAnnexable.TypeDisplayName { get; }

  float IAnnexable.CultureTotal { get; }

  bool IAnnexable.Founded { get; }

  float IAnnexable.ReductionPercentageForAnnexation { get; }

  void IAnnexable.Notify(LocString msg);

  bool IAnnexable.HasAncestor(Settlement settlement);

  IEnumerable<User> IAnnexable.Citizens();

  Settlement IAnnexable.Parent { get; }

  float IAnnexable.DistanceTo(Vector2i worldPos);

  float IGeneratesCulture.CultureGenerated { get; }

  Deed IOwned.Deed { get; }
}
