// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Emotes.EmoteCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Systems.Emotes;

[ChatCommandHandler]
public class EmoteCommands
{
  [ChatCommand("Shows commands for performing an animated emote.")]
  public static void Emotes(User user);

  [ChatCommand("Starts emote with provided name", "e", ChatAuthorizationLevel.User)]
  public static void Emote(User user, string emoteRaw);

  [ChatSubCommand("Emotes", "Smile", "Smile", ChatAuthorizationLevel.User)]
  public static void Smile(User user);

  [ChatSubCommand("Emotes", "Dance", "Dance", ChatAuthorizationLevel.User)]
  public static void Dance(User user);

  [ChatSubCommand("Emotes", "Laugh", "Laugh", ChatAuthorizationLevel.User)]
  public static void Laugh(User user);

  [ChatSubCommand("Emotes", "Wave", "Wave", ChatAuthorizationLevel.User)]
  public static void Wave(User user);
}
