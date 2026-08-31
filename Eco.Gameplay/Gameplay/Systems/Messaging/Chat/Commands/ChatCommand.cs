// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommand
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

/// <summary> Class holding information about chat command (built from <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommandAttribute" /> and <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatSubCommandAttribute" />). </summary>
public class ChatCommand
{
  public ChatCommandAttribute Attribute;
  public string Key;
  public string Name;
  public string ParentKey;
  public string ParentName;
  public MethodInfo Method;
  public string ShortCut;
  public string HelpText;

  public ChatAuthorizationLevel AuthLevel { get; }

  public bool HasSubCommands { get; }

  public IEnumerable<ChatCommand> SubCommands { get; }

  /// <summary> Returns fully qualified command name (including parent name if it is sub command). </summary>
  public string FullName { get; }

  public void AddSubCommand(ChatCommand subCommand);

  public bool TryGetSubCommand(string nameOrKey, out ChatCommand command);

  /// <summary> Checks if <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommand" /> matches searchString. </summary>
  public bool Matches(string searchString);

  /// <summary> Returns <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommand" /> localized for <paramref name="language" />. It will only correctly work if original command is in English locale. </summary>
  public ChatCommand WithLanguage(SupportedLanguage language);

  /// <summary>Checks if this command requires a user object to be executed.</summary>
  /// <returns>True if the command requres a user</returns>
  public bool CommandRequiresUser();
}
