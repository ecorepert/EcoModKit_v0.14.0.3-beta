// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

public static class TooltipExtensions
{
  public static LocString FoldoutListLoc(
    this IEnumerable<LocString> list,
    string itemNounSingular,
    TooltipOrigin origin,
    int max = 5,
    string joinString = "\n");

  public static LocString FoldoutList(
    this IEnumerable<LocString> @this,
    LocString itemNounSingular,
    TooltipOrigin origin,
    int max = 5,
    string joinString = "\n");

  public static LocString InlineFoldoutListLoc(
    this IEnumerable<LocString> list,
    string itemNounSingular,
    TooltipOrigin origin,
    int max = 5);

  public static LocString InlineFoldoutList(
    this IEnumerable<LocString> list,
    LocString itemNounSingular,
    TooltipOrigin origin,
    int max = 5);

  public static LocString FoldoutLink(
    this IEnumerable<LocString> list,
    LocString foldoutLinkText,
    LocString itemNounSingular);

  [RPC]
  public static LocString GetTypeTooltipUILink(this Player player, string typeName);
}
