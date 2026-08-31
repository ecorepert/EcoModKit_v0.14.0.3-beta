// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.GameActionManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

/// <summary> Handles applying all the various things that might adjust or prevent actions, and outputs display of them. </summary>
/// <remarks> Laws, contracts, and auth all should work exclusively through this interface. </remarks>
public static class GameActionManager
{
  /// <summary> Saves locks for combination of game action type and action subject (defined by ISyncedAction). It means that it will prevent running at same time same action with same subject, like two action of pick up same world object. </summary>
  /// <remarks> It needs to be converted from tuple to GameActionLocker since tuple is value type, and locks works in base of reference (i.e. (object, type) would never prevent nothing, since each time when it's used it will just create new reference) </remarks>
  public static ConcurrentDictionary<object, GameActionPack> GameActionLockers;
  public static HashSet<User> UserOnlyDebugDisplay;
  public static HashSet<User> GlobalDebugDisplay;

  /// <summary> Passes the actions of specified pack through Laws and Auth Manager, and retrieves a failed/successful result. </summary>
  public static Result TryPerformActions(User userToNotify, GameActionPack pack);

  public static void DebugShowIfNeeded(User user, GameActionPack pack, Result result);

  public static void DebugShowIfNeeded(User user, Func<string> desc, Result result);

  public static bool CollectDebug(GameAction action);

  public static Result TryPerform(this GameActionPack pack, User userToNotify);

  public static Result TryPerform(this GameAction action, User userToNotify);
}
