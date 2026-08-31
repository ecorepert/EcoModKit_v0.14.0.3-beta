// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.Localizer
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Localization;

public static class Localizer
{
  public static SubscribableEvent<Action> OnLanguageChanged;
  public static Action<MissingString> MissedString;
  public static Func<bool> TrackMissingStrings;
  public static Func<bool> LogMissingStrings;
  public static Func<bool> LogMissingStringsStack;
  public static readonly string LocDumpFileName;
  public static readonly string[] NormalizedLanguageOptions;
  public static readonly string[] QaOnlyLanguageOptions;

  public static string[] AllEnglishStrings { get; }

  public static SupportedLanguage CurrentLanguage { get; }

  public static List<MissingString> MissingStrings { get; }

  public static HashSet<string> InvalidFormatStrings { get; }

  public static bool AllowGibberishifyFailed { get; set; }

  public static bool StringsLoaded { get; }

  public static bool ChinaLockedMode { get; set; }

  public static bool IsChinaLauncher { get; set; }

  public static bool DebugTranslations { get; }

  public static bool Initialized { get; }

  public static LocString Format(string format, params object[] args);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static LocString NLS(string s);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static LocString NL(FormattableString format);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static LocString NotLocalizedStr(string s);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static LocString NotLocalized(FormattableString format);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static LocString DoStr(string s);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static LocString Do(FormattableString format);

  /// <summary>Localize a string as a prepend, then display the rest after a ':'. Ex: PrependLocStr("Room", room.Info) will return Localized "Room: {room.Info}" </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static LocString PrependLocStr(string toLocalize, LocString rest);

  /// <summary>Accepts a variable number of formattable strings, localzing them as lines and appending them.</summary>
  public static LocString DoLineListLoc(params FormattableString[] formats);

  /// <summary>Accepts a variable number of formattable strings, localzing them as lines and appending them.</summary>
  public static LocString DoLineListLocStr(params string[] lines);

  /// <summary>Append a bunch of locstring together into a new locstring</summary>
  public static LocString DoLineList(params LocString[] strings);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static string Tag(string s);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static string LocalizeString(string s);

  public static LocString StyledPlural(string s, float num);

  /// <summary> Styles originally negative numbers in red (negative style) while removing the negative sign from the output.</summary>
  public static LocString StyledPluralUnsigned(string s, float num);

  public static LocString StyledPlural(string s, int num);

  public static LocString Plural(string s, int num);

  public static LocString PluralNoNum(string s, int num = 2);

  /// <summary>Pluralize when a float is involved.  IE, 1.0 should be 'not plural', 1.1 should be 'plural</summary>
  public static LocString PluralNoNum(string s, float num);

  public static LocString PluralLocStr(string s, string plur, int num);

  public static void SetDebugTranslations(bool value);

  public static LocString Ordinal(int num);

  /// <summary>Adds a/an based on the first letter of the given string, the given word shouldn't include tags.</summary>
  public static LocString A(LocString word, bool capitalized = false);

  /// <summary>Adds a/an based on the first letter of the given string, safely excuted and strips tags if any.</summary>
  public static LocString A_strip(LocString word);

  public static string LocalizeString(string s, SupportedLanguage language);

  public static string[] GetLocalizedStringSet(string s);

  /// <summary>True when <paramref name="candidate" /> equals <paramref name="english" /> or any known translation of it.
  /// Useful for matching stored strings that were baked in whatever language was active when they were written.</summary>
  public static bool IsTranslationOf(string candidate, string english);

  public static void ClearMissingLocalizerStrings();

  public static void DumpMissingLocalizerStrings(string dir = null);

  /// <summary>Sets initial localizer language and invoke post initialize actions</summary>
  /// 
  ///             For things that get setup before localization, but must wait for localizer correct language
  public static void InitializeLanguage(SupportedLanguage language);

  /// <summary>Call action after initialization or instantly when already initialized</summary>
  public static void OnInitialized(Action action);

  public static void TrySetLanguage(SupportedLanguage language);

  public static bool IsNormalizedLanguage(SupportedLanguage language);

  public static bool IsQaOnlyLanguage(SupportedLanguage language);

  public static bool TranslationExists(string[] set, SupportedLanguage language);

  public static void LoadStrings();

  /// <summary>
  /// Returns the fraction of active (non-obsolete) English strings that have a non-empty, non-obsolete translation
  /// in <paramref name="lang" />. 0 = nothing translated, 1 = fully translated.
  /// English and Gibberish always return 1 (English is the source; Gibberish is auto-generated). If stats haven't
  /// been computed yet (e.g. early init or the legacy CSV path) returns 1 to avoid false-alarm UI indicators.
  /// </summary>
  public static float GetTranslationCompleteness(SupportedLanguage lang);

  public static string Convert(string s, bool toFile);

  public static void InitCalendarsForLocales();

  /// <summary> Adds "a" or "an" to the phrase depending on some common English rules E.g a user, an item </summary>
  public static string AddIndefiniteArticle(LocString text);

  /// <summary> Returns "a" or "an" depending on some common English rules</summary>
  public static string GetIndefiniteArticle(string text);
}
