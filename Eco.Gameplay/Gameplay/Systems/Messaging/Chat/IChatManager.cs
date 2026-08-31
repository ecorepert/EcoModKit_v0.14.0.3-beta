// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.IChatManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat;

public interface IChatManager
{
  /// <summary></summary>
  Result Send(User from, IChatReceiver to, string message);

  /// <summary>Adds command handler type which should contains one or more methods with <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommandAttribute" /> or <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatSubCommandAttribute" />. This method should be called before ChatManager initialization finished.</summary>
  void AddCommandHandler(Type commandHandler);

  /// <summary>Get list of all chat commands (from all IChatCommandHandler classes)</summary>
  IEnumerable<ChatCommand> GetAllCommands();

  /// <summary>Set client's current chat receiver (user or channel) (instead previous OutputTag), it also can include activation of the chat log</summary>
  void SetChatReceiver(Player player, IChatReceiver receiver, bool activateChat);

  /// <summary>Executes command (starting from slash), commands are defined in IChatCommandHandler classes</summary>
  void ExecuteCommand(IChatClient user, string command, SupportedLanguage language = SupportedLanguage.English);

  /// <inheritdoc cref="M:Eco.Gameplay.Systems.Messaging.Chat.IChatManager.ExecuteCommand(Eco.Gameplay.Systems.Chat.IChatClient,System.String,Eco.Shared.Localization.SupportedLanguage)" />
  Task ExecuteCommandAsync(IChatClient user, string command, SupportedLanguage language = SupportedLanguage.English);

  /// <summary>Get chat settings and chat tabs for user, which are stored on server</summary>
  ChatSettings GetSettingsForUser(User user);
}
