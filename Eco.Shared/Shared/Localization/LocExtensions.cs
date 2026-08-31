// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.LocExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Reflection;
using System.Text;

#nullable enable
namespace Eco.Shared.Localization;

public static class LocExtensions
{
  /// <summary>Get FOLDOUT Loc Display name of an Enum value. If that value has `LocDisplayNameAttribute` then use that instead of the Value's name. If that value has `LocDescriptionAttribute` then do foldout with the description.</summary>
  /// 
  ///             should be renamed to GetFoldoutDisplayName, but it has too many references
  public static LocString GetLocDisplayName(this 
  #nullable disable
  Enum e, bool plural = false, bool foldout = true);

  /// <summary>Get only Loc Display name from localized Enum</summary>
  /// 
  ///             aware of <see cref="T:Eco.Shared.Localization.LocDisplayNameAttribute" />
  /// , <see cref="T:Eco.Shared.Localization.NotLocalizedDisplayNameAttribute" />
  public static LocString GetEnumLocDisplayName(this Enum e);

  /// <summary> Get a localized display name, using the the defined LocDisplayName attribute, or if that's missing, by localizing the 'remove camel case' of the name.</summary>
  /// <param name="member"></param>
  /// <returns></returns>
  public static LocString GetLocDisplayName(this MemberInfo member);

  /// <summary> Get the display name and query the color of this property from the Color attribute and apply it.</summary>
  public static LocString GetLocDisplayNameColored(this MemberInfo member);

  public static LocString GetLocDescription(this MemberInfo member);

  public static string GetName(this Enum e);

  public static LocString GetLocDescription(this Enum e);

  public static LocString GetLocEnumName(this Type enumType, object entry);

  public static LocString GetLocEnumName<TEnum>(this TEnum enumValue) where TEnum : Enum;

  public static LocString GetLocDescription(this Type type);

  /// <summary> Inserts the line at the beginning of the builder. </summary>
  public static void InsertLineLoc(this LocStringBuilder sb, FormattableString line);

  public static void InsertLine(this LocStringBuilder sb, LocString line);

  public static void AppendLineIfNeeded(this StringBuilder s);

  public static void AppendLineLoc(this StringBuilder s, FormattableString text);

  public static void AppendLineLocStr(this StringBuilder s, string text);

  public static void AppendLoc(this StringBuilder s, FormattableString text);

  public static void AppendLocStr(this StringBuilder s, string text);

  public static void AppendLineParenLoc(this StringBuilder s, FormattableString text);

  public static void Join(this StringBuilder s, string text);

  public static void JoinLoc(this StringBuilder s, FormattableString text);

  public static void JoinLocStr(this StringBuilder s, string text);

  public static LocString ToStringLoc(this StringBuilder s);

  public static LocString Loc(this StringBuilder sb);

  public static void Join(this LocStringBuilder s, string text);

  public static void JoinLoc(this LocStringBuilder s, FormattableString text);

  public static void JoinLocStr(this LocStringBuilder s, string text);

  public static void AppendLineIfSet(this StringBuilder sb, string text);

  public static void AppendLineIfSetLoc(this StringBuilder sb, FormattableString text);

  public static void AppendLineIfSetLocStr(this StringBuilder sb, string text);

  public static void AppendShowMoreLoc(this LocStringBuilder sb, int addedNum);

  public static void JoinWithSpaceIfNeeded(this LocStringBuilder s, LocString text);

  public static void JoinWithSpaceIfNeeded(this StringBuilder s, LocString text);

  public static void JoinWithSpaceIfNeededLoc(this StringBuilder s, FormattableString text);

  public static void JoinWithSpaceIfNeededLocStr(this StringBuilder s, string text);

  public static void JoinIfNeededLoc(this StringBuilder s, FormattableString text, string sep = "\n");

  public static void JoinIfNeeded(this StringBuilder s, LocString text, string sep = "\n");

  public static void JoinIfNeededLoc(this LocStringBuilder s, FormattableString text, string sep = "\n");

  public static void JoinIfNeeded(this LocStringBuilder s, LocString text, string sep = "\n");

  /// <summary>Crops LocStringBuilder to given maxLength.</summary>
  /// <remarks>If the LocString is shorter than maxLength returns same LocString.</remarks>
  public static void CropUntilLengthIfNeeded(this LocStringBuilder s, int maxLength);

  /// <summary>Append a LocString respecting length limit.</summary>
  /// <remarks>Crops first LocString if the length exceeds limit and appends second.
  /// Has an option to include space in between.</remarks>
  public static void AppendStringWhileRespectingMaxLength(
    this LocStringBuilder s,
    LocString append,
    int maxlength,
    bool addSpace = false);
}
