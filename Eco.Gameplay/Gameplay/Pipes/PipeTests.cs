// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.PipeTests
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Math;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Pipes;

[ChatCommandHandler]
public static class PipeTests
{
  [CITest(false)]
  [ChatSubCommand("Test", "Spawns a setup for testing pipes.", ChatAuthorizationLevel.DevTier)]
  public static void Pipes(
  #nullable disable
  User user);

  [ChatSubCommand("Test", "Spawns a setup for testing sewage system.", ChatAuthorizationLevel.DevTier)]
  public static Task Sewage(User user, bool village = false);

  public static void SpawnSewage(
    User user,
    Vector3i startAboveGroundPos,
    bool spawnFullVillage,
    ref WorldObject filter,
    ref WorldObject furnace);

  public static Vector3i PipeTo(Vector3i start, Vector3i end, Type pipeType = null, int underground = 0);

  public static Vector3i SpawnPump(User user, Vector3i groundPos);

  public static Vector3i SpawnElectricPump(User user, Vector3i groundPos);
}
