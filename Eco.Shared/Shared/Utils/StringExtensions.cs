// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.StringExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

#nullable enable
namespace Eco.Shared.Utils;

public static class StringExtensions
{
  public static 
  #nullable disable
  Regex AllowedChatTagsRegex;
  public static Regex AllowedChatTagsNoSizeRegex;

  public static string AddSpacesBetweenCapitals(this string value);

  public static LocString AddSpacesBetweenCapitals(this LocString value);

  public static string[] SplitOnCapitals(this string value);

  public static string CapitalizeAllWords(this string value);

  public static string Capitalize(this string value);

  public static string DeCapitalize(this string value);

  public static bool IsDisplayedAsNullOrEmpty(this string str);

  /// <summary>Join a string to another with a separator, if both are set.</summary>
  public static LocString JoinSafe(
    this LocString s,
    LocString other,
    string separator = " ",
    string postfix = "");

  /// <summary>Put a word (like 'and') between two strings, if there are indeed two strings.</summary>
  public static LocString JoinWordSafe(
    this LocString s,
    LocString other,
    string word,
    string postfix = "");

  public static string JoinSafe(this string s, string other, string separator = " ", string postfix = "");

  /// <summary>Check if a string is in the beginning of this string, whole words included. Partial overlap will return false. </summary>
  public static bool StartWithWords(this string value, string compareTo);

  /// <summary>Strips CData XML tags from the input string and returns the cleaned version.</summary>
  public static string StripCData(this string input);

  /// <summary>Strips HTML/Eco tags from the string and returns the cleaned version.</summary>
  public static string StripTags(this string input);

  /// <summary>Strip all special characters from a given string.</summary>
  /// <param name="removeSpaces">Do we also want to remove all spaces ?</param>
  public static string StripSpecialCharacters(this string input, bool removeSpaces = false);

  /// <summary>Same as <see cref="M:Eco.Shared.Utils.StringExtensions.StripTags(System.String)" />, but does not strip tags that are inside 'noparse' tag.</summary>
  public static string StripTagsNoParse(this string input);

  /// <summary> Returns true if given string contains ANY tags. </summary>
  public static bool ContainsTags(this string input);

  /// <summary> Removes all tags from a given string EXCEPT 'color' tags (includes opening, closing, and the short '&lt;#XXXXXX&gt;' form). </summary>
  public static string StripNonColorTags(this string input);

  /// <summary> Removes all tags from a given string EXCEPT allowed formatting tags. Can optionally strip size tags as well. </summary>
  /// <param name="input">String to process</param>
  /// <param name="stripSizeTags">If true, size tags will also be removed</param>
  public static string StripUnallowedChatTags(this string input, bool stripSizeTags = true);

  /// <summary> Removes all size tags from a given string (includes both opening and closing tags). </summary>
  public static string StripSizeTags(this string input);

  /// <summary> Removes all icon tags from a given string (includes both opening and closing tags). </summary>
  public static string StripIconTags(this string input);

  /// <summary> Removes all link tags from a given string (includes both opening and closing tags). </summary>
  public static string StripLinkTags(this string input);

  /// <summary>Strips character <paramref name="ch" /> from <paramref name="input" /> string.</summary>
  public static string Strip(this string input, char ch);

  public static string Wrap(this string str, char c);

  public static string Wrap(this string str, string prefix = "", string suffix = "");

  public static string FixLinefeeds(this string input);

  public static bool ContainsCaseInsensitive(this string container, string s);

  public static bool StartWithCaseInsensitive(this string container, string s);

  /// <summary>We strip both strings from all tags and then we check whether the string can be found in the other string or not.</summary>
  public static bool ContainsCaseInsensitiveIgnoreTags(this string container, string s);

  public static string CapLength(this string s, int len);

  public static string ReduceLength(this string s, ref int extraBytes);

  public static string PercentizeSizeTags(this string input);

  public static bool ContainsAny(this string container, params char[] chars);

  public static bool ContainsAny(this string container, IEnumerable<string> strings);

  public static bool ContainsAnyCaseInsensitive(this string container, IEnumerable<string> strings);

  public static int CompareCaseInsensitive(this string container, string s);

  public static string ClosestMatch(this IEnumerable<string> list, string substring);

  public static int ToInt(this string s, int def = 0);

  public static float ToFloat(this string s, float defaultVal = 0.0f);

  public static T Param<T>(this string[] list, int iParam, T def = null) where T : IConvertible;

  public static string UnitFormat(this float v, string unit);

  public static string Format(this float v);

  public static bool EqualsCaseInsensitive(this string container, string s);

  public static IEnumerable<string> CleanStrings(this IEnumerable<string> e);

  public static string TextList(this IEnumerable<string> e, string sep = "", bool clean = false);

  public static LocString TextList(this IEnumerable<LocString> e);

  public static LocString TextList(this IEnumerable<LocString> e, string sep = "");

  public static LocString TextList(this IEnumerable<LocString> e, LocString sep);

  public static LocString TextList(this IEnumerable<LocString> e, int columns, int columnsWidth);

  /// <summary>  Version of <see cref="M:Eco.Shared.Utils.StringExtensions.DescribeAmount(System.Collections.Generic.IEnumerable{Eco.Shared.Localization.LocString},Eco.Shared.Localization.LocString)" />. </summary>
  public static LocString DescribeAmountLoc(this IEnumerable<LocString> lines, string description);

  public static LocString DescribeAmountLocStr(
    this IEnumerable<LocString> lines,
    FormattableString description);

  /// <summary> Combines a set of lines into a foldout list. The link will be in format "description: linesCount". </summary>
  public static LocString DescribeAmount(this IEnumerable<LocString> lines, LocString description);

  public static string DescribeBytes(this int bytes);

  public static string DoubleNewlineList(this IEnumerable<string> e);

  public static string NewlineList(this IEnumerable<string> e, bool clean = false);

  public static string NewlineList(this IEnumerable<object> e, bool clean = false);

  public static LocString DoubleNewlineList(this IEnumerable<LocString> e);

  public static LocString NewlineList(this IEnumerable<LocString> e);

  public static LocString NewlineList(this IEnumerable<LocString> e, int columns, int columnsWidth);

  public static LocString NewlineList(this IEnumerable<LocString> e, LocString empty);

  public static LocString NewlineListParams(params string[] strings);

  public static LocString LimitedInlineShow(
    this IEnumerable<LocString> list,
    int numToShow,
    out int count);

  public static string ItemizedCommaList(this IEnumerable<string> elements);

  public static string Space(this string s, string other);

  public static LocString SimpleCommaList(this IEnumerable<LocString> phrases);

  public static string SimpleCommaList(this IEnumerable<string> phrases);

  public static string SimpleCommaListNoSpace(this IEnumerable<string> phrases);

  public static LocString CommaList(this IEnumerable<LocString> phrases);

  public static LocString CommaList(this IEnumerable<LocString> phrases, LocString noneText);

  public static LocString JoinList(this IEnumerable<LocString> phrases, string joinText);

  /// <summary>
  /// Creates comma separated list from <paramref name="phrases" />.
  /// If input is empty then it will return <paramref name="noneText" />.
  /// Otherwise it will return comma separated list prefixed with <paramref name="prefix" /> and suffixed with <paramref name="suffix" />.
  /// </summary>
  public static LocString CommaList(
    this IEnumerable<LocString> phrases,
    LocString prefix,
    LocString suffix,
    LocString noneText);

  public static LocString LimitedLineList(
    this IEnumerable<LocString> phrases,
    LocString prefix,
    LocString suffix,
    LocString noneText,
    int limit);

  /// <summary>Creates comma separated list of given phrases.</summary>
  /// <param name="phrases">Phrases to include in the list.</param>
  /// <param name="noneText">Alternative text displayed when list of phrases is empty.</param>
  /// <param name="joinText">Text used to join last two phrases (for example for 'and' result is: 'phrase1, phrase2, phrase3 and phrase4').</param>
  /// <param name="phrasesOnSeparateLines">Set to true to separate phrases with new line in addition to comma.</param>
  public static LocString CommaList(
    this IEnumerable<LocString> phrases,
    LocString noneText,
    LocString joinText,
    bool phrasesOnSeparateLines = false);

  public static string SlashList(this IEnumerable<string> phrases);

  public static string CommaList(
    this IEnumerable<string> phrases,
    string noneText = "",
    string joinText = "and",
    bool sectionsOnLine = false);

  public static LocString DoubleLines(this LocString s);

  public static string DoubleLines(this string s);

  public static string DoubleLinesToOneSpaceLine(this string s);

  /// <summary> Trim the end if it matches a string. </summary>
  public static string TrimEndString(this string source, string value);

  /// <summary>Shortens a string with appending of suffix. May work with tagged messages, and in this case will count only real text ignoring tags.</summary>
  public static string Truncate(this string s, int maxLength, string suffix = "", bool onlyBetweenTags = false);

  /// <summary> Checks if string is not null and is not empty. Inverse of <see cref="M:System.String.IsNullOrEmpty(System.String)" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsSet([NotNullWhen(true)] this string s);

  public static bool Multiline(this string s);

  public static string RemoveCamelCase(this string s);

  public static string RemoveSpaces(this string s);

  public static string AppendSpace(this string s);

  /// <summary> Avoid creating new builder if not needed </summary>
  public static void AppendToBuilder(this LocString text, ref LocStringBuilder builder);

  /// <summary>Replaces the first string found.</summary>
  /// <param name="text">String instance to operate on.</param>
  /// <param name="search">String to search for.</param>
  /// <param name="replace">String to replace.</param>
  /// <param name="startIndex">Index to start search from.</param>
  /// <returns>String instance with the value of <paramref name="search" /> replaced with <paramref name="replace" /></returns>
  public static string ReplaceFirst(
    this string text,
    string search,
    string replace,
    int startIndex = 0,
    StringComparison comparasion = StringComparison.Ordinal);

  /// <summary>Replaces first occurence of <paramref name="search" /> with <paramref name="replace" /> after first occurence of <paramref name="after" />.</summary>
  /// <seealso cref="M:Eco.Shared.Utils.StringExtensions.ReplaceFirst(System.String,System.String,System.String,System.Int32,System.StringComparison)" />
  public static string ReplaceFirstAfter(
    this string text,
    string after,
    string search,
    string replace);

  public static string ProfanityFiltered(this string text);

  public static bool HasProfanity(this string text, bool strict = false);

  public static string[] SplitToLines(this string text);

  /// <summary>Helper to split a span into two parts. Fast split call.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ReadOnlySpanTuple<char, char> FastSplit2(
    this ReadOnlySpan<char> text,
    char splitter = ',');

  /// <summary>Helper to split a span into three parts. Fast split call.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ReadOnlySpanTuple<char, char, char> FastSplit3(
    this ReadOnlySpan<char> text,
    char splitter = ',');

  /// <summary>Splits a string into chunks of equal or less size as defined by the max size input.</summary>
  /// <param name="text">String instance to split</param>
  /// <param name="chunkSize">Max size of each chunk.</param>
  /// <returns><see cref="T:System.Collections.Generic.IEnumerable`1" /> containing the instance of <paramref name="text" /> split into chunks determined by the given size.</returns>
  public static IEnumerable<string> SplitToChunks(this string text, int chunkSize);

  public static LocString Indent(this LocString s);

  public static string Indent(this string s);

  public static string Indent(this string s, string indent);

  /// <summary>Converts a string to snake_case.</summary>
  /// <param name="s">String to convert</param>
  /// <returns>The converted String.</returns>
  /// <exception cref="T:System.ArgumentNullException">Thrown when the string is null.</exception>
  public static string ToSnakeCase(this string s);

  /// <summary>Converts a string to CamelCase.</summary>
  /// <param name="s">String to convert</param>
  /// <returns>The converted String.</returns>
  public static string ToCamelCase(this string s);
}
