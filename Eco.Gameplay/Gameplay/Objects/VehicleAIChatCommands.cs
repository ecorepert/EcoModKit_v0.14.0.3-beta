// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.VehicleAIChatCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Objects;

[ChatCommandHandler]
internal class VehicleAIChatCommands
{
  [ChatSubCommand("Vehicle", "Spawn multiple vehicles in a line next to the player.", "sv", ChatAuthorizationLevel.DevTier)]
  public static void SpawnVehicles(User user, string vehicleType, int count = 1, float spacing = 10f);

  [ChatSubCommand("Vehicle", "Spawn all vehicles in a line (except boats).", "sav", ChatAuthorizationLevel.DevTier)]
  public static void SpawnAllVehicles(User user, float spacing = 15f);

  [ChatSubCommand("Vehicle", "List all available vehicle types.", "vlist", ChatAuthorizationLevel.DevTier)]
  public static void ListVehicles(User user);

  [ChatSubCommand("Vehicle", "Enable AI on the nearest vehicle. Creates waypoints if needed.", "vaion", ChatAuthorizationLevel.DevTier)]
  public static void EnableVehicleAI(User user, float searchRadius = 50f);

  [ChatSubCommand("Vehicle", "Disable AI on the nearest vehicle.", "vaioff", ChatAuthorizationLevel.DevTier)]
  public static void DisableVehicleAI(User user, float searchRadius = 50f);

  [ChatSubCommand("Vehicle", "Enable AI on all vehicles in range.", "avaion", ChatAuthorizationLevel.DevTier)]
  public static void EnableAllVehicleAI(User user, float searchRadius = 200f, int maxVehicles = 50);

  [ChatSubCommand("Vehicle", "Disable AI on all vehicles in range.", "avaioff", ChatAuthorizationLevel.DevTier)]
  public static void DisableAllVehicleAI(User user, float searchRadius = 200f);

  [ChatSubCommand("Vehicle", "Clear all AI from all vehicles globally.", "vaiclr", ChatAuthorizationLevel.DevTier)]
  public static void ClearAllVehicleAI(User user);

  [ChatSubCommand("Vehicle", "Remove all vehicles owned by you.", "vdeleteall", ChatAuthorizationLevel.DevTier)]
  public static void DeleteAllVehicles(User user);
}
