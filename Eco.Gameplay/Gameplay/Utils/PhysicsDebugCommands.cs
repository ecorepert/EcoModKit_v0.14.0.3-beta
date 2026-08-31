// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.PhysicsDebugCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Networking;

#nullable disable
namespace Eco.Gameplay.Utils;

/// <summary> Commands that are related to debugging physics and making failure tests. </summary>
[ChatCommandHandler]
public static class PhysicsDebugCommands
{
  [ChatCommand("Commands to aid in physics debugging.", ChatAuthorizationLevel.DevTier)]
  public static void PhysicsDebug(User user);

  /// <summary> Spawn 20 cars on a line so some of them are inside terrains and others aren't.</summary>
  [ChatSubCommand("Debug", "Spawn cars for physics testing", ChatAuthorizationLevel.DevTier)]
  public static void SpawnCars(User user);

  /// <summary> Make the vehicle the player is looking at underground to do physics failure tests. </summary>
  [ChatSubCommand("Debug", "Force the vehicle you are looking at to be underground, you need to be the physics controller of the car.", ChatAuthorizationLevel.DevTier)]
  public static void MakeUnderGround(User user, INetObject target);
}
