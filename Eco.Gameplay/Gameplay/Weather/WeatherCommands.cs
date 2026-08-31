// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Weather.WeatherCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Weather;

[ChatCommandHandler]
internal static class WeatherCommands
{
  [ChatCommand("Shows commands for manipulations weather.", ChatAuthorizationLevel.Admin)]
  public static void Weather();

  [ChatSubCommand("Weather", "Prints out the current weather status", ChatAuthorizationLevel.Admin)]
  public static void Status(IChatClient client);

  [ChatSubCommand("Weather", "Create a light rain", ChatAuthorizationLevel.Admin)]
  public static void Rain(User user);

  [ChatSubCommand("Weather", "Create a heavy rain storm", ChatAuthorizationLevel.Admin)]
  public static void HeavyRain(User user);

  [ChatSubCommand("Weather", "Create some clouds", ChatAuthorizationLevel.Admin)]
  public static void Cloudy(User user);

  [ChatSubCommand("Weather", "Create some fog", ChatAuthorizationLevel.Admin)]
  public static void Foggy(User user);

  [ChatSubCommand("Weather", "Clear all weather", ChatAuthorizationLevel.Admin)]
  public static void Clear(User user);
}
