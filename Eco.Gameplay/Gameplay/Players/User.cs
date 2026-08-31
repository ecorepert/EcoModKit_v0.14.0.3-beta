// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.User
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using C5;
using Eco.Core.Controller;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Bonuses;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Economy.Jobs;
using Eco.Gameplay.Economy.Reputation;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players.Internal;
using Eco.Gameplay.Players.UserHelpers;
using Eco.Gameplay.Property;
using Eco.Gameplay.Rooms;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Settlements.Culture;
using Eco.Gameplay.Skills;
using Eco.Gameplay.StrangeCloudGameplay;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Systems.Messaging.Mail;
using Eco.Gameplay.Systems.Messaging.Notifications;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.UserTextures;
using Eco.Gameplay.Tutorial;
using Eco.Gameplay.UI.WorldMarker;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Services;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using Eco.Simulation.Agents;
using PropertyChanged;
using StrangeCloud.Service.Client.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Players;

/// <summary>
/// Partial class for <see cref="T:Eco.Gameplay.Players.User" /> for implementing the <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" /> interface
/// </summary>
[Serialized]
[KeepIcon]
[DoNotLinkOnTypeTooltip]
public class User : 
  SimpleEntry,
  ITickable,
  IComparable,
  IStorage,
  ISerializable,
  IAlias,
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  INotifyPropertyChanged,
  ICanTakeDamage,
  IObserverConversionTarget,
  IChatReceiver,
  IHasReputation,
  IReputationAssociated,
  IGivesReputation,
  IHasBonuses,
  IChatClient,
  INotificationReceiver
{
  public static readonly 
  #nullable disable
  ThreadSafeAction<User> UiStateChangedEvent;
  public readonly ThreadSafeAction CitizenshipChangedEvent;
  public IDynamicValueContext DynamicValueContext;
  [Serialized]
  public string Language;
  [Serialized]
  public bool MigrateUserUIStates;
  public UserUI UserUI;
  public readonly ThreadSafeAction<User, INetObject, INetObject, GameActionPack> OnPickupingObject;
  [Serialized]
  public SpecialUserPowers SpecialUserPowers;
  /// <summary>Set this to true to demote this user from admin to regular user until server is restarted.</summary>
  public bool ForceDemote;

  public ThreadSafeAction<IEnumerable<User>> UserSetChangedEvent { get; set; }

  public INetClient Client { get; }

  public Player Player { get; }

  public float VoteWeight(Election election);

  [Serialized]
  public UserTooltipDetails UserTooltipDetails { get; }

  [Notify]
  public StrangeUser StrangeUser { get; }

  [Serialized]
  public double LoginTime { get; }

  [Serialized]
  public bool FirstLogin { get; }

  [Serialized]
  public double LogoutTime { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public bool SpawnPointSelected { get; set; }

  public double LastOnlineTime { get; }

  public IPersistent StorageHandle { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string StrangeId { get; set; }

  [Serialized]
  public string TwitchId { get; }

  [Serialized]
  public string SteamId { get; }

  [Serialized]
  [SyncToView(null, true)]
  public string OverheadName { get; set; }

  [SyncToView(SyncFlags.MustRequest)]
  public EcoStrangeCloudUserData EcoPlayFabUserData { get; }

  public InitialData ClientSavedData { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public UserXP UserXP { get; }

  [Serialized]
  public Vector3 Position { get; set; }

  [Serialized]
  public Eco.Shared.Math.Quaternion Rotation { get; set; }

  [Serialized]
  public Vector3i LastWastePos { get; set; }

  [Serialized]
  public bool PredatorsProtected { get; set; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public ExhaustionMonitor ExhaustionMonitor { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public UserInventory Inventory { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public Stomach Stomach { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public Avatar Avatar { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public UserSettings UserSettings { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public UserAccounts UserAccounts { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public UserAchievements UserAchievements { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public UserCraftingLists UserCraftingLists { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public StrangeItemManagement StrangeItemManagement { get; }

  [Serialized]
  [SyncToView(null, true)]
  public VoiceData VoiceData { get; }

  [Serialized]
  [SyncToView(null, true)]
  public UserTexture UserImage { get; set; }

  [SyncToView(null, true)]
  public ConstantHighlightSetting ConstantHighlightSetting { get; set; }

  [Serialized]
  [Notify]
  public CultureUserCache CachedCulture { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Settlement DirectCitizenship { get; set; }

  [SyncToView(null, true)]
  public Deed HomesteadDeed { get; set; }

  /// <summary>Citizenship of town, and its country, and its federation, etc (if they exist).</summary>
  public IEnumerable<Settlement> AllCitizenships { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public IEnumerable<Contract> DisplayedContracts { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public IEnumerable<Contract> PostedContracts { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public IEnumerable<Contract> MyContracts { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public IEnumerable<Contract> AcceptedContracts { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public IEnumerable<Debt> Debts { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public IEnumerable<RecurringTransfer> IncomeAndExpenses { get; }

  [SyncToView(SyncFlags.MustRequest)]
  [DependsOnController("WatchedWorkOrders", true)]
  public IEnumerable<WorkOrder> RecentWatchedWorkOrders { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public ResidencyPropertyValue ResidencyPropertyValue { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public WorldMarkerManager Markers { get; set; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public UserTaskManager UserTasks { get; set; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public UserUIStates UIStates { get; set; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public Mailbox Mailbox { get; set; }

  [SyncToView(SyncFlags.MustRequest)]
  public UserDisplay UserDisplay { get; }

  public ThreadSafeAction OnMovedPlots { get; }

  public ThreadSafeAction<User> OnInvisible { get; }

  public ThreadSafeAction<User> OnEnterWorld { get; }

  public ThreadSafeAction<User> OnLogin { get; }

  public ThreadSafeAction<User> OnLogOut { get; }

  public ThreadSafeAction<WorldObject> OnWorldObjectPlaced { get; }

  public ThreadSafeAction<WorkOrder> OnWorkOrderCreated { get; }

  public ThreadSafeAction<WorkOrder> OnWorkOrderDeposited { get; }

  public ThreadSafeAction<WorkOrder> OnWorkOrderComplete { get; }

  public ThreadSafeAction<WorkOrder> OnWorkOrderCollect { get; }

  public ThreadSafeAction<WorkOrder> OnWorkOrderLaborContributed { get; }

  public ThreadSafeAction<string, Eco.Gameplay.Items.Inventory> OnItemInserted { get; }

  public ThreadSafeAction<Deed> OwnedPropertyValueChanged { get; }

  public ThreadSafeAction<TutorialWatch, Type> OnTutorialEvent { get; }

  public ThreadSafeAction<User.InteractionEvent> OnInteract { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public Skillset Skillset { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<User> UserSet { get; }

  public bool ContainsExactAlias(IAlias alias);

  public bool ContainsUser(User user);

  public bool Valid { get; }

  public string ReportUserId { get; }

  public string ReportUsername { get; }

  public string ReportIpAddress { get; }

  public IEnumerable<User> ChatRecipients { get; }

  [SyncToView(null, true)]
  public string ChatTag { get; }

  public override LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  public string MarkedUpChatTag { get; }

  public string BadgeIcon { get; }

  public bool IsAbandoned { get; }

  public bool IsActive { get; }

  public UserStats ModifiedStats { get; set; }

  public void ChangedMovementSpeed();

  public float SwimSpeedMultiplier { get; set; }

  [SyncToView(SyncFlags.MustRequest)]
  public float RunSpeed { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public float CalorieRateMultiplier { get; set; }

  [SyncToView(SyncFlags.MustRequest)]
  [DependsOn("SwimSpeedMultiplier")]
  public float SwimSpeed { get; }

  public void ChangedCarryWeight();

  public void ChangedBackpackSlots();

  public void ChangedCarriedSlots();

  public ItemStack Carrying { get; }

  public ItemStack ToolbarSelected { get; }

  [SyncToView(null, true)]
  public float DetectionRangeReduction { get; }

  [SyncToView(null, true)]
  [Serialized]
  public string PlayerObjective { get; set; }

  [SyncToView(null, true)]
  public float Reputation { get; }

  [SyncToView(null, true)]
  public string MarkedUpReputationAndName { get; }

  [Serialized]
  public double LastTickSec { get; set; }

  [Serialized]
  public double NextTick { get; set; }

  [Serialized]
  public double TotalPlayTime { get; set; }

  [Serialized]
  public TimeLog OnlineTimeLog { get; set; }

  [Serialized]
  public TimeLog ActiveTimeLog { get; set; }

  [Serialized]
  public OfflineInfo OfflineInfo { get; set; }

  public IPriorityQueueHandle<ITickable> QueueHandle { get; set; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public Talentset Talentset { get; set; }

  /// <summary> Aggregates bonuses from talents (future: settlement, clothing, etc). </summary>
  public IEnumerable<Bonus> Bonuses { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public Room CurrentRoom { get; }

  public Atmosphere CurrentAtmosphere { get; }

  public BlockHitCache BlockHitCache { get; set; }

  [SyncToView(SyncFlags.MustRequest)]
  public BankAccount BankAccount { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public Currency Currency { get; }

  public bool LoggedIn { get; }

  public bool EnteredWorld { get; }

  public bool DevToolSelected { get; }

  public bool IsSlgDev { get; }

  [SyncToView(null, true)]
  [Serialized]
  public bool IsInvisible { get; set; }

  [SyncToView(null, true)]
  [DependsOn("Player")]
  [Notify]
  public bool IsAdmin { get; }

  /// <summary>True only for users who are admins on this server and whose StrangeCloud identity is dev-tier (i.e. an actual Strange Loop / DevTier engineer).</summary>
  [SyncToView(null, true)]
  [DependsOn("Player")]
  [DependsOnController("IsAdmin", true)]
  public bool IsDevTier { get; }

  [SyncToView(null, true)]
  public bool IsOnline { get; }

  public bool IsLocal();

  public void OverrideInventory(UserInventory inventory);

  public void OverrideAvatar(Avatar avatar);

  public Direction FacingDir { get; }

  public User(
    Guid strangeId,
    string steamID,
    string twitchID,
    string name,
    IPersistent storageHandle);

  /// <summary>Constructor used only for creating fake users in benchmarks.</summary>
  protected User(Guid strangeId);

  [Eco.Shared.Serialization.OnDeserialized]
  protected void OnDeserialized();

  public Result Verify();

  public override void Initialize();

  /// <summary>Force a change in Income and expenses object to update the state of it on client side.</summary>
  public void NotifyIncomeAndExpensesChange();

  public void OnPropertyValueChanged();

  public void OnOwnedPropertyValueChanged(Deed deed);

  public void OnRenamed(string oldName);

  public int CompareTo(object other);

  public Result CheckAccessForPlaying();

  public void Tick();

  public void UpdateRoom();

  public void Destroy();

  public bool IsReady();

  public Result Login(
    Player player,
    INetClient client,
    bool allowDisconnectionAfterActionFailure = true,
    bool ignoreTestMode = false);

  /// <summary> To be called when client already have assigned WorldObserver. </summary>
  public void LoginCompleted();

  public void Logout();

  public void EnterWorld();

  public override void MarkDirty();

  public void SetState(string key, object val);

  public bool HasState(string key);

  public object GetState(string key);

  public T GetState<T>(string key);

  public override string ToString();

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public override LocString UILinkContent();

  [RPC]
  public List<Deed> GetAllProperty();

  [RPC]
  public List<Vector3i> GetAllRooms();

  [RPC]
  public void ConsumeCalories(float change);

  [RPC]
  public void ForceSpawnPointSelected();

  [RPC]
  public void UIOpened(string uiName);

  [RPC]
  public void UIClosed(string uiName);

  [RPC]
  public void DiscordOpened();

  [RPC]
  public void EditView(IController controller);

  /// <summary> On client-site event used when the user select a tab</summary>
  [RPC]
  public void TabSelected(string title);

  [RPC]
  public string CreateCraftingList(string name);

  [RPC]
  public void DeleteCraftingList(string id);

  [RPC]
  public void AddRecipeToCraftingList(string id, int recipeTypeId);

  [RPC]
  public void RemoveRecipeFromCraftingList(string id, int recipeTypeId);

  /// <summary>Sets received byte array from the client as the user's avatar image.</summary>
  [RPC]
  public Task SetUserTexture(byte[] tex);

  /// <summary> Sets client initial data for this user and calls any methods that use data for setup, Called right after data is returned from the client request</summary>
  public Task SetClientData(InitialData data);

  /// <summary> Tries to make damage to user. If fails for some reason (in example User out of calories) then returns <c>false</c>. </summary>
  public bool TryDamage(INetObject source, float damage, DamageSourceType sourceType);

  public bool TryDamage(
    INetObject source,
    float damage,
    bool triggerEffectOnPlayer,
    DamageSourceType sourceType);

  public string RepUILink();

  public void ContractsChanged();

  /// <summary>Prompts client to clear interaction cache for this user, used when server side changes would change interactions for user e.g auth changes</summary>
  public void ClearInteractionCache();

  public void DebtChanged();

  public void RefreshOverheadName();

  public IEnumerable<WorkOrder> GetWatchedWorkOrders { get; }

  public void AddWatchedWorkOrder(WorkOrder order, bool doUpdate = true);

  [RPC]
  public void RemoveWatchedWorkOrder(WorkOrder order);

  [SyncToView(null, true)]
  public TutorialStatus CurrentTutorialStatus { get; set; }

  [RPC]
  public void TutorialEvent(TutorialWatch flag, Type type = null);

  /// <summary>Asks the user if they would like to open the web path on the server's internal web server.</summary>
  /// <param name="webPath">The web path you wish to open.</param>
  public void OpenServerWebpage(string webPath);

  /// <summary>Asks the user if they would like to open a external website url.</summary>
  /// <param name="url">The web url you wish to open.</param>
  public void OpenWebpage(string url);

  /// <summary>
  /// Opens the overlay modal for joining a Discord guild, given its invite code.
  /// An invite code for a server may look something like eco for a verified server—the full invite being discord.gg/eco something like X3JeE4CV for a non-verified server,
  /// the full invite being https://discord.gg/X3JeE4CV.
  /// </summary>
  /// <param name="code">The invite code for the guild you wish to invite the user to.</param>
  public void OpenDiscordInvite(string code);

  internal void UpdateStrangeUser();

  public override bool CanBeDeleted { get; }

  User IHasReputation.UserSource { get; }

  public 
  #nullable enable
  string ImplementationName { get; }

  public void TempServerMessage(
    LocString message,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat);

  public void MsgLoc(FormattableString msg, NotificationStyle style = NotificationStyle.Chat);

  public void Msg(LocString msg, NotificationStyle style = NotificationStyle.Chat);

  public void MsgLocStr(string msg, NotificationStyle style = NotificationStyle.Chat);

  public void Error(LocString msg);

  public void ErrorLoc(FormattableString msg);

  public void ErrorLocStr(string msg);

  /// <summary>Displays an ok box to the player, if the user has a player to show it to.</summary>
  public void OkBoxLoc(FormattableString msg);

  public void OkBox(LocString msg);

  public void OkBoxLocStr(string msg);

  /// <summary>Displays an on screen info boxto the player, if the user has a player to show it to.</summary>
  public void InfoBoxLoc(FormattableString msg);

  public void InfoBox(LocString msg);

  public void InfoBoxLocStr(string msg);

  /// <summary>Send an info box, unless theyre offline, then send a ,msg.</summary>
  /// <param name="msg"></param>
  public void InfoBoxOrMsgLoc(
    FormattableString msg,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat);

  public void InfoBoxOrMsg(LocString msg, NotificationCategory category = NotificationCategory.Notifications, NotificationStyle style = NotificationStyle.Chat);

  public ChatAuthorizationLevel GetChatAuthLevel();

  public struct InteractionEvent
  {
    public 
    #nullable disable
    string Name;
    public Item ItemInInteraction;
    public InteractionTarget Target;
    public WorldObject WorldObjectInInteraction;
  }
}
