// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementSpawner
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Settlements;

/// <summary>Spawns settlements with a variety of user decided options. Will become a source for a scenario spawner someday.</summary>
[ChatCommandHandler]
public static class SettlementSpawner
{
  [ChatSubCommand("Settlement", "Destroy all towns and property stakes and unclaim all property.", "cleartowns", ChatAuthorizationLevel.Admin)]
  public static void ClearAll(User user);

  [ChatSubCommand("Settlement", "Destroy all things related with the passed settlement and unclaim all property.", ChatAuthorizationLevel.Admin)]
  public static void Clear(User user, Settlement settlement);

  [ChatSubCommand("Settlement", "Spawn a debug set of settlements.", "testtown", ChatAuthorizationLevel.DevTier)]
  public static void Spawn(User user);
}
