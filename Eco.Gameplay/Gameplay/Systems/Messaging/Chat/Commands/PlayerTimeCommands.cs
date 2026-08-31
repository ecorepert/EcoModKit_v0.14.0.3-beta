// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.PlayerTimeCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

/// <summary>Per-player mirror of /time: changes the sky for the calling player only, for screenshots/testing. Purely visual, not shared, gone on reconnect or on any /time change.</summary>
[ChatCommandHandler]
public static class PlayerTimeCommands
{
  [ChatCommand("List of commands to change the time of day for yourself only.", ChatAuthorizationLevel.User)]
  public static void MyTime(User user);

  [ChatSubCommand("MyTime", "Stop the sun where it currently is, for you only.", ChatAuthorizationLevel.User)]
  public static void Freeze(User user);

  [ChatSubCommand("MyTime", "Start your sun moving again from where you stopped it.", ChatAuthorizationLevel.User)]
  public static void Resume(User user);

  [ChatSubCommand("MyTime", "Put your sky back on the shared world time.", ChatAuthorizationLevel.User)]
  public static void Reset(User user);

  [ChatSubCommand("MyTime", "Move the sun to noon, for you only.", ChatAuthorizationLevel.User)]
  public static void Noon(User user);

  [ChatSubCommand("MyTime", "Move the sun to midnight, for you only.", ChatAuthorizationLevel.User)]
  public static void Midnight(User user);

  [ChatSubCommand("MyTime", "Move the sun to the specified hour, for you only.", ChatAuthorizationLevel.User)]
  public static void Set(User user, float hour);
}
