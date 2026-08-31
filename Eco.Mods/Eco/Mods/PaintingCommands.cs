// Decompiled with JetBrains decompiler
// Type: Eco.Mods.PaintingCommands
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Mods;

[ChatCommandHandler]
public class PaintingCommands
{
  [ChatSubCommand("Inventory", "Give yourself mixed paint for predefined named colors", "paint", ChatAuthorizationLevel.Admin)]
  public static void GivePaint(User user, int namedColorIndex, int number = 1);

  [ChatSubCommand("Land", "Clears paint in area with radius specified around the player. Max = 20", ChatAuthorizationLevel.Admin)]
  public static void ClearPaint(User user, int radius = 4);

  [ChatSubCommand("Inventory", "Give yourself mixed paint with any rgb color", "paintrgb", ChatAuthorizationLevel.Admin)]
  public static void GivePaintRGB(User user, int r, int g, int b, int amount = 1);

  [ChatSubCommand("Preset", "Lots of different paint buckets for test", ChatAuthorizationLevel.DevTier)]
  public static void Paint(User user, int stackCount = 5);

  [ChatSubCommand("Land", "Spawns giant walls and paints them with random colors", "painttest", ChatAuthorizationLevel.Admin)]
  public static void PaintTest(User user, int size = 50, int walls = 5);

  [ChatSubCommand("Room", "Test painted block housing value by checking current room", "testpaintedroom", ChatAuthorizationLevel.Admin)]
  public static void TestPaintedRoom(User user);

  [ChatSubCommand("Room", "Paint all constructed blocks within radius to specified color", "paintaround", ChatAuthorizationLevel.Admin)]
  public static void PaintAround(User user, string colorName, int radius = 10);
}
