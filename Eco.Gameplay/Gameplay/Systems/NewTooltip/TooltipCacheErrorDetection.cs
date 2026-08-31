// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipCacheErrorDetection
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip;

[ChatCommandHandler]
public class TooltipCacheErrorDetection
{
  /// <summary>Contains all parts for a given type.</summary>
  public static 
  #nullable disable
  Dictionary<Type, List<TooltipPartBase>> TypeToTooltips;

  [ChatSubCommand("QA", "Clear server and client tooltip caches for all users.", "ttc", ChatAuthorizationLevel.DevTier)]
  public static void TooltipClearCache(User user);

  public static void DoCacheClear();

  public static void DoPeriodicErrorCheck();

  [ChatSubCommand("QA", "Display stats on tooltip debug.", ChatAuthorizationLevel.DevTier)]
  public static void TooltipStatus(User user);

  public static (int StringCount, int TotalSizeBytes) GetDebugStatsForPart(
    TooltipPartBase part,
    List<LocString> results);

  public static void CheckForErrorsWithUserCachedTooltips(List<LocString> results);

  public static void OnPartCached(
    TooltipPartBase part,
    User user,
    IController controller,
    string text);

  internal static void OnCacheValueReturned(
    TooltipPartBase part,
    User user,
    IController controller,
    TooltipOrigin origin,
    string cachedText);
}
