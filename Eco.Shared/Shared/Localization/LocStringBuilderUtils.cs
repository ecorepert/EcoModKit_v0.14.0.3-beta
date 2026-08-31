// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.LocStringBuilderUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Localization;

/// <summary> utilities for <see cref="T:Eco.Shared.Localization.LocStringBuilder" /> </summary>
public static class LocStringBuilderUtils
{
  public static LocStringBuilder AppendListLoc(
    this LocStringBuilder s,
    FormattableString title,
    IEnumerable<string> list,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static LocStringBuilder AppendList(
    this LocStringBuilder s,
    LocString title,
    IEnumerable<LocString> list,
    bool showEmptyLists = true,
    bool appendNewLine = true);

  public static void AddRow(this LocStringBuilder sb, IEnumerable<LocString> row);

  public static void AddRow(this LocStringBuilder sb, (LocString Col1, LocString Col2) row);

  public static void AddRow(
    this LocStringBuilder sb,
    (LocString Col1, LocString Col2, LocString Col3) row);
}
