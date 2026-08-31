// Decompiled with JetBrains decompiler
// Type: Eco.Mods.PollutionCommands
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
public static class PollutionCommands
{
  [ChatCommand("Shows commands for world pollution manipulation.", ChatAuthorizationLevel.Admin)]
  public static void Pollute(User user);

  [ChatSubCommand("Pollute", "Ticks garbage checks", "tg", ChatAuthorizationLevel.DevTier)]
  public static void TickGarbage(User user);

  [ChatSubCommand("Pollute", "Sets a pollution layer value (soil/heavymineral/chemical/acidrain), on your claim or on every claim within a radius.", ChatAuthorizationLevel.Admin)]
  public static void Set(User user, string type, float value = 1f, int radius = 0);

  [ChatSubCommand("Pollute", "Removes all pollution of one layer (soil/heavymineral/chemical/acidrain), on your claim or within a radius.", ChatAuthorizationLevel.Admin)]
  public static void Clear(User user, string type, int radius = 0);

  [ChatSubCommand("Pollute", "Queues decontamination of a pollution layer (soil/heavymineral/chemical), on your claim or within a radius.", "decon", ChatAuthorizationLevel.Admin)]
  public static void Decon(User user, string type, float value = 1f, int radius = 0);

  [ChatSubCommand("Pollute", "Sets the queued decontamination (soil/heavymineral/chemical), on your claim or within a radius.", ChatAuthorizationLevel.Admin)]
  public static void SetDecon(User user, string type, float value = 1f, int radius = 0);

  [ChatSubCommand("Pollute", "Dumps pollution values for the claim you're standing on.", "info", ChatAuthorizationLevel.Admin)]
  public static void Info(User user);

  [ChatSubCommand("Pollute", "Clears all pollution layers and the buffer cache (resets the pollution system).", "wipe", ChatAuthorizationLevel.Admin)]
  public static void Wipe(User user);

  [ChatSubCommand("Pollute", "Just in case you like living in TRASH CITY", ChatAuthorizationLevel.Admin)]
  public static void TrashCity(User user);

  [ChatSubCommand("Pollute", "Creates X tons of air pollution", ChatAuthorizationLevel.Admin)]
  public static void Air(User user, float tons);

  [ChatSubCommand("Pollute", "Changes CO2 PPM by X", ChatAuthorizationLevel.Admin)]
  public static void CO2(User user, float ppm);

  [CITest(false)]
  [ChatSubCommand("Pollute", "Rains tailings from the heavens to ruin the world", ChatAuthorizationLevel.Admin)]
  public static void All(User user);

  [CITest(false)]
  [ChatSubCommand("Pollute", "Creates AIR POLLUTION MACHINES OF DOOM", "apgen", ChatAuthorizationLevel.DevTier)]
  public static void AirPollutionGenerators(User user);
}
