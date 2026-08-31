// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.StringUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;
using System;
using System.Collections;

#nullable disable
namespace Eco.Core.Utils;

public static class StringUtils
{
  public static string VersionIdentifier;

  public static string RemoveWhitespace(this string input);

  public static string Spaces(int count);

  public static LocString Pluralize(this LocString word, int count = 2);

  public static LocString PluralizeNum(this LocString word, int count = 2);

  public static string Pluralize(this string word, int count = 2);

  public static string PluralizeNum(this string word, int count = 2);

  public static string PluralizeLoc(this string word, float count);

  public static string Hours(this float s);

  public static bool IsEmpty(this string s);

  public static string IfEmpty(this string s, string ifEmpty);

  public static Guid? CreateGuidOrNull(string s);

  public static string RandomString(int length);

  public static string DisplayArea(int val);

  public static bool IsDigitsOnly(this string str);

  public static string ShortName(string name, Func<string, bool> exists);

  public static string UniqueKey(this IDictionary existing, string root);

  public static string FixCaps(this string str);

  public static (string Name, int Number) SplitIntoNameAndNumber(string str);

  public static string IncrementVersion(string str);

  public static string TrailingVersion(this string str);

  public static (string Left, string Right) SplitAtIndex(this string s, int index);

  public static string PrependNewlineIfNeeded(this string text);

  /// <summary> Postfix will be added at the end of the <paramref name="other" /> if it is set.
  /// For a demo see how AccountsChangeSet.DescribeChange wraps amount description with parenthesis. </summary>
  public static LocString JoinSafe(
    this LocString s,
    LocString? other,
    string separator,
    string postfix = "");

  public static LocString AppendSpaceIfSet(this LocString s);

  public static string ConcatTogether(char joiner, params string[] strings);

  /// <summary>If the specified string is used at the end of the current string, we return the new string without that part else we just return false.</summary>
  public static bool TryRemoveFromEnd(this string s, string stringToRemove, out string newString);
}
