// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.WorldObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Bonuses;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Rooms;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Networking.Auth;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Objects;

[Serialized]
[ForceCreateViewAllDerived]
[HasStaticIcon("GetIcon")]
[Tag("Usable")]
[Tag("World Object")]
[RequireComponent(typeof (ForSaleComponent), null)]
public abstract class WorldObject : 
  INetObjectPriority,
  INetObject,
  INetObjectPosition,
  IPositionAndBounds,
  IUsable,
  IController,
  IViewController,
  IHasUniversalID,
  IStorage,
  ISerializable,
  IRPCAuthChecks,
  ILinkableParameterized<LinkConfig>,
  ILinkable,
  IHasPosition,
  INotifyPropertyChanged,
  IDeedOwned,
  IPlayerUseTracking,
  INamed,
  IHasSerializableID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IInteractionTargetPriority,
  IHasBonuses,
  IPermanentDestroyHandler
{
  protected 
  #nullable disable
  NetEntity netEntity;
  [Serialized]
  protected bool enabled;
  [Serialized]
  protected bool operating;
  public bool IsHUDElement;
  [Serialized]
  public WorldObjectHandle AttachedTo;

  public static string GetIcon(Type type);

  public event PropertyChangedEventHandler PropertyChanged;

  public IPersistent StorageHandle { get; set; }

  public virtual LocString DisplayDescription { get; }

  public virtual bool Transient { get; }

  public NetworkChannel UpdateChannel { get; }

  [SyncToView(null, true)]
  public virtual LocString DisplayName { get; }

  [SyncToView(null, true)]
  public virtual TableTextureMode TableTexture { get; }

  [SyncToView(null, true)]
  public virtual InteractionTargetPriority TargetPriority { get; }

  public virtual bool HasTier { get; }

  public virtual int Tier { get; }

  [Obsolete("FriendlyName is Deprecated, use DisplayName instead")]
  [SyncToView(null, true)]
  [DependsOn("DisplayName")]
  public virtual string FriendlyName { get; }

  [Obsolete("Description is Deprecated, use DisplayDescription instead")]
  public virtual string Description { get; }

  [SyncToView(null, true)]
  [DependsOn("GivenName")]
  public string Name { get; set; }

  [SyncToView(null, true)]
  [Cached]
  [DependsOn("Name")]
  public LocString MarkedUpName { get; }

  [Serialized]
  public User Creator { get; }

  [Serialized]
  public Guid ObjectID { get; }

  [Serialized]
  public double WorldObjectCreationTime { get; }

  [Serialized]
  protected string GivenName { get; }

  public static ThreadSafeAction<WorldObject> OnAnyNameChanged { get; }

  public ThreadSafeAction OnPositionChange { get; }

  public ThreadSafeAction OnOperatingChange { get; }

  public ThreadSafeAction OnOperatingEfficiencyChange { get; }

  public ThreadSafeAction OnEnableChange { get; }

  public ThreadSafeAction OnMovedEvent { get; }

  public event Action SyncPositionEvent;

  [SyncToView(null, true)]
  public string NameOfCreator { get; }

  [SyncToView(null, true)]
  public bool Enabled { get; }

  [SyncToView(null, true)]
  public bool Operating { get; }

  [SyncToView(null, true)]
  public float OperatingEfficiency { get; }

  [Notify]
  public LocString OwnersMarkedUpName { get; }

  [SyncToView(null, true)]
  public IAlias Owners { get; }

  [SyncToView(null, true)]
  public ControllerDictionary<string, object> AnimatedStates { get; }

  /// <summary> Item that will be given to player when this object is taken. By default, its equal to CreatingItem. Ex override if you want to return non-placeable item from worldobject. </summary>
  public virtual Item TakingItem { get; }

  /// <summary> Item used to create this world object. If it's a simple item that has no serialized fields -&gt; reference from static items will be used. Otherwise copy will be created. </summary>
  [SyncToView(null, true)]
  public IPlaceableItem CreatingItem { get; set; }

  [SyncToView(null, true)]
  public bool Using { get; }

  public bool Initialized { get; }

  [Notify]
  public bool IsDestroyed { get; }

  public virtual bool AllowResidentAccessIfCreator { get; }

  /// <summary>Get the settlement associate with this world object.  Defined as the lowest level settlement
  /// that influences this position.  This is cached data built from the influence map.</summary>
  [SyncToView(null, true)]
  [Serialized]
  public Settlement CachedSettlementAtPos { get; set; }

  public ThreadSafeList<WeakReference> UsingPlayers { get; set; }

  public virtual bool PlacesBlocks { get; }

  public Room Room { get; }

  public void SetRoom(Room room);

  [SyncToView(null, true)]
  public int RoomId { get; }

  [SyncToView(null, true)]
  public bool IsInOutdoorRoom { get; }

  public void SetDirty();

  public virtual bool CloseWhenDistant { get; }

  [Notify]
  [Serialized]
  public bool AdminForceEnabled { get; }

  public virtual void RoomUpdated();

  public Task OnAdd(
    User creator,
    WrappedWorldPosition3 position,
    Eco.Shared.Math.Quaternion rotation,
    bool allowAsync = true,
    WorldObject attachedToWorldObject = null);

  public void OnUsingPlayersChange();

  public void PostAdd();

  /// <summary>Called when the net entity is created.</summary>
  protected virtual void CreateEntity();

  public virtual void Tick();

  /// <summary>Can be called to force this to be enabled, regardless of component enabled sates.</summary>
  public void SetAdminForceEnabled(bool set);

  public void UpdateEnabledAndOperating();

  public virtual void LateTick();

  /// <summary> Toggles the animated state with given name to its opposite state, assuming the calling player has at least consumer access. </summary>
  /// <remarks> Extra useful for modders that would like to include a variety of states and control them in different ways (e.g.: Player input to turn lights on/off while driving a vehicle). </remarks>
  [RPC]
  public void ToggleAnimatedState(Player player, string name);

  public T GetAnimatedState<T>(string name);

  public void SetAnimatedState(string name, float val);

  public void SetAnimatedState(string name, bool val);

  public void SetAnimatedState(string name, string val);

  public void TriggerAnimatedEvent(string name);

  [RPC]
  public virtual void SetName(Player player, string newName);

  public void SetName(string newName);

  /// <summary>Moves world object by updating position, rotation, block occupancy and triggers moved events.</summary>
  public void MoveWorldObjectTo(Vector3 pos, Eco.Shared.Math.Quaternion rot);

  public bool PlaceWorldObjectBlocks(WorldObject attachedToWorldObject);

  /// <summary>Force all viewers of the world object UI to close it</summary>
  public void CloseUIForAll(bool forceUncache);

  public void SkipNextCache();

  public bool Destroy();

  /// <summary>Method called from <see cref="M:Eco.Gameplay.Objects.WorldObject.Destroy" /> when world object destroys. May be overriden in inherited classes.</summary>
  protected virtual void OnDestroy();

  /// <summary>Called before components are created at all.</summary>
  protected virtual void OnCreatePreInitialize();

  /// <summary>Called upon creation, after all components have been initialized.</summary>
  protected virtual void OnCreatePostInitialize();

  /// <summary>Perform the steps needed for initialization, which is called after OnCreate, and every server start.</summary>
  public void DoInitializationSteps(bool fistTimeAdded = false);

  /// <summary>Computes and caches the voxel cells this object occupies. Uses PickOriginCell so freely-placed objects leaning against a wall voxelize
  /// into the space they visually occupy instead of the wall; block placement and removal both consume this cached footprint so they always agree.
  /// Recomputed on every load by design (occupancy blocks are transient): if world changes invalidated the previous footprint, the origin self-heals
  /// to the nearest valid cell the object straddles, a bounded one-cell shift of bookkeeping only (the mesh never moves). Persisting the origin
  /// instead would freeze a footprint inside later-built walls, which is the exact bug origin selection removes.</summary>
  internal void CalcWorldOccupancy();

  /// <summary>Initialize the object and components.</summary>
  protected virtual void Initialize();

  /// <summary>For when you have autogen and non-autogen halves of a class that both want to override Initialize. Currently Initalize always happens in the autogen file. Any initalization that happens in PostInitialize will override changes from Initalize.</summary>
  protected virtual void PostInitialize();

  /// <summary>Called after all components have been initialized. </summary>
  protected virtual void ComponentsInitialized();

  public void FinishInitialize();

  [RPC]
  public void OnClick(Player clickingPlayer);

  public Deed GetDeed();

  public void OnAuthChanged();

  public void OnAuthSet(Deed deed);

  public override string ToString();

  public static LocString UILink<T>(bool plural = false) where T : WorldObject;

  public static LocString UILink(int num, Type worldObjectType, bool plural = false);

  public static LocString UILink(Type worldObjectType, bool plural = false);

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();

  public LocString UILinkContent(LinkConfig config);

  [Notify]
  [SyncToView(null, true)]
  public Vector3i LastSyncedPosition { get; }

  [Serialized]
  public Vector3 Position { get; set; }

  public Vector3i Position3i { get; set; }

  public Rect Bounds { get; }

  public PlotPos PlotPos { get; }

  [Serialized]
  public Eco.Shared.Math.Quaternion Rotation { get; set; }

  public int ID { get; }

  public bool Active { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

  public virtual float Priority { get; }

  public virtual void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public virtual void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public virtual void ReceiveUpdate(BSONObject bsonObj);

  public virtual void ReceiveInitialState(BSONObject bsonObj);

  public virtual bool IsRelevant(INetObjectViewer viewer);

  public virtual bool IsNotRelevant(INetObjectViewer viewer);

  public virtual bool IsUpdated(INetObjectViewer viewer);

  public static void AddOccupancy<T>(List<BlockOccupancy> occupancyList);

  public static void AddOccupancy(Type t, List<BlockOccupancy> occupancyList);

  public static void AddOccupancyList(
    Type declaringType,
    params BlockOccupancy[] blockOccupancyList);

  /// <summary>Adds a new dynamic predicate rule to the occupancy dictionary. Note that a predicate rule will be checked first before returning a normal occupancy.</summary>
  /// <param name="predicate">Takes in a <see cref="T:Eco.Gameplay.Objects.WorldObject" /> instance and returns the occupancies.</param>
  public static void AddOccupancyRule<T>(Func<WorldObject, OccupancyInfo> predicate) where T : WorldObject;

  public Ray GetOccupancyType(BlockOccupancyType type);

  public List<BlockOccupancy> Occupancy { get; }

  public OccupancyInfo OccupancyInfo { get; }

  public List<Vector3i> WorldOccupancy { get; }

  public WorldRange WorldRange { get; }

  public static List<BlockOccupancy> GetOccupancy(Type type);

  public static OccupancyInfo GetOccupancyInfo(Type type);

  /// <summary>Counts the cached WorldOccupancy cells that actually hold this object's block. Can be fewer than the declared occupancy:
  /// cells overlapping solid blocks are silently skipped at block placement (e.g. free placement against a wall) and attached objects place none.</summary>
  public int PlacedOccupancyBlockCount();

  /// <summary>Returns a world range that encompasses the occupancy. This is an exclusive range.</summary>
  public static WorldRange GetOccupancyRangeOrDefault(Type type);

  /// <summary>Return a world range that encompasses the whole object in its current position and occupancy.</summary>
  public WorldRange GetOccupancyRangeWorldPos();

  public static Vector3i GetBounding(Type type);

  /// <summary>Returns all plots intersecting with occupied block positions.</summary>
  public static IEnumerable<PlotPos> GetOccupiedPropertyPositions(
    Type type,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rot);

  public virtual float InteractDistance { get; }

  public virtual void Use(
    Player player,
    InteractionTarget target,
    InteractionTriggerInfo triggerInfo,
    string ui = "WorldObjectUI");

  /// <summary> Sends UI components to the <paramref name="player" />. See <see cref="T:Eco.Gameplay.Objects.WorldObjectComponentClientAvailability" />. </summary>
  public void SendUIComponents(Player player);

  [RPC]
  public void OpenUI(Player player);

  /// <summary>Releases UI opened by the client. Usually it means to detach all UI components so they may release resources on client and stop receiving component updates. Some UIs may be opened without consumer access so we shouldn't ask any access for RPC to release it.</summary>
  [RPC(AccessType.None)]
  public HashSet<int> ReleaseUIComponents();

  /// <summary>We create this RPC to allow calling an RPC on a component for which the client doesnt have a view, so it uses the world object + component type
  /// Note: this should be removed once we have a more general system for calling RPCs on sub-components.</summary>
  [RPC(AccessType.None)]
  [UnauthenticatedRpcJustification("Dispatch only: reaches nothing but the component's registered RPCs, and RPCManager.Invoke enforces the targeted method's own RequiredAccess through WorldObjectComponent.IsRPCAuthorized. Requiring access here would block interactions meant to be public, like buying a for-sale object or rating a plaque.")]
  public void InteractOnComponent(
    Player player,
    Type componentType,
    string componentName,
    string methodName,
    InteractionTriggerInfo triggerInfo,
    InteractionTarget target);

  /// <summary>Like InteractOnComponent, but routes the RPC to a module item currently slotted into this object's ModularVehicleComponent.</summary>
  [RPC(AccessType.None)]
  public void InteractOnModule(
    Player player,
    Type itemType,
    string methodName,
    InteractionTriggerInfo triggerInfo,
    InteractionTarget target);

  public void SyncPositionAndRotation();

  public double NetObjectCreationRealtime { get; set; }

  bool IRPCAuthChecks.IsRPCAuthorized(
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);

  public bool IsAuthorized(User user, AccessType requiredAccess);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  /// <summary> Get target and access override if this object has own flow </summary>
  public (AuthComponent Auth, AccessType Access) GetAuthTargetOverride(
    GameAction action,
    IAlias alias,
    AccessType access,
    AuthComponent auth);

  [SyncToView(SyncFlags.CyclicRef)]
  public AuthComponent Auth { get; }

  [Serialized]
  [NewTooltipChildren(CacheAs.Instance, TTCat.Details)]
  public ThreadSafeList<WorldObjectComponent> Components { get; }

  /// <summary> IBonusSource aggregates bonuses from components that implement IBonusSource (Such as modules via PluginModulesComponent). </summary>
  public IEnumerable<Bonus> Bonuses { get; }

  public T GetOrCreateComponent<T>(string name = null, Action<T> configure = null) where T : WorldObjectComponent;

  public WorldObjectComponent GetOrCreateComponent(
    Type componentType,
    string name = null,
    Action<WorldObjectComponent> configure = null);

  public bool HasComponent<T>();

  public bool HasComponent(Type componentType, string name = null);

  public T GetComponent<T>(string name = null);

  public object GetComponent(Type componentType, string name = null);

  public IEnumerable<T> GetComponents<T>();

  public WorldObjectComponent GetComponent(string typeName);

  public bool TryGetComponent<T>(out T component) where T : WorldObjectComponent;

  public void SetComponentsParent();

  public void InitializeComponents();

  public void TickComponents();

  public void LateTickComponents();

  public void DestroyComponents();

  public bool RemoveComponent<T>(string name = null) where T : WorldObjectComponent;

  public bool RemoveComponent(WorldObjectComponent component);

  public void SendInitialStateComponents(BSONObject bsonObj, INetObjectViewer viewer);

  public void SendUpdateComponents(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdateComponents(BSONObject bsonObj);

  public virtual void OnPermanentDestroy();
}
