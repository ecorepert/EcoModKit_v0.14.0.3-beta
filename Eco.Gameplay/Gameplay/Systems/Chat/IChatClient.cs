// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Chat.IChatClient
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Gameplay.Systems.Messaging.Notifications;
using Eco.Shared.Localization;
using Eco.Shared.Services;

#nullable disable
namespace Eco.Gameplay.Systems.Chat;

/// <summary>
/// <para>
/// The interface that something needs to implement in order to perform chat commands.
/// Used by User and RCON currently. Chat commands can accept either a <seealso cref="T:Eco.Gameplay.Players.User" /> or an <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" />
/// </para>
/// 
/// <para>
/// Difference between using <seealso cref="T:Eco.Gameplay.Players.User" /> vs. <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" /> as the first argument include:
/// <list type="bullet">
/// <item><description>If they accept a <seealso cref="T:Eco.Gameplay.Players.User" />, they are allowed to have full access to that <seealso cref="T:Eco.Gameplay.Players.User" />'s interface, but those chat commands cant be called by headless clients like RCON</description></item>
/// <item><description>If they accept an <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" />, they have a limited set of properties (below) which they can access from the chatClient, but both Users in game and headless clients such as RCON can call these functions.</description></item>
/// </list>
/// </para>
/// 
/// <para>Generally if you only need to issue return displays and make modifications to the world, you should make the chat command accept <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" />, so headless clients like RCON can call it.</para>
/// </summary>
public interface IChatClient : INotificationReceiver
{
  /// <summary> Represents the display name of this <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" /> instance</summary>
  string Name { get; }

  /// <summary> Represents the markup display name of this <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" /> instance</summary>
  LocString MarkedUpName { get; }

  /// <summary> Represents the internal name of this implementation. Used in things suchas error messages </summary>
  string ImplementationName { get; }

  /// <summary>
  /// Returns this Invoker's <seealso cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatAuthorizationLevel" /> value for use in command permission checks
  /// </summary>
  /// <returns><seealso cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatAuthorizationLevel" /> if the Invoker</returns>
  ChatAuthorizationLevel GetChatAuthLevel();

  /// <summary>
  /// Sends a message to the command invoker that is intended to be temporary. This method may not be supported by all command invokers. If the method is not
  /// supported these messages should be routed to a normal message call.
  /// </summary>
  /// <param name="message">Message to send to the invoker from a chat command</param>
  /// <param name="category"><seealso cref="T:Eco.Shared.Services.NotificationCategory" />The chat tags associated with this message</param>
  /// <param name="style"><seealso cref="T:Eco.Shared.Services.NotificationStyle" /> of the message to be sent</param>
  void TempServerMessage(LocString message, NotificationCategory category = NotificationCategory.Notifications, NotificationStyle style = NotificationStyle.Chat);
}
