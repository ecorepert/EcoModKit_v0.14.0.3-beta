// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.PlayerWeatherCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

/// <summary>Per-player mirror of /weather: changes the weather visuals for the calling player only, for screenshots/testing. Purely visual, not shared, gone on reconnect or on any /weather change.</summary>
[ChatCommandHandler]
public static class PlayerWeatherCommands
{
  [ChatCommand("List of commands to change the weather for yourself only.", ChatAuthorizationLevel.User)]
  public static void MyWeather(User user);

  [ChatSubCommand("MyWeather", "Clear the weather, for you only.", ChatAuthorizationLevel.User)]
  public static void Clear(User user);

  [ChatSubCommand("MyWeather", "Create a light rain, for you only.", ChatAuthorizationLevel.User)]
  public static void Rain(User user);

  [ChatSubCommand("MyWeather", "Create a heavy rain storm, for you only.", ChatAuthorizationLevel.User)]
  public static void HeavyRain(User user);

  [ChatSubCommand("MyWeather", "Create some clouds, for you only.", ChatAuthorizationLevel.User)]
  public static void Cloudy(User user);

  [ChatSubCommand("MyWeather", "Create some fog, for you only.", ChatAuthorizationLevel.User)]
  public static void Foggy(User user);

  [ChatSubCommand("MyWeather", "Put your weather back on the shared server weather.", ChatAuthorizationLevel.User)]
  public static void Reset(User user);
}
