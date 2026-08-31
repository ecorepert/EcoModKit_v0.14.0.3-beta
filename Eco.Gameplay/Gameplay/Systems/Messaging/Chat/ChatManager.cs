// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.ChatManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Channels;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Serialized]
[ChatCommandHandler]
public class ChatManager : 
  Singleton<
  #nullable disable
  ChatManager>,
  INetObjectPriority,
  INetObject,
  IChatManager,
  IStorage,
  ISerializable
{
  public static readonly ThreadSafeAction<ChatMessage> MessageSent;
  public static readonly ThreadSafeAction<ChatMessage> OnPreMessageSent;
  [Serialized]
  public Registrar<Channel> ChannelRegistrar;
  [Serialized]
  public ChannelManager ChannelManager;
  [Serialized]
  [ForceSerializeFullObject]
  public ThreadSafeHashSet<NotificationMessageSource> NotificationSources;
  public const string HistoryPageMessagesKey = "messages";

  public ChatCommandService ChatCommandService { get; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  public void ReceiveInitialState(BSONObject bsonObj);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdate(BSONObject bsonObj);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public float Priority { get; }

  public int TotalMessages { get; }

  public void InitializeRegistrars(TimedTask timer);

  public void Initialize();

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  /// <summary>Adds handler type. May be used for types which not auto-discovered by reflection (i.e. when some commands only available under specific conditions).</summary>
  public void AddCommandHandler(Type handlerType);

  public IEnumerable<ChatCommand> GetAllCommands();

  /// <summary>
  /// Execute a command string directly, from a <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" /> rather than a <seealso cref="T:Eco.Gameplay.Players.User" />. This allows only a subset of chat commands
  /// (those that accept <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" /> instead of User as their first property). Does not require the beginning forward slash '/')
  /// </summary>
  public Task ExecuteCommandAsync(
    IChatClient chatClient,
    string command,
    SupportedLanguage language = SupportedLanguage.English);

  /// <inheritdoc cref="M:Eco.Gameplay.Systems.Messaging.Chat.ChatManager.ExecuteCommandAsync(Eco.Gameplay.Systems.Chat.IChatClient,System.String,Eco.Shared.Localization.SupportedLanguage)" />
  public void ExecuteCommand(IChatClient chatClient, string command, SupportedLanguage language = SupportedLanguage.English);

  public IEnumerable<ChatMessage> GetAllChatMessages();

  /// <summary>
  /// Remove a specific channel, that was deleted from the game, from all the tabs that have it in their "Chat Sources"(the list of all the channels that can be displayed in that tab)
  /// and all associated chat messages
  /// </summary>
  public void RemoveChannelReferencesFromChat(Channel receiver);

  public ChatSettings GetSettingsForUser(User user);

  public void SetChatReceiver(Player player, IChatReceiver receiver, bool activateChat = false);

  [RPC]
  public static Result SanitizeAndSendChat(
    User user,
    [Profanity(Filter = ProfanityFilterType.NoFilter)] string text,
    SupportedLanguage language,
    string tag = null,
    INetObject target = null);

  public static Result SendMessage(User user, IChatReceiver to, string message);

  public Result Send(User user, IChatReceiver to, string message);

  public void AddToChatLog(ChatMessage message);

  /// <summary>Removes all messages matching <paramref name="predicate" />.</summary>
  public int RemoveMessages(Predicate<ChatMessage> predicate);

  public static IEnumerable<ChatMessage> GetPlayerMessages(
    double minTimeSeconds = -1.7976931348623157E+308,
    double maxTimeSeconds = 1.7976931348623157E+308);

  public static IEnumerable<ChatMessage> GetMessagesVisibleTo(
    User user,
    int max,
    double timeSentBefore = 1.7976931348623157E+308);

  /// <summary>Returns a page of older messages (before <paramref name="beforeTimeSeconds" />) visible to the player and matching the given tab's filter, for infinite scroll.
  /// The tab must be one of the player's own chat tabs; its channels/whisper user mirror the client's <c>ShouldDisplay</c>. Visibility is always enforced so a client cannot pull history it lacks access to.
  /// Wrapped in a BSONObject because raw BSONArray results can't be reconstructed by the RPC deserializer (no default ctor).</summary>
  [RPC]
  public BSONObject GetChatHistoryPage(
    Player player,
    ChatTabSettingsBase tab,
    double beforeTimeSeconds,
    int count);

  public static IEnumerable<ChatMessage> GetContext(
    ChatMessage message,
    int nPreviousMessages = 0,
    int nFollowingMessages = 0);

  /// <summary>Reset chat settings of all users to use the default. Mostly used for testing and playtest.</summary>
  public void TryResetChatSettings();

  public void MarkDirty();

  public IPersistent StorageHandle { get; set; }
}
