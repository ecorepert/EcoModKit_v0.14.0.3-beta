// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.CommandsUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Utils;

public static class CommandsUtil
{
  /// <summary> Get a matching item of the given type. If null is passed, get a random one.</summary>
  public static T ClosestMatchingItem<T>(IChatClient player, string entityName) where T : Item;

  /// <summary> Returns closest matching entities by <paramref name="entityName" /> from <paramref name="entityList" />. </summary>
  public static T ClosestMatchingEntity<T>(
    IChatClient chatClient,
    string entityName,
    IReadOnlyList<T> entityList,
    Func<T, string> getName,
    Func<T, LocString> getDisplayName,
    Predicate<T>? filter = null);

  /// <summary>Check if a player is online before applying action and tell if not</summary>
  public static bool CheckPlayerOnline(User user, User targetUser);

  public static List<WorldObjectItem> ItemsWithComponent(params Type[] args);

  /// <summary> Collects closest matching entries by <paramref name="entityName" /> from <paramref name="entityList" />.
  /// If 'preferExactMatch' is set, return exact match if it exists instead of list.</summary>
  public static List<T> CollectClosestMatchingEntries<T>(
    string entityName,
    IReadOnlyList<T> entityList,
    Func<T, string> getName,
    Func<T, LocString> getDisplayName,
    Predicate<T>? filter = null,
    bool preferExactMatch = true);

  /// <summary> Helper for getting items from worlobjects by component type with ALL passed types present </summary>
  public static List<WorldObjectItem> ItemsWithAllComponents(params Type[] args);
}
