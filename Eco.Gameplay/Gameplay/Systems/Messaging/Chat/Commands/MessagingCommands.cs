// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.MessagingCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Channels;
using Eco.Shared.Localization;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

/// <summary>Messaging commands related to chat itself, also mail and notification commands</summary>
[ChatCommandHandler]
public static class MessagingCommands
{
  [ChatCommand("Shows Commands related to chat.", ChatAuthorizationLevel.Admin)]
  public static void Chat();

  [ChatSubCommand("Chat", "Clean up chat history from old messages. Reduces memory usage and may improve server performance. You need to provide number of days in world time to preserve.", ChatAuthorizationLevel.Admin)]
  public static void ClearHistoryOlderThan(
  #nullable disable
  User user, int preserveDays);

  [CITest(false)]
  [ChatCommand("Displays all the commands available with hidden subcommands. Accepts a string to filter commands to a search string.", "?", ChatAuthorizationLevel.User)]
  public static void Help(IChatClient chatClient, SupportedLanguage language, string text = "");

  [CITest(false)]
  [ChatCommand("Shows all help, including sub commands.")]
  public static void Helpful(IChatClient chatClient, SupportedLanguage language);

  [ChatCommand("Shows commands related to notifications.", ChatAuthorizationLevel.Admin)]
  public static void Notifications();

  [ChatSubCommand("Notifications", "Send mail to the given user (or self if blank).", "m", ChatAuthorizationLevel.Admin)]
  public static void Mail(User user, string text, User targetUser = null);

  /// <param name="enableGeneralMessages">Enable sending messages from a test user to the general channel periodically.</param>
  /// <param name="timeBtwMessages">Specify the delay time between messages.</param>
  /// <param name="enableWhisperMessages">Enable sending messages from a test user to the current user periodically.</param>
  [ChatSubCommand("Test", "Make a test user send a message every specific period of time to the general channel and/or to the current user.", ChatAuthorizationLevel.DevTier)]
  public static void ChatInteraction(
    User user,
    bool enableGeneralMessages,
    float timeBtwMessages = 1f,
    bool enableWhisperMessages = false);

  [ChatSubCommand("Chat", "Send private message to self from a specified user.", ChatAuthorizationLevel.DevTier)]
  public static void PrivateSend(User user, string text, User fromUser);

  /// <param name="senderCount">How many distinct test users will whisper you (one PM tab each if whisper-per-player is on).</param>
  /// <param name="messagesPerSender">How many private messages each test user sends, to build scrollable PM history.</param>
  [ChatSubCommand("Chat", "Generate PM history for testing: sends messages to yourself from several distinct test users.", ChatAuthorizationLevel.DevTier)]
  public static void GenerateWhispers(User user, int senderCount = 3, int messagesPerSender = 60);

  [ChatSubCommand("Chat", "Send message to channel from a specified user.", ChatAuthorizationLevel.DevTier)]
  public static void ChannelSend(User user, string text, Channel channel, User fromUser);
}
