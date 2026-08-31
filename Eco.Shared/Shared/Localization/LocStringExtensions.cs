// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.LocStringExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;
using System;

#nullable disable
namespace Eco.Shared.Localization;

public static class LocStringExtensions
{
  public static LocString Italic(this LocString text);

  public static LocString Bold(this LocString text);

  public static LocString Underline(this LocString text);

  public static LocString NonBreaking(this LocString text);

  public static LocString Style(this LocString text, Text.Styles style);

  public static LocString Link(this LocString text, string id);

  public static LocString Header(this LocString text);

  public static LocString Color(this LocString text, string color, bool hash = false);

  public static LocString Lower(this LocString text);

  public static LocString Dash(this LocString text, bool space = true);

  public static LocString Concat(this LocString text, LocString s);

  public static LocString ConcatLoc(this LocString text, FormattableString fs);

  public static LocString ConcatLocStr(this LocString text, string s);

  public static LocString AppendNL(this LocString text, LocString s);

  public static LocString AppendLine(this LocString text, LocString s);

  public static LocString AppendLineLoc(this LocString text, FormattableString fs);

  public static LocString AppendLineLocStr(this LocString text, string s);

  public static LocString AppendLine(this LocString text);

  public static LocString WrapParentheses(this LocString text);
}
