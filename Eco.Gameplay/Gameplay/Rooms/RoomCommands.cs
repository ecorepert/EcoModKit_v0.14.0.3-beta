// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Rooms.RoomCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Rooms;

[ChatCommandHandler]
public static class RoomCommands
{
  [ChatCommand("Shows commands for rooms manipulations.")]
  public static void Rooms(User user);

  [ChatSubCommand("Rooms", "Detailed diagnostic information about the current surroundings to see if it's a room, and if not explain why not. Recalculate outdoor area.", ChatAuthorizationLevel.User)]
  public static void Test(User user);

  [ChatSubCommand("Rooms", "Creates two adjacent test rooms that share a wall with a doorway between them, and gives each room its own exterior door.", ChatAuthorizationLevel.DevTier)]
  public static bool AdjacentRooms(
    User user,
    int tier = 1,
    int width = 5,
    int height = 4,
    int depth = 5,
    bool windows = false);

  [ChatSubCommand("Rooms", "Repairs all broken rooms. This command may take a long time and create heavy-load on the server, so only use it when many rooms are broken", ChatAuthorizationLevel.Admin)]
  public static void RepairAll();

  [ChatSubCommand("Rooms", "Place a marker block at a coordinate and print column info (top-solid Y, top block). Useful for chasing 'no ceiling' failures. Smite to remove.", ChatAuthorizationLevel.Admin)]
  public static void Highlight(User user, int x, int y, int z);

  public static bool Process(string command, string args, Player player);
}
