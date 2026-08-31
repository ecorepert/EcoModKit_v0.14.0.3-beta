// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.TooltipUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Eco.Gameplay.Utils;

public static class TooltipUtil
{
  /// <summary>Rows of "quantity  icon+name": the label column starts a space after the widest quantity so the icons align vertically while the
  /// quantities keep proportional rendering (monospacing them pads narrow glyphs like decimal separators). Each quantity is styled per row.</summary>
  public static LocString AlignedQuantityList(
    this IReadOnlyCollection<(string Amount, Eco.Shared.Utils.Text.Styles Style, LocString Label)> rows);

  public static LocString MakeListLoc(
    this IEnumerable<ILinkable> strings,
    FormattableString title,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static LocString MakeListLoc(
    this IEnumerable<LocString> strings,
    FormattableString title,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static LocString MakeListLoc(
    this IEnumerable<string> strings,
    FormattableString title,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static LocString MakeList(
    this IEnumerable<LocString> strings,
    LocString title,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static StringBuilder AppendList(
    this StringBuilder s,
    LocString title,
    IEnumerable<LocString> list,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static StringBuilder AppendList(
    this StringBuilder s,
    LocString title,
    IEnumerable<ILinkable> list,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static StringBuilder AppendListLoc(
    this StringBuilder s,
    FormattableString title,
    IEnumerable<ILinkable> list,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static StringBuilder AppendListLoc(
    this StringBuilder s,
    FormattableString title,
    IEnumerable<string> list,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static StringBuilder AppendList(
    this StringBuilder s,
    LocString title,
    IEnumerable<string> list,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static LocString MakeInlineFoldoutListLoc(
    this IEnumerable<ILinkable> list,
    LocString title,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static LocString CommaList(this IEnumerable<ILinkable> phrases);

  public static TooltipSection MakeTooltipSectionFoldOut(
    LocString title,
    IEnumerable<LocString> items,
    LocString nounSingular,
    TooltipOrigin origin);

  public static TooltipSection MakeTooltipSectionNewlineList(
    LocString title,
    IEnumerable<LocString> items);

  public static TooltipSection MakeTooltipSectionLoc(
    this IEnumerable<ILinkable> strings,
    FormattableString title);

  public static LocString ListOrSingleLine(this IEnumerable<LocString> strings);

  public static string People(int count);
}
