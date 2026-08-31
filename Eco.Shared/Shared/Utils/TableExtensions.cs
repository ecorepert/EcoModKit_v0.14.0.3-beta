// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TableExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Eco.Shared.Utils;

public static class TableExtensions
{
  public static void AddRow1Loc(this StringBuilder sb, FormattableString c1, params string[] cells);

  public static void AddRow12Loc(
    this StringBuilder sb,
    FormattableString c1,
    FormattableString c2,
    params string[] cells);

  public static void AddRowParams(this StringBuilder sb, params LocString[] cells);

  public static void AddRow(this StringBuilder sb, IEnumerable<LocString> row);

  public static void StartTable(this StringBuilder sb);

  public static void EndTable(this StringBuilder sb);

  public static void StartTable(this LocStringBuilder sb);

  public static void EndTable(this LocStringBuilder sb);

  public static LocString MakeTableLocStr(
    this IEnumerable<(LocString Col1, LocString Col2)> strings,
    string title);

  public static LocString MakeTableLoc(
    this IEnumerable<(LocString Col1, LocString Col2)> strings,
    FormattableString title);

  public static LocString MakeTable(
    this IEnumerable<(LocString Col1, LocString Col2)> strings,
    LocString title);
}
