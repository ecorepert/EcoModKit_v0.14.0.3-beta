// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TableUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary> Contains utility functions that can help style table content. </summary>
public static class TableUtils
{
  /// <summary> Returns an Header that is ready to added to a table as a row. </summary>
  public static 
  #nullable disable
  List<LocString> GetTitleRowLoc(string value);

  /// <summary> Returns an Header that is ready to added to a table as a row. </summary>
  public static List<LocString> GetDescriptionRowLoc(string value);

  /// <summary> Returns an empty table with howmany empty lines we want. Can be used for styling purposes. </summary>
  public static IEnumerable<List<LocString>> MakeEmptyLineTable(int emptyLines);

  /// <summary> Pass a row and get it back styled with optional amount of empty lines before and after it. </summary>
  public static IEnumerable<List<LocString>> GetStyledRow(
    int prependedEmptyLines,
    List<LocString> row,
    int appendedEmptyLines);
}
