// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Profiling.ProfilingChatCommands
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable enable
namespace Eco.Plugins.Profiling;

[ChatCommandHandler]
public static class ProfilingChatCommands
{
  [ChatCommand("Shows commands to profile the server and generate diagnostic data.", ChatAuthorizationLevel.Admin)]
  public static void Profiler(
  #nullable disable
  IChatClient client);

  [ChatSubCommand("Profiler", "Collects memory dump.", ChatAuthorizationLevel.Admin)]
  public static void Memory(IChatClient client);

  [ChatSubCommand("Profiler", "Runs CPU profiling using dottrace. Optionally pass duration in seconds, defaults to 60 seconds.", ChatAuthorizationLevel.Admin)]
  public static void CPU(IChatClient client, int seconds = 60);

  [ChatSubCommand("Profiler", "Runs CPU profiling using nettrace. Optionally pass duration in seconds, defaults to 60 seconds.", ChatAuthorizationLevel.Admin)]
  public static void NetTrace(IChatClient client, int seconds = 60);

  [ChatSubCommand("Profiler", "Runs CPU profiling and server performance reports, one after the other. Optionally pass duration in seconds, defaults to 60 seconds.", ChatAuthorizationLevel.Admin)]
  public static void Everything(IChatClient client, int seconds = 60);

  [ChatCommand("Runs server performance reports and dump to files. Optionally pass duration in seconds, defaults to 60 seconds.", ChatAuthorizationLevel.Admin)]
  public static void Performance(IChatClient client, int seconds = 60);

  public static void DumpPerformanceReports(IChatClient client);

  [ChatSubCommand("Profiler", "Opens results page in web browser.", ChatAuthorizationLevel.Admin)]
  public static void Results(User user);

  [ChatSubCommand("Profiler", "Records controller notification fan-out and writes a sorted report to Logs/NotificationStats. Optionally pass duration in seconds, defaults to 180 seconds.", ChatAuthorizationLevel.Admin)]
  public static void NotificationStats(IChatClient client, int seconds = 180);
}
