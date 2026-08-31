// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.GarbageCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Garbage;

[ChatCommandHandler]
public static class GarbageCommands
{
  [ChatCommand("Performs a variety of garbage operations.", ChatAuthorizationLevel.Admin)]
  public static void Garbage(IChatClient chatClient);

  [ChatSubCommand("Garbage", "Give N full stacks of MixedGarbageItem, each with a distinct random repartition over 2..5 GarbageMaterials drawn at random. Targets the nearest storage within searchRadius, falling back to the player's inventory.", ChatAuthorizationLevel.Admin)]
  public static void RandomMixed(User user, int stacks, float searchRadius = 5f);

  [ChatSubCommand("Garbage", "Give garbage with specific internal repartition. Format: TypeA:0.1;TypeB:0.9", ChatAuthorizationLevel.Admin)]
  public static void Give(User user, string garbages, int quantity);
}
