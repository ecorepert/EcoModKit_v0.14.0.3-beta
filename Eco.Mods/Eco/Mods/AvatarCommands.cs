// Decompiled with JetBrains decompiler
// Type: Eco.Mods.AvatarCommands
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Mods;

[ChatCommandHandler]
public static class AvatarCommands
{
  [ChatCommand("Shows commands for avatars manipulation.")]
  public static void Avatar(User user);

  [CITest(true)]
  [ChatSubCommand("Avatar", "Spawns a dummy avatar", ChatAuthorizationLevel.DevTier)]
  public static void Dummy(User user, int count = 1);

  [CITest(true)]
  [ChatSubCommand("Avatar", "Spawns passed number of clones of your avatar", ChatAuthorizationLevel.DevTier)]
  public static void MeTime(User user, int count = 1);

  [CITest(true)]
  [ChatSubCommand("Avatar", "Kills all spawned dummys", ChatAuthorizationLevel.DevTier)]
  public static void LastPlayerOnEarth();

  [CITest(true)]
  [ChatSubCommand("Avatar", "Toggles Third Person Camera", ChatAuthorizationLevel.User)]
  public static void ThirdPerson(User user);

  [ChatSubCommand("Avatar", "Enables unrestricted avatar customization in game", ChatAuthorizationLevel.DevTier)]
  public static void Customize(User user);

  public static Player MakeDummy(Player player, User sourceUser = null);
}
