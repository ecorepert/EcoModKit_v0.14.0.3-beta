// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.TextLoc
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Icons;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Localization;

public class TextLoc
{
  public static LocString InfoLoc(FormattableString text);

  public static LocString InfoLightLoc(FormattableString text);

  public static LocString ErrorLoc(FormattableString text);

  public static LocString ErrorLightLoc(FormattableString text);

  public static LocString WhisperLightLoc(FormattableString text);

  public static LocString NameLoc(FormattableString text);

  public static LocString ControlsLoc(FormattableString text);

  /// <summary>Creates <see cref="T:Eco.Shared.Localization.LocString" /> from <paramref name="text" /> surrounded with <paramref name="prefix" /> and <paramref name="suffix" />. I.e. <c>ControlsLoc($"Click {buttonName}", "[", "]")</c> same as <c>Localizer.Do("Click {buttonName}").Wrap("[", "]").Style(Text.Styles.Controls)</c>.</summary>
  public static LocString ControlsLoc(string text, string prefix, string suffix);

  public static LocString ItemLoc(FormattableString text);

  public static LocString PositiveLoc(FormattableString text);

  public static LocString NegativeLoc(FormattableString text);

  public static LocString WarningLoc(FormattableString text);

  public static LocString BonusLoc(FormattableString text);

  public static LocString SubtextLoc(FormattableString text);

  public static LocString HeaderLoc(FormattableString text);

  public static LocString ChatTagLoc(FormattableString text);

  public static LocString ChatTagReadOnlyLoc(FormattableString text);

  public static LocString ControlsBracketsLoc(FormattableString text);

  public static LocString StyleLoc(Text.Styles s, FormattableString inner);

  public static LocString StyleNL(Text.Styles s, string inner);

  public static LocString Style(Text.Styles s, LocString inner);

  public static LocString StyledNumLoc(float v, string formattedV);

  public static LocString StyledNum(float v);

  public static LocString StyledInt(int v);

  public static LocString StyledBenefit(float v, bool lowerIsBetter = false);

  public static LocString StyledBenefitPercent(float v, bool lowerIsBetter = false, bool showPosSign = true);

  public static LocString ColorUnityLoc(uint hexCode, FormattableString inner);

  public static LocString Color(Eco.Shared.Utils.Color color, LocString inner);

  public static LocString Color(string hexCodeRGBA, LocString inner);

  public static LocString ColorLoc(string hexCodeRGBA, FormattableString inner);

  public static LocString ColorLoc(Eco.Shared.Utils.Color color, FormattableString inner);

  public static LocString PosLoc(int position, FormattableString inner);

  public static LocString IndentLoc(FormattableString inner, int indentDepth = 1);

  public static LocString IconLoc(string iconName, FormattableString inner);

  public static LocString IconLoc(IconUtils.SymbolicIcons icon, FormattableString inner);

  public static LocString IconLocNL(string iconName, FormattableString inner);

  public static LocString IconLocNL(IconUtils.SymbolicIcons icon, FormattableString inner);

  public static LocString IconLocNLS(string iconName, string inner);

  public static LocString IconLocNLS(IconUtils.SymbolicIcons icon, string inner);

  public static LocString BoldLoc(FormattableString inner);

  public static LocString ItalicsLoc(FormattableString inner);

  public static LocString UnderlineLoc(FormattableString inner);

  public static LocString SizeLoc(int size, FormattableString inner);

  public static LocString SizeLoc(float percent, FormattableString inner);

  public static LocString SubLoc(FormattableString inner);

  public static LocString SupLoc(FormattableString inner);

  public static LocString NonBreakingLoc(FormattableString inner);

  public static LocString Link(LocString inner, string id);

  public static LocString LinkLoc(FormattableString inner, string id);

  public static LocString GovernmentLoc(FormattableString inner);

  public static LocString SpecialAccessLoc(FormattableString inner);

  public static LocString InfoLocStr(string text);

  public static LocString InfoBoldLocStr(string text);

  public static LocString InfoLightLocStr(string text);

  public static LocString ErrorLocStr(string text);

  public static LocString ErrorLightLocStr(string text);

  public static LocString WhisperLightLocStr(string text);

  public static LocString NameLocStr(string text);

  public static LocString ControlsLocStr(string text);

  /// <summary>Creates <see cref="T:Eco.Shared.Localization.LocString" /> from <paramref name="text" /> surrounded with <paramref name="prefix" /> and <paramref name="suffix" />. I.e. <c>ControlsLocStr("Click here", "[", "]")</c> same as <c>Localizer.DoStr("Click here").Wrap("[", "]").Style(Text.Styles.Controls)</c>.</summary>
  public static LocString ControlsLocStr(string text, string prefix, string suffix);

  public static LocString ItemLocStr(string text);

  public static LocString PositiveLocStr(string text);

  public static LocString NegativeLocStr(string text);

  public static LocString WarningLocStr(string text);

  public static LocString BonusLocStr(string text);

  public static LocString SubtextLocStr(string text);

  public static LocString HeaderLocStr(string text);

  public static LocString ChatTagLocStr(string text);

  public static LocString ChatTagReadOnlyLocStr(string text);

  public static LocString CurrencyLocStr(string text);

  public static LocString CurrencyLocStr(string text, float val);

  public static LocString GovernmentLoc(string text);

  public static LocString ControlsBracketsLocStr(string text);

  public static LocString StyleLocStr(Text.Styles s, string inner);

  public static LocString ColorUnityLocStr(uint hexCode, string inner);

  public static LocString ColorLocStr(string hexCodeRGBA, string inner);

  public static LocString ColorLocStr(Eco.Shared.Utils.Color color, string inner);

  public static LocString PosLocStr(int position, string inner);

  public static LocString IndentLocStr(string inner, int indentDepth = 1);

  public static LocString BoldLocStr(string inner);

  public static LocString ItalicsLocStr(string inner);

  public static LocString UnderlineLocStr(string inner);

  public static LocString Size(int size, LocString text);

  public static LocString SizeLocStr(int size, string inner);

  public static LocString SizeLocStr(float percent, string inner);

  public static LocString SubLocStr(string inner);

  public static LocString SupLocStr(string inner);

  public static LocString NonBreakingLocStr(string inner);

  public static LocString Foldout(
    LocString linktext,
    LocString foldouttitle,
    LocString foldoutcontent);

  public static LocString FoldoutLoc(
    FormattableString linktext,
    FormattableString foldouttitle,
    LocString foldoutcontent);

  public static LocString FoldoutNotLocalizedStr(
    string linktext,
    string foldouttitle,
    LocString foldoutcontent);

  public static LocString FoldoutNotLocalized(
    FormattableString linktext,
    FormattableString foldouttitle,
    LocString foldoutcontent);

  public static LocString FoldoutNotLocalized(
    FormattableString linktext,
    FormattableString foldouttitle,
    FormattableString foldoutcontent);

  public static LocString FoldoutNoUnderline(
    LocString linktext,
    LocString foldouttitle,
    LocString foldoutcontent);

  public static LocString RPCButton(
    LocString linktext,
    string linkID,
    string rpcName,
    Eco.Shared.Utils.Color color,
    int size = 40,
    params string[] args);

  public static LocString RPCButtonLoc(
    FormattableString linktext,
    string linkID,
    string rpcName,
    Eco.Shared.Utils.Color color,
    int size = 40,
    params string[] args);

  public static LocString RPCButtonLocStr(
    string linktext,
    string linkID,
    string rpcName,
    Eco.Shared.Utils.Color color,
    int size = 40,
    params string[] args);

  public static LocString RPCButton(
    LocString linktext,
    string linkID,
    string rpcName,
    string color = "E0D8BD10",
    int size = 40,
    params string[] args);

  public static LocString RPCButtonLoc(
    FormattableString linktext,
    string linkID,
    string rpcName,
    string color = "E0D8BD10",
    int size = 40,
    params string[] args);

  public static LocString RPCButtonLocStr(
    string linktext,
    string linkID,
    string rpcName,
    string color = "E0D8BD10",
    int size = 40,
    params string[] args);

  public static LocString BankAccount(string text);

  public static LocString Title(string text);

  public static LocString Government(string text);

  public static LocString Currency(string text);

  public static LocString Currency(string text, float val);

  public static LocString Currency(LocString text);

  public static LocString Currency(LocString text, float val);

  public static LocString CurrencyNoBold(string text, float val);

  public static LocString CurrencyNoBoldRed(string text, float val);

  public static LocString CurrencyNoBold(LocString text, float val);

  public static LocString CurrencyNoBoldRed(LocString text, float val);

  public static LocString Icon(string iconName, LocString text = default (LocString), string type = "");

  public static LocString Icon(string iconName, LocString text, uint colorHexCode, string type = "");

  public static LocString IconOverlay(
    string iconName,
    LocString text,
    string overlayIcon,
    string colorHexCode,
    string type = "");

  public static LocString Icon(IconUtils.SymbolicIcons icon, LocString text = default (LocString), string type = "");

  public static LocString Icon(
    IconUtils.SymbolicIcons icon,
    LocString text,
    uint colorHexCode,
    string type = "");

  public static LocString Header(LocString text);

  public static LocString Info(LocString text);

  public static LocString InfoLight(LocString text);

  public static LocString Warning(LocString text);

  public static LocString Error(LocString text);

  public static LocString ErrorLight(LocString text);

  public static LocString WhisperLight(LocString text);

  public static LocString Item(LocString text);

  public static LocString Recipe(LocString text);

  public static LocString Indent(LocString text, int indentDepth = 1);

  public static LocString Pos(int position, LocString text);

  public static LocString Subtext(LocString text);

  public static LocString Bold(LocString text);

  public static LocString Italics(LocString text);

  /// <summary> Creates localized text table with tags from 2D LocString IEnumerable </summary>
  public static LocString Table(IEnumerable<IEnumerable<LocString>> stringsTable);
}
