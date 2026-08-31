// Decompiled with JetBrains decompiler
// Type: Eco.Stats.StatCategory
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Stats;

/// <summary>A container for stats, used to organize them.</summary>
public class StatCategory
{
  public 
  #nullable disable
  string Name;
  public string DisplayName;
  public List<StatInfo> ChildrenStats;
  public List<StatCategory> ChildrenCategories;

  /// <summary>Gets all the stat infos in all categories recursively.</summary>
  /// <returns>IEnumerable of all stats and child stats contained in this category.</returns>
  public IEnumerable<StatInfo> Flatten();

  /// <summary>Gets all the categories in this category recursively.</summary>
  /// <returns>IEnumerable of all categories and child categories contained in this category.</returns>
  public IEnumerable<StatCategory> Categories();

  /// <summary>
  /// Iterates over all stats and child categories recursively and returns a dictionary
  /// containing the tree path seperated by slashes and a value of the stat info.
  /// 
  /// Example: "/Environment/EcoSystem/": StatInfo
  /// </summary>
  /// <returns>Dictionary containing the paths and stat info of all child stats.</returns>
  public Dictionary<string, StatInfo> GetStatPaths(string currentPath = "");
}
