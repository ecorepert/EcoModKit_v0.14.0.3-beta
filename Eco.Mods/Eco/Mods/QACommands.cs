// Decompiled with JetBrains decompiler
// Type: Eco.Mods.QACommands
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Mods;

[ChatCommandHandler]
public static class QACommands
{
  [ChatSubCommand("Build", "Spawn all doors.", ChatAuthorizationLevel.DevTier)]
  public static void Doors(User user);

  [ChatSubCommand("Build", "Spawn all signs and add a random text to it.", ChatAuthorizationLevel.DevTier)]
  public static void Signs(User user, int textLengthMin = 3, int textLengthMax = 40);

  [ChatSubCommand("Preset", "Spawn storage with all type of doors", ChatAuthorizationLevel.DevTier)]
  public static void Doors(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns storage with sign containing items", ChatAuthorizationLevel.DevTier)]
  public static void Signs(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns storage with bed items", ChatAuthorizationLevel.DevTier)]
  public static void Beds(User user, int sType = 0);

  [ChatSubCommand("Land", "Spawns a corridor-like tunnel that gives entrance to the mines.", "spawnMines", ChatAuthorizationLevel.DevTier)]
  public static void SpawnMines(
    User user,
    int corridorWidth = 1,
    int corridorHeight = 3,
    int corridorDepth = 1,
    int depth = 100,
    int levelDifferenceHeight = 1);
}
