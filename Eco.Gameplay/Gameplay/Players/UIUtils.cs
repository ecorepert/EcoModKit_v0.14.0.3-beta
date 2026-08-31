// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UIUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Utils;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Players;

public static class UIUtils
{
  public const string SharedIdBsonKey = "instance";

  public static void OpenUI(
    this Player player,
    IController ui,
    string uiName,
    string customKey = "UI",
    Action<BSONObject> configureBson = null);

  public static void CloseUI(this Player player, IController ui, string uiName);

  /// <summary>Tell every user we've tracked as using this thing to Close the given UI, passing the given bson (for specifying the instance etc)</summary>
  public static void CloseUIForAllPlayers(
    this IPlayerUseTracking tracker,
    string uiName,
    bool killCache,
    Func<Player, BSONObject> makeBson = null);

  /// <summary>Tell every user we've tracked as using this thing to skip the next cache update for the given UI (used when adding a component, so that the next time the UI is opened it will be refreshed).</summary>
  public static void SkipNextCacheForAllPlayers(
    this IPlayerUseTracking tracker,
    string uiName,
    Func<Player, BSONObject> makeBson = null);
}
