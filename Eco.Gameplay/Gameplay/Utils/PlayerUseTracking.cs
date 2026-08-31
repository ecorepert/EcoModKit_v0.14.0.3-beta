// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.PlayerUseTracking
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using System;

#nullable enable
namespace Eco.Gameplay.Utils;

public static class PlayerUseTracking
{
  [RPC(AccessType.None)]
  public static void IncrementUsing(this 
  #nullable disable
  IPlayerUseTracking players, Player player);

  [RPC(AccessType.None)]
  public static void DecrementUsing(this IPlayerUseTracking players, Player player);

  /// <summary>Clear the object from all the players that are currently using it.</summary>
  public static void ClearAllPlayers(this IPlayerUseTracking players);

  public static void ForEachPlayer(this IPlayerUseTracking players, Action<Player> action);

  /// <summary>Check whether the current object is being used by a player.</summary>
  public static bool IsBeingUsed(this IPlayerUseTracking playerTracker);

  /// <summary> Returns the names of the players on the UsingPlayers list </summary>
  public static string GetPlayersNames(this IPlayerUseTracking playerTracker);
}
