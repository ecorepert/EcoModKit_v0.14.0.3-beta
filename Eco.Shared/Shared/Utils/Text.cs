// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Text
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Icons;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Utils;

public static class Text
{
  public const string DetailedPercentFormat = "0.##%";
  public const string PercentFormat = "0%";
  public const string NumberFormat = "#,##0.##";
  public const string CurrencyFormat = "0.00";
  public const string IntegerFormat = "n0";
  public const int ReadingSpeed = 50;
  public const float MinmumReadingTime = 5f;
  public const float BigText = 1.1f;
  public const int SignedNumDigits = 2;
  public const float MonoSize = 0.5f;
  public static CultureInfo DefaultCulture;
  public static CultureInfo USCulture;

  public static string Info(object text);

  public static string InfoLight(object text);

  public static string Error(object text);

  public static string ErrorLight(object text);

  public static string WhisperLight(object text);

  public static string Name(object text);

  public static string Controls(object text);

  public static string Item(object text);

  public static string Recipe(object text);

  public static string Positive(object text);

  public static string Negative(object text);

  public static string Warning(object text);

  public static string Bonus(object text);

  public static string Subtext(object text);

  public static string Header(object text);

  public static string ChatTag(object text);

  public static string ChatTagReadOnly(object text);

  public static string ChatTime(object text);

  public static string EcoCredits(float val);

  public static string EcoCreditsNoText(float val);

  public static string Currency(float val);

  public static string Currency(object text, float val);

  public static string Currency(object text);

  public static string CurrencySymbolNoStyle(object v);

  public static string CurrencyWithSymbolNoStyle(float val);

  public static string CurrencyNoSymbol(float val);

  public static string CurrencyNoSymbol(object text, float val);

  public static string BankAccount(object text);

  public static string Dollar(float val);

  public static string FormatCurrencySmart(float value);

  /// <summary> Returns styled number with forded sign ('+' - for positive, '-' - for negative, no sign for zero). If <paramref name="invertHighlight" /> set then it will use negative highlight for positive value. </summary>
  public static string SignedNum(float v, bool invertHighlight = false, bool useColors = true);

  /// <summary> Returns styled number with forded sign and $ symbol ('+$' for positive, '-$' for negative, no sing for zero). If <paramref name="invertHighlight" /> set then it will use negative highlight for positive value. </summary>
  public static string CurrencySignedNum(float v, bool invertHighlight = false);

  /// <summary> Check if number is different than 0 after formatting </summary>
  public static bool IsZeroAfterRounding(float v, int digits = 2);

  public static string Num(int v);

  public static string Num(float v);

  public static string Num(double v);

  public static string Num(float v, string format);

  public static string Num(double v, string format);

  public static string Percent(float v, bool showPosSign = false);

  public static string DetailedPercent(float v, bool showPosSign = false);

  public static string Int(float v);

  public static string Int(double v);

  public static string StyledNum(this int v);

  public static string StyledNum(this float v);

  public static string StyledPosNeg(this float v);

  /// <summary>Displays a styled number, but using negative coloring.</summary>
  public static string StyledNegativeNum(float v);

  public static string StyledDetailedPercent(this float v, bool showPosSign = false);

  public static string StyledDetailedPercent(this Decimal v, bool showPosSign = false);

  public static string StyledPercent(this float v, bool showPosSign = false);

  public static string StyledPercent(this Decimal v, bool showPosSign = false);

  public static string StyledNegativePercent(this float v, bool showPosSign = false);

  public static string StyledPosNegPercent(this float v);

  public static string StyledBenefit(this float v, bool lowerIsBetter = false);

  public static string StyledBenefitPercent(this float v, bool lowerIsBetter = false, bool showPosSign = true);

  public static string StyledInt(float v);

  public static string StyledInt(this int v);

  /// <summary> Styles originally negative numbers in red (negative style) while removing the negative sign from the output.</summary>
  public static string StyledIntUnsigned(this float v);

  public static string StyledInt(Text.Styles s, float inner);

  public static string StyledNum(this int v, string formattedV);

  public static string StyledNum(this float v, string formattedV);

  public static string StyledNegativeNum(this float v, string formattedV);

  public static string StyledNum(Text.Styles s, float inner);

  public static string Style(Text.Styles s, object inner);

  public static string ColorUnity(uint hexCode, object inner);

  public static string MonoPos(
    int position,
    object inner,
    float monoSize = 0.5f,
    int lettersCount = 6,
    string format = "0.0");

  public static string StyledMonoPosPercent(
    float v,
    int pos,
    bool showPosSign = false,
    float monoSize = 0.5f,
    int lettersCount = 6,
    string format = "0.0");

  public static string StyledMonoPosPercent(
    Decimal v,
    int pos,
    bool showPosSign = false,
    float monoSize = 0.5f,
    int lettersCount = 6,
    string format = "0.0");

  public static string Color(string hexCodeRGBA, object inner);

  public static string Color(Eco.Shared.Utils.Color color, object inner);

  /// <summary>Sets text position inside text box (value in EM not pixels) The size of an EM depends on its parent. E.g if the text size of body is 16 pixels, then 150% or 1.5 EM will be 24 pixels (1.5 * 16).</summary>
  /// <remarks>Not supported in UIToolkit</remarks>
  public static string Pos(int position, object inner);

  public static string Pos(float position, object inner);

  /// <summary>Sets text position inside text box ignoring font size</summary>
  /// <remarks>In most cases it's better to use <see cref="M:Eco.Shared.Utils.Text.Pos(System.Int32,System.Object)" /></remarks>
  public static string PosIgnoreFont(int position, object inner);

  public static string Indent(object inner, int indentDepth = 1);

  public static string Bold(object inner);

  public static string Italics(object inner);

  public static string Underline(object inner);

  /// <summary>Draws a background tint behind the text. Colour needs an alpha component, e.g. #ffffff14.</summary>
  public static string Mark(string color, object inner);

  public static string Size(int size, object inner);

  public static string Size(float percent, object inner);

  public static string Sub(object inner);

  public static string Sup(object inner);

  public static string NonBreaking(object inner);

  public static string LineHeight(object inner, int percentage);

  public static string Location(Vector3i pos);

  public static string Link(object inner, string id);

  public static string HotkeyCode(string keyName);

  public static string Distance(this Vector3 pos, bool shortDesc = true);

  /// <summary>
  /// Build a link to copy to clipboard on click
  /// <br> "<paramref name="name" /> (click to copy): &lt;link=copy:<paramref name="toCopy" />&gt;{<paramref name="inner" />}&lt;/link&gt;" </br>
  /// </summary>
  /// <param name="toCopy"> Content copied to clipboard on click </param>
  public static string CopyToClipBoard(string name, object inner, string toCopy);

  public static string UserTextureIcon(int id, UserTextureSize size = UserTextureSize.Small, string text = "");

  public static string Icon(string iconName, string text = "", string type = "");

  public static string Icon(string iconName, string text, uint colorHexCode, string type = "");

  public static string Icon(IconUtils.SymbolicIcons icon, string text = "", string type = "");

  public static string Icon(
    IconUtils.SymbolicIcons icon,
    string text,
    uint colorHexCode,
    string type = "");

  public static string Pass { get; }

  public static string Fail { get; }

  public static string PassFail(bool val);

  /// <summary>Creates a font tag for use with TextMeshPro on the Client. http://digitalnativestudios.com/textmeshpro/docs/rich-text/#font </summary>
  /// <returns>TextMeshPro compatible font tag.</returns>
  public static string Font(string fontName, string text);

  /// <inheritdoc cref="M:Eco.Shared.Utils.Text.Font(System.String,System.String)" />
  public static string Font(string fontName, string materialName, string text);

  public static string VAligned(string value, string alignment);

  public static string Plural(string singular, string plural, int count);

  public static string PluralInfo(string singular, string plural, int count);

  public static LocString PluralLocStr(string singular, string plural, float count);

  public static LocString Plural(LocString singular, LocString plural, float count);

  public static LocString PluralNoCount(LocString singular, LocString plural, float count);

  public static string ColoredPercent(float v);

  public static string ColoredPercentInvert(float v);

  public static string ColoredPercent(float v, float redAt, float yellowAt);

  public static string ColoredPercentInvert(float v, float redAt, float yellowAt);

  /// <summary>Transitions the percent color from red to yellow to green based on percent.</summary>
  public static string GradientColoredPercent(float v);

  /// <summary>Transitions the percent color from red to yellow to green based on percent.</summary>
  public static string GradientColoredPercent(float v, Eco.Shared.Math.Range range);

  public static string QuotedBold(string text);

  /// <summary> Cuts visible part of the content after provided width and replaces it with a hoverable link to see the origin. </summary>
  public static string Truncate(string input, int width);

  /// <summary> Aligns strings within blocks with specified widths. </summary>
  public static string Columns(
    int spaceBetweenColumns,
    int emBaseSize,
    params (string Text, int Width)[] content);

  public static string ColoredNum(float v, float redAt, float yellowAt, string format);

  public static string ColoredNumInvert(float v, float redAt, float yellowAt, string format);

  public static string ColoredString(float v, float redAt, float yellowAt, string s);

  public static string Color(uint hexCode, object inner);

  public static LocString Table(
    IEnumerable<(LocString Col1, LocString Col2)> stringsTable);

  public static LocString Table(
    IEnumerable<(LocString Col1, LocString Col2, LocString Col3)> stringsTable);

  public static LocString Table(
    IEnumerable<(LocString Col1, LocString Col2)> stringsTable,
    LocString header);

  public static LocString Table(
    IEnumerable<(LocString Col1, LocString Col2, LocString Col3)> stringsTable,
    LocString header);

  public static string Table(IEnumerable<IEnumerable<LocString>> stringsTable);

  /// <summary>Coloring text with default or negative color by condition</summary>
  public static string NegativeOrDefault(string s, bool isNegative);

  /// <summary>Coloring text with positive or negative color by condition</summary>
  public static string NegativeOrPositive(string s, bool isNegative);

  public static string FormatIntegerInString(string input);

  public enum Styles
  {
    Info,
    InfoLight,
    Error,
    ErrorLight,
    WhisperLight,
    Name,
    Controls,
    Item,
    Recipe,
    Bonus,
    Subtext,
    Header,
    Positive,
    Negative,
    Warning,
    Currency,
    EcoCredit,
    CurrencyNoBold,
    CurrencyNoBoldRed,
    BankAccount,
    Government,
    Title,
    ChatTag,
    ChatTagReadOnly,
    ChatTime,
    Hint,
    Culture,
    InfluenceRadius,
    Reputation,
    Dollar,
  }
}
