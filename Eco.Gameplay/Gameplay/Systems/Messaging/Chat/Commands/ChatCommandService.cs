// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommandService
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Chat;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

/// <summary> Service responsible for <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommand" /> registration and processing.</summary>
public class ChatCommandService
{
  /// <summary> Returns all registered commands (including sub commands). </summary>
  public 
  #nullable disable
  IEnumerable<ChatCommand> GetAllCommands();

  /// <summary> Returns all registered commands (including sub commands) that can be used by a headless <seealso cref="T:Eco.Gameplay.Systems.Chat.IChatClient" /> such as RCON. </summary>
  public IEnumerable<ChatCommand> GetAllHeadlessCommands();

  /// <inheritdoc cref="M:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommandService.TryInvokeCommand(Eco.Gameplay.Systems.Chat.IChatClient,System.String,Eco.Shared.Localization.SupportedLanguage,Eco.Shared.Networking.INetObject,System.Threading.Tasks.Task@)" />
  public Task<bool> HandleCommandAsync(
    IChatClient chatClient,
    string text,
    SupportedLanguage language,
    INetObject target);

  /// <inheritdoc cref="M:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommandService.TryInvokeCommand(Eco.Gameplay.Systems.Chat.IChatClient,System.String,Eco.Shared.Localization.SupportedLanguage,Eco.Shared.Networking.INetObject,System.Threading.Tasks.Task@)" />
  public bool HandleCommand(
    IChatClient chatClient,
    string text,
    SupportedLanguage language,
    INetObject target);

  /// <summary> Shows help for <paramref name="command" />. </summary>
  public void ShowHelp(IChatClient chatClient, ChatCommand command);

  /// <summary>
  /// Shows help for <paramref name="query" />. It depends on <paramref name="query" /> content:
  /// <list type="bullet">
  /// <item>`command[ subCommand]` - will show help for command/sub command/shortcut</item>
  /// <item>`command unknownSubCommand` - will show help for command</item>
  /// <item>`unknownCommand` - show all commands matching `unknownCommand` substring</item>
  /// <item>`` - will show all commands</item>
  /// </list>
  /// If <paramref name="full" /> is set then will expand sub commands for all commands.
  /// </summary>
  public void ShowHelpByQuery(
    IChatClient chatClient,
    SupportedLanguage language,
    string query,
    bool full = false);

  /// <summary> Collects all chat commands for <paramref name="handlerTypes" /> and registers them in <see cref="F:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommandService.commandsByLanguage" /> dictionary for English language.</summary>
  public void AddCommandHandlers(IEnumerable<Type> handlerTypes);
}
