// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.UserCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable enable
namespace Eco.Gameplay.Utils;

[ChatCommandHandler]
public static class UserCommands
{
  [ChatCommand("Commands to aid in debugging.", ChatAuthorizationLevel.DevTier)]
  public static void Debug(
  #nullable disable
  User user);

  [ChatSubCommand("Debug", "Trigger a validity scan of all objects.", "scanall", ChatAuthorizationLevel.Admin)]
  public static void ScanAll(User user);

  [ChatSubCommand("Debug", "Trigger a breakpoint.", "break", ChatAuthorizationLevel.DevTier)]
  public static void Break(User user);

  [ChatSubCommand("Debug", "Set the wrap-around-the-world count for the calling player.  This is a client side effect that makes the positions after traveling around the world be shifted by world-size.", "wrap", ChatAuthorizationLevel.DevTier)]
  public static void Wrap(User user, int xWrap = 1, int yWrap = 1);

  [ChatSubCommand("Debug", "Check every object in scene making / sure they have the correct position, inform and disable them otherwise.", "checkobjects", ChatAuthorizationLevel.User)]
  public static void CheckObjectsPositions(User user);

  [ChatSubCommand("Debug", "Delete all blocks above-ground that are constructed, delete all constructed world objects, remove all property, destroy all settlements and related objects.", "eden", ChatAuthorizationLevel.DevTier)]
  public static void Reset(User user);
}
