// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.WorldGeneratorPlugin.WorldChatCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.WorldGeneratorPlugin;

[ChatCommandHandler]
public static class WorldChatCommands
{
  [ChatCommand("Shows commands related to world stuff.", ChatAuthorizationLevel.DevTier)]
  public static void World();

  [ChatSubCommand("world", "Generates the world block stats", ChatAuthorizationLevel.DevTier)]
  public static void GenerateStats();

  /// <summary>
  /// Calls the specified species type and visualizes the groupings and clusters with a 2d map within the client.
  /// Only usable after initial world generation and does not work after a server restart.
  /// </summary>
  /// <param name="user"></param>
  /// <param name="species"></param>
  [ChatSubCommand("world", "Shows initial spawn clusters of species", ChatAuthorizationLevel.Admin)]
  public static void Species(User user, string species);
}
